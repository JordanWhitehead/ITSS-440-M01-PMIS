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
    public partial class AssignResourcesToTask : Form
    {
        public List<ResourceData> DatabaseResources { get; private set; }
        public int taskID;
        public AssignResourcesToTask(int taskID)
        {
            InitializeComponent();
            this.taskID = taskID;
            ReadAndSearch("");
        }
        public void ReadAndSearch(string searchValue)
        {
            listView1.Items.Clear();

            using (DataContext context = new DataContext())
            {
                DatabaseResources = context.Resources
                    .Where(p => p.ResourceId.ToString().ToLower().Contains(searchValue) ||
                        p.ResourceName.ToLower().Contains(searchValue) ||
                        p.ResourceDescription.ToLower().Contains(searchValue))
                    .ToList();
            }

            foreach (var res in DatabaseResources)
            {
                ListViewItem item = new ListViewItem(res.ResourceId.ToString());
                item.SubItems.Add(res.ResourceName.ToString());
                item.SubItems.Add(res.ResourceDescription.ToString());

                listView1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (DataContext context = new DataContext())
            {
                bool proceedToAdd = false;
                try //tries to set attributes
                {
                    int resourceID = int.Parse(listView1.SelectedItems[0].Text);
                    context.AssignedResources.Add(new Resource_Task_Join
                    {
                        TaskID_FK = taskID,
                        ResourceID_FK = resourceID
                    });
                    proceedToAdd = true;
                }
                catch (Exception ex) { MessageBox.Show("You must select a resource to add it to the task!", "Resource Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                if (proceedToAdd)
                {
                    try //tries to write to the database
                    {
                        context.SaveChanges();
                        MessageBox.Show("Resrouce added to task successfully!", "Resource Added", MessageBoxButtons.OK);
                    }
                    catch { MessageBox.Show("An error occurred while writing to the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }

            }
        }
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                using (DataContext context = new DataContext())
                {
                    bool proceedToAdd = false;
                    try //tries to set attributes
                    {
                        int resourceID = int.Parse(listView1.SelectedItems[0].Text);
                        context.AssignedResources.Add(new Resource_Task_Join
                        {
                            TaskID_FK = taskID,
                            ResourceID_FK = resourceID
                        });
                        proceedToAdd = true;
                    }
                    catch (Exception ex) { MessageBox.Show("You must select a resource to add it to the task!", "Resource Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    if (proceedToAdd)
                    {
                        try //tries to write to the database
                        {
                            context.SaveChanges();
                            MessageBox.Show("Resrouce added to task successfully!", "Resource Added", MessageBoxButtons.OK);
                        }
                        catch { MessageBox.Show("An error occurred while writing to the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResourceMgmtAdd resourceMgmtAdd = new ResourceMgmtAdd();
            resourceMgmtAdd.FormClosed += FormClosed;
            resourceMgmtAdd.ShowDialog();
        }

        private void FormClosed(object? sender, FormClosedEventArgs e)
        {
            ReadAndSearch("");
        }
    }
}
