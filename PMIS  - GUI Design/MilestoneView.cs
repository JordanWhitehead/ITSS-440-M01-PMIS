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
    public partial class MilestoneView : Form
    {
        public int milestoneID;
        public MilestoneView(int milestoneID)
        {
            InitializeComponent();
            this.milestoneID = milestoneID;
            LoadProjectInfo();
        }
        private void LoadProjectInfo()
        {
            using (DataContext context = new DataContext()) //set up data context object for EF
            {
                var milestone = context.Milestones
                    .FirstOrDefault(p => p.MilestoneId == milestoneID); //matches ProjectID (data model) with projectID (from control listView1)
                DALabel1.Text = $"ITSS-440-M01\r\nProject Management Information System\r\n{milestone.MilestoneName}";
                //start text boxes
                textBox1.Text = milestone.MilestoneName.ToString();
                textBox2.Text = milestone.MilestoneDate.ToString();
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
                var milestone = context.Milestones
                    .FirstOrDefault(p => p.MilestoneId == milestoneID);

                milestone.MilestoneName = string.IsNullOrEmpty(textBox1.Text) ? "name left empty" : textBox1.Text;
                milestone.MilestoneDate = string.IsNullOrEmpty(textBox2.Text) ? "" : textBox2.Text;

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
                MilestoneData foundMilestone = context.Milestones.Find(milestoneID);
                if (foundMilestone != null)
                {
                    var messageBoxAnswer = MessageBox.Show($"Are you sure you would like to delete this milestone?\nMilestone Name: {foundMilestone.MilestoneName}", "Delete Milestone", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (messageBoxAnswer == DialogResult.Yes)
                    {
                        context.Remove(foundMilestone);
                        context.SaveChanges();
                        //searchProjectsWindow.ReadAndSearch("a");
                        this.Close();
                    }
                }
            }
        }
    }
}
