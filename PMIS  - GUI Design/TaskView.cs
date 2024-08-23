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
    public partial class TaskView : Form
    {
        public int taskID;

        public TaskView(int taskID)
        {
            InitializeComponent();
            this.taskID = taskID;
            LoadTaskInto();
        }

        private void LoadTaskInto()
        {
            using (DataContext context = new DataContext())
            {
                var task = context.Tasks
                    .FirstOrDefault(p => p.TaskId == taskID);
                labelTitle.Text = $"{task.TaskId}: {task.TaskName}";
                //start text boxes
                textBoxTaskID.Text = task.TaskId.ToString();
                textBoxTaskName.Text = task.TaskName.ToString();
                textBoxTaskDescr.Text = string.IsNullOrEmpty(task.TaskDescription) ? "" : task.TaskDescription; //this is a "if-then" shorthand syntax in C#
                textBoxTaskStart.Text = string.IsNullOrEmpty(task.TaskStartDate) ? "" : task.TaskStartDate;
                textBoxTaskEnd.Text = string.IsNullOrEmpty(task.TaskEndDate) ? "" : task.TaskEndDate;
                numericUpDown1.Value = (decimal)task.Completion;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //enable editing
            textBoxTaskName.ReadOnly = false;
            textBoxTaskDescr.ReadOnly = false;
            textBoxTaskStart.ReadOnly = false;
            textBoxTaskEnd.ReadOnly = false;
            numericUpDown1.ReadOnly = false;

            button1.Enabled = false;
            button2.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //save
            using DataContext context = new DataContext();
            {
                var task = context.Tasks
                    .FirstOrDefault(p => p.TaskId == taskID);

                task.TaskName = string.IsNullOrEmpty(textBoxTaskName.Text) ? "name left empty" : textBoxTaskName.Text;
                task.TaskDescription = textBoxTaskDescr.Text;
                task.TaskStartDate = textBoxTaskStart.Text;
                task.TaskEndDate = textBoxTaskEnd.Text;
                task.Completion = numericUpDown1.Value;

                context.SaveChanges();

                textBoxTaskName.ReadOnly = true;
                textBoxTaskDescr.ReadOnly = true;
                textBoxTaskStart.ReadOnly = true;
                textBoxTaskEnd.ReadOnly = true;
                numericUpDown1.ReadOnly = true;

                button1.Enabled = true;
                button2.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //delete
            using (DataContext context = new DataContext())
            {
                TaskData foundTask = context.Tasks.Find(taskID);
                if (foundTask != null)
                {
                    var messageBoxAnswer = MessageBox.Show($"Are you sure you would like to delete this task?\nTask Name: {foundTask.TaskName}", "Delete Project", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (messageBoxAnswer == DialogResult.Yes)
                    {
                        var assignments = context.AssignedResources
                            .Where(p => p.TaskID_FK == taskID).ToList();
                        foreach (var assignment in assignments)
                        {
                            context.AssignedResources.Remove(assignment);
                        }
                        context.Remove(foundTask);
                        context.SaveChanges();
                        //searchProjectsWindow.ReadAndSearch("a");
                        this.Close();
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AssignResourcesToTask assignResourcesToTask = new AssignResourcesToTask(taskID);
            assignResourcesToTask.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ViewAssignedResources viewAssignedResources = new ViewAssignedResources(taskID);
            viewAssignedResources.ShowDialog();
        }
    }
}
