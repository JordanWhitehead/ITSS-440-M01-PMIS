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
    public partial class RequirementList : Form
    {
        public int projectID;
        public RequirementList(int projectID)
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
                var requirementsMatchProject = context.Requirements
                    .Where(m => m.Requirement_ProjectId_FK == projectID &&
                                (m.RequirementName.ToLower().Contains(searchValue) ||
                                 m.RequirementDescr.ToLower().Contains(searchValue)))
                    .ToList();

                foreach (var requirement in requirementsMatchProject)
                {
                    ListViewItem item = new ListViewItem(requirement.RequirementId.ToString());
                    item.SubItems.Add(requirement.RequirementName.ToString());
                    item.SubItems.Add(requirement.RequirementDescr.ToString());

                    listView1.Items.Add(item);
                }
            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            NewRequirement newRequirement = new NewRequirement(projectID);
            newRequirement.FormClosed += OnReturnToList;
            newRequirement.ShowDialog();

        }
        private void OnReturnToList(object? sender, FormClosedEventArgs e)
        {
            ReadAndSearch("");
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

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedItem = listView1.SelectedItems[0]; //gets first column from selected row in list view ([0] is first in an array)
                int requirementID = int.Parse(selectedItem.Text); //sets the selected item as a variable after parsing to integer
                RequirementView requirementView = new RequirementView(requirementID);
                requirementView.FormClosed += OnReturnToList;
                requirementView.ShowDialog();
            }
        }
    }
}
