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
    public partial class ViewAssignedStakeholders : Form
    {
        public int projectID;
        public ViewAssignedStakeholders(int projectID)
        {
            InitializeComponent();
            this.projectID = projectID;
            Read();
        }
        public void Read()
        {
            listView1.Items.Clear();

            using (DataContext context = new DataContext())
            {
                var stakeholders = (from Stakeholder_Project_Join in context.AssignedStakeholders
                                    join StakeholderData in context.Stakeholders on Stakeholder_Project_Join.StakeholderID_FK equals StakeholderData.StakeholderID
                                    where Stakeholder_Project_Join.ProjectID_FK == projectID
                                    select StakeholderData
                                ).ToList();
                // var LIST_VARIABLE =
                // (
                //  from JOINTABLE  in context.CONTEXT_CLASS_THAT_HAS_JOIN_TABLE
                //  join TABLE_THAT_HAS_THE_OBJECTS in context.CLASS_THAT_HAS_THE_OBJECTS on JOIN_TABLE.FK_OF_THE_OBJECTS_CLASS equals TABLE_THAT_HAS_THE_OBJECTS.PK
                //  where JOIN_TABLE.OTHER_FK == VARIABLE_OF_OTHER_FK
                //  select TABLE_THAT_HAS_THE_OBJECTS
                // ).ToList(); 

                foreach (var stkhldr in stakeholders)
                {
                    ListViewItem item = new ListViewItem(stkhldr.StakeholderID.ToString());
                    item.SubItems.Add(stkhldr.StakeholderName.ToString());
                    item.SubItems.Add(stkhldr.StakeholderRole.ToString());

                    listView1.Items.Add(item);
                }
            }
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
                        .Where(p => p.ProjectID_FK == projectID && p.StakeholderID_FK == selectedItem).ToList();

                        foreach (var assignment in assignments)
                        {
                            context.Remove(assignment);
                        }
                        context.SaveChanges();
                        this.Close();
                    }
                }
                Read();
            }

        }
    }
}
