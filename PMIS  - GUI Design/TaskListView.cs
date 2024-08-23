using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMIS____GUI_Design
{
    public partial class TaskListView : Form
    {
        public int projectID;
        public TaskListView(int projectID)
        {
            InitializeComponent();
            this.projectID = projectID;
            ReadAndSearch("");
        }

        public void ReadAndSearch(string searchValue)
        {
            listView1.Items.Clear();

            using (DataContext context = new DataContext())
            {
                var tasksMatchProject = context.Tasks
                    .Where(p => p.Task_ProjectId_FK == projectID &&
                                (p.TaskName.ToLower().Contains(searchValue) ||
                                 p.TaskDescription.ToLower().Contains(searchValue)))
                                  .OrderBy(p => p.SequenceID)
                                .ToList();
                foreach (var task in tasksMatchProject)
                {
                    var tasksJoinedToResource = context.AssignedResources
                        .Where(rt => rt.TaskID_FK == task.TaskId).ToList();

                    if (tasksJoinedToResource.Count == 0)
                    {
                        ListViewItem item = new ListViewItem(task.SequenceID.ToString());
                        item.SubItems.Add(task.TaskId.ToString());
                        item.SubItems.Add(task.TaskName.ToString());
                        item.SubItems.Add(task.TaskDescription.ToString());
                        item.SubItems.Add("");

                        listView1.Items.Add(item);
                    }
                    else
                    {
                        foreach (var join in tasksJoinedToResource)
                        {
                            var resource = context.Resources
                                .FirstOrDefault(r => r.ResourceId == join.ResourceID_FK);

                            ListViewItem item = new ListViewItem(task.SequenceID.ToString());
                            item.SubItems.Add(task.TaskId.ToString());
                            item.SubItems.Add(task.TaskName.ToString());
                            item.SubItems.Add(task.TaskDescription.ToString());
                            item.SubItems.Add(resource != null ? resource.ResourceName : "");

                            listView1.Items.Add(item);
                            //this was awful. 
                        }
                    }
                }


            }

            /*foreach (var task in DatabaseTasks)
            {
                ListViewItem item = new ListViewItem(task.TaskId.ToString());
                item.SubItems.Add(task.TaskName.ToString());
                item.SubItems.Add(task.TaskDescription.ToString());

                listView1.Items.Add(item);
            ***this ain't it***
            }*/
        }

        private void SMSearchButton_Click(object sender, EventArgs e)
        {
            var tb1Value = textBox1.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(tb1Value)) //conditionals - input validation
            {
                MessageBox.Show("Input is required to search!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ReadAndSearch(tb1Value);
        }

        private void TaskListNewTaskButton_Click(object sender, EventArgs e)
        {
            NewTask newTaskWindow = new NewTask(projectID);
            newTaskWindow.FormClosed += OnReturnToTaskList;
            newTaskWindow.ShowDialog();
        }

        private void OnReturnToTaskList(object? sender, FormClosedEventArgs e)
        {
            ReadAndSearch("");
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedItem = listView1.SelectedItems[0].SubItems[1]; //gets second column from selected row in list view ([0] is first in an array and this is kind of an array ?! ???)
                int taskID = int.Parse(selectedItem.Text); //sets the selected item as a variable after parsing to integer
                TaskView taskView = new TaskView(taskID);
                taskView.FormClosed += OnReturnToTaskList;
                taskView.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SequenceTasks sequenceTasks = new SequenceTasks(projectID);
            sequenceTasks.FormClosed += OnReturnToTaskList;
            sequenceTasks.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TaskListReport tlr = new TaskListReport(projectID);
            tlr.WritePDF();
        }
    }
}
