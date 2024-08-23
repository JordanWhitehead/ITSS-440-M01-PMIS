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
    public partial class NewTask : Form
    {
        private int ProjectID;
        public NewTask(int projectID)
        {
            InitializeComponent();
            this.ProjectID = projectID; 
        }
        
        private void Create()
        {
            using (DataContext context = new DataContext())
            {
                var taskName = textBox1.Text.Trim();
                var taskDescription = textBox2.Text.Trim();
                var taskStartDate = textBox3.Text.Trim();
                var taskEndDate = textBox4.Text.Trim();
                int taskCompletion = (int)numericUpDown1.Value;

                if (string.IsNullOrEmpty(taskName)) //conditionals - input validation
                {
                    MessageBox.Show("\"Task Name\" is required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                context.Tasks.Add(new TaskData //sets a function to add the text box values to Project data context
                { 
                    Task_ProjectId_FK = ProjectID,
                    TaskName = taskName,
                    TaskDescription = taskDescription,
                    TaskStartDate = taskStartDate,
                    TaskEndDate = taskEndDate,
                    Completion = taskCompletion
                });

                //try-catch to add project to database
                try
                {
                    context.SaveChanges();
                    MessageBox.Show($"Task created successfully!\n{taskName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while writing the task to the database file.\nPlease try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        private void buttonNewTaskOK_Click(object sender, EventArgs e)
        {
            Create();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
