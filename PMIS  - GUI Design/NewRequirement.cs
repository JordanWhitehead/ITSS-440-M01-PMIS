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
    public partial class NewRequirement : Form
    {
        public int projectID;
        public NewRequirement(int projectID)
        {
            InitializeComponent();
            this.projectID = projectID;
        }
        private void Create()
        {
            using (DataContext context = new DataContext())
            {
                var requirementName = textBox1.Text.Trim();
                var requirementDescr = textBox2.Text.Trim();

                if (string.IsNullOrEmpty(requirementName)) //conditionals - input validation
                {
                    MessageBox.Show("\"Requirement Name\" is required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                context.Requirements.Add(new RequirementData //sets a function to add the text box values to Project data context
                {
                    Requirement_ProjectId_FK = projectID,
                    RequirementName = requirementName,
                    RequirementDescr = requirementDescr
                });

                //try-catch to add poject to database
                try
                {
                    context.SaveChanges();
                    MessageBox.Show($"Requirement created successfully!\n{requirementName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while writing to the database file.\nPlease try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Create();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
