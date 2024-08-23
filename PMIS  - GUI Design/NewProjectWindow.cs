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
    public partial class NewProjectWindow : Form
    {
        public List<Project> DatabaseProjects { get; private set; } //creates a context for the list of objects of the Project table

        //CRUD functions
        public void Create()
        {
            using (DataContext context = new DataContext())
            {
                var projectName = textBox1.Text.Trim(); //set values of text boxxs to variable
                var projectManager = textBox2.Text.Trim();

                if (string.IsNullOrEmpty(projectName)) //conditionals - input validation
                {
                    MessageBox.Show("Project Name is required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }
                if (string.IsNullOrEmpty(projectManager))
                {
                    MessageBox.Show("Project Manager is required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }

                context.Projects.Add(new Project{ //sets a function to add the text box values to Project data context
                        ProjectName = projectName,
                        ProjectManager = projectManager});
                
                //try-catch to add project to database
                try { 
                    context.SaveChanges();
                    MessageBox.Show("Project created successfully!", "Success", MessageBoxButtons.OK);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while writing the project to the database file.\nPlease try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public NewProjectWindow()
        {
            InitializeComponent();
        }

        private void NPCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NPSave_Click(object sender, EventArgs e)
        {
            Create();
        }
    }
}
