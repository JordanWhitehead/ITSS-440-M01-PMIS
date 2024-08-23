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
    public partial class ManageResourcesWindow : Form
    {
        public List<ResourceData> DatabaseResources { get; private set; }

        public ManageResourcesWindow()
        {
            InitializeComponent();
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
            ResourceMgmtAdd resourceMgmtAdd = new ResourceMgmtAdd();
            resourceMgmtAdd.FormClosed += ResourceMgmtView_FormClosed;
            resourceMgmtAdd.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var tb1Value = textBox1.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(tb1Value)) //conditionals - input validation
            {
                MessageBox.Show("Input is required to search!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ReadAndSearch(tb1Value);
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedItem = listView1.SelectedItems[0]; //gets first column from selected row in list view ([0] is first in an array)
                int resID = int.Parse(selectedItem.Text); //sets the selected item as a variable after parsing to integer

                //open res view and create event handling for when the window is closed
                ResourceMgmtView resMgmtView = new ResourceMgmtView(resID);
                resMgmtView.FormClosed += ResourceMgmtView_FormClosed;
                resMgmtView.ShowDialog();
            }
        }

        private void ResourceMgmtView_FormClosed(object? sender, FormClosedEventArgs e)
        {
            ReadAndSearch("");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                //delete
                using (DataContext context = new DataContext())
                {
                    var selectedItem = int.Parse(listView1.SelectedItems[0].Text);

                    var messageBoxAnswer = MessageBox.Show("Are you sure you would like to delete this resource?", "Delete Resource", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (messageBoxAnswer == DialogResult.Yes)
                    {
                        var assignments = context.AssignedResources
                        .Where(p => p.ResourceID_FK == selectedItem).ToList();

                        foreach (var assignment in assignments)
                        {
                            context.Remove(assignment);
                        }
                        context.SaveChanges();
                    }

                    var delResource = context.Resources
                    .Where(p => p.ResourceId == selectedItem).ToList();
                    context.Remove(delResource.First());
                    context.SaveChanges();
                }
                ReadAndSearch("");
            }

        }
    }
}
