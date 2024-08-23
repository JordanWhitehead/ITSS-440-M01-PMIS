using System;
using System.Buffers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMIS____GUI_Design
{
    public partial class ViewAssignedResources : Form
    {
        public List<Resource_Task_Join> DatabaseAssignedResources { get; private set; }
        public int taskID;
        public ViewAssignedResources(int taskID)
        {
            InitializeComponent();
            this.taskID = taskID;
            Read();
        }
        public void Read()
        {
            listView1.Items.Clear();

            using (DataContext context = new DataContext())
            {
                var resources = (from Resource_Task_Join in context.AssignedResources
                                 join ResourceData in context.Resources on Resource_Task_Join.ResourceID_FK equals ResourceData.ResourceId
                                 where Resource_Task_Join.TaskID_FK == taskID
                                 select ResourceData
                                ).ToList();
                // var LIST_VARIABLE = 
                // (
                //  from JOINTABLE  in context.CONTEXT_CLASS_THAT_HAS_JOIN_TABLE
                //  join TABLE_THAT_HAS_THE_OBJECTS in context.CLASS_THAT_HAS_THE_OBJECTS on JOIN_TABLE.FK_OF_THE_OBJECTS_CLASS equals TABLE_THAT_HAS_THE_OBJECTS.PK
                //  where JOIN_TABLE.OTHER_FK == VARIABLE_OF_OTHER_FK
                //  select TABLE_THAT_HAS_THE_OBJECTS
                // ).ToList(); 
                // thank goodness for Reddit.

                foreach (var resource in resources)
                {
                    ListViewItem item = new ListViewItem(resource.ResourceId.ToString());
                    item.SubItems.Add(resource.ResourceName.ToString());
                    item.SubItems.Add(resource.ResourceDescription.ToString());

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

                    var messageBoxAnswer = MessageBox.Show("Are you sure you would like to delete this assignment?", "Delete Project", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (messageBoxAnswer == DialogResult.Yes)
                    {
                        var assignments = context.AssignedResources
                        .Where(p => p.TaskID_FK == taskID && p.ResourceID_FK == selectedItem).ToList();

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
