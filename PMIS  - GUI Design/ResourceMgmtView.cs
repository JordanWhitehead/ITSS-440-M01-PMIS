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
    public partial class ResourceMgmtView : Form
    {
        public int resID;
        public ResourceMgmtView(int resID)
        {
            InitializeComponent();
            this.resID = resID;
            LoadProjectInfo();
        }
        private void LoadProjectInfo()
        {
            using (DataContext context = new DataContext()) //set up data context object for EF
            {
                var resource = context.Resources
                    .FirstOrDefault(p => p.ResourceId == resID); //matches ProjectID (data model) with projectID (from control listView1)
                labelTitle.Text = $"{resource.ResourceId}: {resource.ResourceName}";
                //start text boxes
                textBoxResID.Text = resource.ResourceId.ToString();
                textBoxResName.Text = resource.ResourceName.ToString();
                textBoxResDescr.Text = string.IsNullOrEmpty(resource.ResourceDescription) ? "" : resource.ResourceDescription; //this is a "if-then" shorthand syntax in C#
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //enable editing
            if (textBoxResName.ReadOnly == true)
            {
                textBoxResName.ReadOnly = false;
                textBoxResDescr.ReadOnly = false;

                button2.Enabled = true;
                button1.Enabled = false;
            }
            else if (textBoxResName.ReadOnly == false)
            {
                textBoxResName.ReadOnly = true;
                textBoxResDescr.ReadOnly = true;
            }
            else { MessageBox.Show("An error has occurred!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //save
            using DataContext context = new DataContext();
            {
                var resource = context.Resources
                    .FirstOrDefault(p => p.ResourceId == resID);

                resource.ResourceName = string.IsNullOrEmpty(textBoxResName.Text) ? "name left empty" : textBoxResName.Text;
                resource.ResourceDescription = textBoxResDescr.Text;

                context.SaveChanges();
                button1.Enabled = true;
                button2.Enabled = false;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //delete
            using (DataContext context = new DataContext())
            {
                ResourceData foundResource = context.Resources.Find(resID);
                if (foundResource != null)
                {
                    var messageBoxAnswer = MessageBox.Show($"Are you sure you would like to delete this resource?\nResource Name: {foundResource.ResourceName}", "Delete Resource", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (messageBoxAnswer == DialogResult.Yes)
                    {
                        var assignments = context.AssignedResources
                            .Where(p => p.ResourceID_FK == resID).ToList();

                        foreach (var assignment in assignments)
                        {
                            context.Remove(assignment);
                        }
                        context.SaveChanges();

                        context.Remove(foundResource);
                        context.SaveChanges();
                        this.Close();
                    }
                }
            }
        }
    }
}
