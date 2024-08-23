using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMIS____GUI_Design
{
    public partial class RequirementView : Form
    {
        public int reqID;
        public RequirementView(int reqID)
        {
            InitializeComponent();
            this.reqID = reqID;
            LoadProjectInfo();
        }
        private void LoadProjectInfo()
        {
            using (DataContext context = new DataContext()) //set up data context object for EF
            {
                var requirement = context.Requirements
                    .FirstOrDefault(p => p.RequirementId == reqID); //matches ProjectID (data model) with projectID (from control listView1)
                DALabel1.Text = $"ITSS-440-M01\r\nProject Management Information System\r\n{requirement.RequirementName}";
                //start text boxes
                textBox1.Text = requirement.RequirementName.ToString();
                textBox2.Text = requirement.RequirementDescr.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //enable editing
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;

            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //save update pt 2
            using DataContext context = new DataContext();
            {
                var reqirement = context.Requirements
                    .FirstOrDefault(p => p.RequirementId == reqID);

                reqirement.RequirementName = string.IsNullOrEmpty(textBox1.Text) ? "name left empty" : textBox1.Text;
                reqirement.RequirementDescr = string.IsNullOrEmpty(textBox2.Text) ? "" : textBox2.Text;

                context.SaveChanges();

                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;

                button1.Enabled = true;
                button2.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //delete
            using (DataContext context = new DataContext())
            {
                RequirementData foundReq = context.Requirements.Find(reqID);
                if (foundReq != null)
                {
                    var messageBoxAnswer = MessageBox.Show($"Are you sure you would like to delete this requirement?\nRequirement Name: {foundReq.RequirementName}", "Delete Milestone", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (messageBoxAnswer == DialogResult.Yes)
                    {
                        context.Remove(foundReq);
                        context.SaveChanges();
                        //searchProjectsWindow.ReadAndSearch("a");
                        this.Close();
                    }
                }
            }
        }
    }
}
