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
    public partial class SearchProjectsWindow : Form
    {
        public List<Project> DatabaseProjects { get; private set; } //creates a context for the list of objects of the Project table
        public SearchProjectsWindow(string passedSearchValue)
        {
            InitializeComponent();
            ReadAndSearch(passedSearchValue);
        }
        
        //CRUD functions - <i>...and beyond!</i>
        public void ReadAndSearch(string searchValue)
        {
            listView1.Items.Clear();

            using (DataContext context = new DataContext())
            {
                DatabaseProjects = context.Projects
                    .Where(p => p.ProjectId.ToString().ToLower().Contains(searchValue) ||
                        p.ProjectName.ToLower().Contains(searchValue) ||
                        p.ProjectManager.ToLower().Contains(searchValue))
                    .ToList();
            }

            foreach (var project in DatabaseProjects)
            {
                ListViewItem item = new ListViewItem(project.ProjectId.ToString());
                item.SubItems.Add(project.ProjectName.ToString());
                item.SubItems.Add(project.ProjectManager.ToString());

                listView1.Items.Add(item);
            }
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

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedItem = listView1.SelectedItems[0]; //gets first column from selected row in list view ([0] is first in an array)
                int projectID = int.Parse(selectedItem.Text); //sets the selected item as a variable after parsing to integer

                //open ProjectView and create event handling for when the window is closed
                ProjectView projectView = new ProjectView(projectID);
                projectView.FormClosed += ProjectView_FormClosed;  
                projectView.ShowDialog();
            }
        }

        private void ProjectView_FormClosed(object sender, FormClosedEventArgs e)
        {
            ReadAndSearch("");
        }
    }
}
