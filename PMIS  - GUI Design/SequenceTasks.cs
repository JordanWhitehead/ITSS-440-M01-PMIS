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
    public partial class SequenceTasks : Form
    {
        public int projectID;
        public SequenceTasks(int projectID)
        {
            InitializeComponent();
            this.projectID = projectID;
            ReadAndSearch("");
        }
        //ALL THIS IS FOR DRAG AND DROP:
        private void listView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            listView1.DoDragDrop(e.Item, DragDropEffects.Move); //thank you Reddit and old forms- again
        }
        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem))) 
            {
                e.Effect = DragDropEffects.Move;
            }
            else { e.Effect = DragDropEffects.None; }
        }
        private void listView1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof (ListViewItem)))
            {
                ListViewItem draggedItem = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
                Point cp = listView1.PointToClient(new Point(e.X, e.Y)); //full disclosure: I don't know how this works. I got lucky and found it on some forum online. It worked, and I'm rolling with it. 
                ListViewItem targetItem = listView1.GetItemAt(cp.X, cp.Y);

                if (targetItem != null && targetItem != draggedItem)
                {
                    int targetIndex = targetItem.Index;
                    listView1.Items.Remove(draggedItem);
                    listView1.Items.Insert(targetIndex, draggedItem);
                    //this is now preppared to send to db
                }
            }
        }
        //LOAD TO listView1 refactored from other form
        public void ReadAndSearch(string searchValue)
        {
            listView1.Items.Clear();

            using (DataContext context = new DataContext())
            {
                var tasksMatchProject = context.Tasks
                    .Where(p => p.Task_ProjectId_FK == projectID &&
                                (p.TaskName.ToLower().Contains(searchValue) ||
                                 p.TaskDescription.ToLower().Contains(searchValue)))
                    .ToList();
                foreach (var task in tasksMatchProject)
                {
                    var tasksJoinedToResource = context.AssignedResources
                        .Where(rt => rt.TaskID_FK == task.TaskId).ToList();

                    if (tasksJoinedToResource.Count == 0)
                    {
                        ListViewItem item = new ListViewItem(task.TaskId.ToString());
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

                            ListViewItem item = new ListViewItem(task.TaskId.ToString());
                            item.SubItems.Add(task.TaskName.ToString());
                            item.SubItems.Add(task.TaskDescription.ToString());
                            item.SubItems.Add(resource != null ? resource.ResourceName : "");

                            listView1.Items.Add(item);
                            //this was an absolute nightmare. 
                        }
                    }
                }


            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //save
            using DataContext context = new DataContext();
            {
                for (int i = 0; i< listView1.Items.Count; i++)
                {
                    int taskID = int.Parse(listView1.Items[i].SubItems[0].Text);
                    var task = context.Tasks.FirstOrDefault(t => t.TaskId == taskID);
                    if (task != null)
                    {
                        task.SequenceID = i + 1;
                    }
                }

                context.SaveChanges();
                this.Close();
            }
        }
    }
}