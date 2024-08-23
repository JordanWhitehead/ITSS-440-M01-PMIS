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
    public partial class MilestoneList : Form
    {
        public int projectID;
        public MilestoneList(int projectID)
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
                var milestonesMatchProject = context.Milestones
                    .Where(m => m.Milestone_ProjectId_FK == projectID &&
                                (m.MilestoneName.ToLower().Contains(searchValue) ||
                                 m.MilestoneDate.ToLower().Contains(searchValue)))
                    .ToList();

                foreach (var milestone in milestonesMatchProject)
                {
                    ListViewItem item = new ListViewItem(milestone.MilestoneId.ToString());
                    item.SubItems.Add(milestone.MilestoneName.ToString());
                    item.SubItems.Add(milestone.MilestoneDate.ToString());

                    listView1.Items.Add(item);
                }
            }
        }
        private void NewButton_Click(object sender, EventArgs e)
        {
            NewMilestone newMilestone = new NewMilestone(projectID);
            newMilestone.FormClosed += OnReturnToList;
            newMilestone.ShowDialog();

        }
        private void OnReturnToList(object? sender, FormClosedEventArgs e)
        {
            ReadAndSearch("");
        }
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedItem = listView1.SelectedItems[0]; //gets first column from selected row in list view ([0] is first in an array)
                int milestoneID = int.Parse(selectedItem.Text); //sets the selected item as a variable after parsing to integer
                MilestoneView milestoneView = new MilestoneView(milestoneID);
                milestoneView.FormClosed += OnReturnToList;
                milestoneView.ShowDialog();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var tb1Value = textBox1.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(tb1Value)) //conditionals - input validation
            {
                MessageBox.Show("Input is required to search!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ReadAndSearch(tb1Value);
        }
    }
}
