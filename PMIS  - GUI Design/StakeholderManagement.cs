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
    public partial class StakeholderManagement : Form
    {
        public List<StakeholderData> DatabaseStakeholders { get; private set; } //creates a context for the list of objects of the Project table
        public StakeholderManagement()
        {
            InitializeComponent();
            ReadAndSearch("");
        }

        //CRUD functions - <i>...and beyond!</i>
        public void ReadAndSearch(string searchValue)
        {
            listView1.Items.Clear();

            using (DataContext context = new DataContext())
            {
                DatabaseStakeholders = context.Stakeholders
                    .Where(p => p.StakeholderID.ToString().ToLower().Contains(searchValue) ||
                        p.StakeholderName.ToLower().Contains(searchValue) ||
                        p.StakeholderRole.ToLower().Contains(searchValue) ||
                        p.StakeholderTitle.ToLower().Contains(searchValue))
                    .ToList();
            }

            foreach (var stakeholder in DatabaseStakeholders)
            {
                ListViewItem item = new ListViewItem(stakeholder.StakeholderID.ToString());
                item.SubItems.Add(stakeholder.StakeholderName.ToString());
                item.SubItems.Add(stakeholder.StakeholderTitle.ToString());
                item.SubItems.Add(stakeholder.StakeholderRole.ToString());

                listView1.Items.Add(item);
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedItem = listView1.SelectedItems[0]; //gets first column from selected row in list view ([0] is first in an array)
                int stakeholderID = int.Parse(selectedItem.Text); //sets the selected item as a variable after parsing to integer

                //open ProjectView and create event handling for when the window is closed
                StakeholderView stakeholderView = new StakeholderView(stakeholderID);
                stakeholderView.FormClosed += StakeholderView_FormClosed;
                stakeholderView.ShowDialog();
            }
        }

        private void StakeholderView_FormClosed(object? sender, FormClosedEventArgs e)
        {
            ReadAndSearch("");
            //this code also used when new stakeholder window is closed
        }

        private void resourceMgmtSearchButton_Click(object sender, EventArgs e)
        {
            var tb1Value = textBox1.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(tb1Value)) //conditionals - input validation
            {
                MessageBox.Show("Input is required to search!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ReadAndSearch(tb1Value);
        }

        private void stakeholderMgmtNewButton_Click(object sender, EventArgs e)
        {
            NewStakeholder newStakeholder = new NewStakeholder();
            newStakeholder.FormClosed += StakeholderView_FormClosed;
            newStakeholder.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                //delete
                using (DataContext context = new DataContext())
                {
                    var selectedItem = int.Parse(listView1.SelectedItems[0].Text);

                    var messageBoxAnswer = MessageBox.Show("Are you sure you would like to delete this assignment?", "Delete Assignment", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (messageBoxAnswer == DialogResult.Yes)
                    {
                        var assignments = context.AssignedStakeholders
                        .Where(p => p.StakeholderID_FK == selectedItem).ToList();

                        foreach (var assignment in assignments)
                        {
                            context.Remove(assignment);
                        }
                        context.SaveChanges();
                    }

                    var delStakeholder = context.Stakeholders
                    .Where(p => p.StakeholderID == selectedItem).ToList();
                    context.Remove(delStakeholder.First());
                    context.SaveChanges();
                }
                ReadAndSearch("");
            }

        }
    }
}
