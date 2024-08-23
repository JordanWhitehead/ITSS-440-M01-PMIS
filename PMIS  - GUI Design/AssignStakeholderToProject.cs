using System.Data;
using System.Threading.Tasks;

namespace PMIS____GUI_Design
{
    public partial class AssignStakeholderToProject : Form
    {
        public List<StakeholderData> DatabaseStakeholders { get; private set; }
        public int projectID;
        public AssignStakeholderToProject(int projectID)
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
                DatabaseStakeholders = context.Stakeholders
                    .Where(p => p.StakeholderID.ToString().ToLower().Contains(searchValue) ||
                        p.StakeholderName.ToLower().Contains(searchValue) ||
                        p.StakeholderRole.ToLower().Contains(searchValue))
                    .ToList();
            }

            foreach (var stkhldr in DatabaseStakeholders)
            {
                ListViewItem item = new ListViewItem(stkhldr.StakeholderID.ToString());
                item.SubItems.Add(stkhldr.StakeholderName.ToString());
                item.SubItems.Add(stkhldr.StakeholderRole.ToString());

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
                    int stkhldrID = int.Parse(listView1.SelectedItems[0].Text);
                    context.AssignedStakeholders.Add(new Stakeholder_Project_Join
                    {
                        ProjectID_FK = projectID,
                        StakeholderID_FK = stkhldrID
                    });
                    proceedToAdd = true;
                }
                catch (Exception ex) { MessageBox.Show("You must select a stakeholder to add them to the project!", "Stakeholder Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                if (proceedToAdd)
                {
                    try //tries to write to the database
                    {
                        context.SaveChanges();
                        MessageBox.Show("Stakeholder added to project successfully!", "Stakeholder Added", MessageBoxButtons.OK);
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
                        int stkhldrID = int.Parse(listView1.SelectedItems[0].Text);
                        context.AssignedStakeholders.Add(new Stakeholder_Project_Join
                        {
                            ProjectID_FK = projectID,
                            StakeholderID_FK = stkhldrID
                        });
                        proceedToAdd = true;
                    }
                    catch (Exception ex) { MessageBox.Show("You must select a stakeholder to add them to the project!", "Stakeholder Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    if (proceedToAdd)
                    {
                        try //tries to write to the database
                        {
                            context.SaveChanges();
                            MessageBox.Show("Stakeholder added to task successfully!", "Stakeholder Added", MessageBoxButtons.OK);
                        }
                        catch { MessageBox.Show("An error occurred while writing to the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewStakeholder newStakeholder = new NewStakeholder();
            newStakeholder.FormClosed += OnReturnToList;
            newStakeholder.ShowDialog();
        }

        private void OnReturnToList(object? sender, FormClosedEventArgs e)
        {
            ReadAndSearch("");
        }
    }
}
