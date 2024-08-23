using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PMIS____GUI_Design
{
    public partial class NewMilestone : Form
    {
        public int projectID;
        public NewMilestone(int projectID)
        {
            InitializeComponent();
            this.projectID = projectID;
        }

        private void Create()
        {
            using (DataContext context = new DataContext())
            {
                var milestoneName = textBox1.Text.Trim();
                var milestoneDate = textBox2.Text.Trim();

                if (string.IsNullOrEmpty(milestoneName)) //conditionals - input validation
                {
                    MessageBox.Show("\"Milestone Name\" is required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                context.Milestones.Add(new MilestoneData //sets a function to add the text box values to Project data context
                {
                    Milestone_ProjectId_FK = projectID,
                    MilestoneName = milestoneName,
                    MilestoneDate = milestoneDate
                });

                //try-catch to add project to database
                try
                {
                    context.SaveChanges();
                    MessageBox.Show($"Milestone created successfully!\n{milestoneName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while writing to the database file.\nPlease try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Create();
        }
    }
}
