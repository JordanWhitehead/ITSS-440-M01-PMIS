using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuestPDF.Helpers.Colors;

namespace PMIS____GUI_Design
{
    public partial class StakeholderView : Form
    {
        public int stakeholderID;
        public StakeholderView(int stakeholderID)
        {
            InitializeComponent();
            this.stakeholderID = stakeholderID;
            LoadStakeholderInfo();
        }
        private void LoadStakeholderInfo()
        {
            using (DataContext context = new DataContext()) //set up data context object for EF
            {
                var stakeholder = context.Stakeholders
                    .FirstOrDefault(p => p.StakeholderID == stakeholderID); //matches ProjectID (data model) with projectID (from control listView1)
                labelTitle.Text = $"{stakeholder.StakeholderID}: {stakeholder.StakeholderName}";
                //start text boxes
                textBoxStakeholderID.Text = stakeholder.StakeholderID.ToString();
                textBoxStakeholderName.Text = stakeholder.StakeholderName.ToString();
                textBoxStakeholderTitle.Text = string.IsNullOrEmpty(stakeholder.StakeholderTitle) ? "" : stakeholder.StakeholderTitle; //this is a "if-then" shorthand syntax in C#
                textBoxStakeholderRole.Text = string.IsNullOrEmpty(stakeholder.StakeholderRole) ? "" : stakeholder.StakeholderRole;
                textBoxStakeholderDescription.Text = string.IsNullOrEmpty(stakeholder.StakeholderDescription) ? "" : stakeholder.StakeholderDescription;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //enable editing
            if (textBoxStakeholderName.ReadOnly == true)
            {
                textBoxStakeholderName.ReadOnly = false;
                textBoxStakeholderTitle.ReadOnly = false;
                textBoxStakeholderRole.ReadOnly = false;
                textBoxStakeholderDescription.ReadOnly = false;

                button2.Enabled = true;
                button1.Enabled = false;
            }
            else if (textBoxStakeholderName.ReadOnly == false)
            {
                textBoxStakeholderName.ReadOnly = true;
                textBoxStakeholderTitle.ReadOnly = true;
                textBoxStakeholderRole.ReadOnly = true;
                textBoxStakeholderDescription.ReadOnly = true;
            }
            else { MessageBox.Show("An error has occurred!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //save
            using DataContext context = new DataContext();
            {
                var stakeholder = context.Stakeholders
                    .FirstOrDefault(p => p.StakeholderID == stakeholderID);

                stakeholder.StakeholderName = string.IsNullOrEmpty(textBoxStakeholderName.Text) ? "name left empty" : textBoxStakeholderName.Text;
                stakeholder.StakeholderTitle = textBoxStakeholderTitle.Text;
                stakeholder.StakeholderRole = textBoxStakeholderRole.Text;
                stakeholder.StakeholderDescription = textBoxStakeholderDescription.Text;

                context.SaveChanges();
                button1.Enabled = true;
                button2.Enabled = false;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //delete
            using (DataContext context = new DataContext())
            {
                StakeholderData foundStakeholder = context.Stakeholders.Find(stakeholderID);
                if (foundStakeholder != null)
                {
                    var messageBoxAnswer = MessageBox.Show($"Are you sure you would like to delete this stakeholder?\nStakeholder Name: {foundStakeholder.StakeholderName}", "Delete Stakeholder", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (messageBoxAnswer == DialogResult.Yes)
                    {
                        var assignments = context.AssignedStakeholders
                            .Where(p => p.StakeholderID_FK == stakeholderID).ToList();
                        foreach(var assignment in assignments )
                        {
                            context.Remove(assignment);
                        }

                        context.Remove(foundStakeholder);
                        context.SaveChanges();
                        this.Close();
                    }
                }
            }
        }
    }
}
