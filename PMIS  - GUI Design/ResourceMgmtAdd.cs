using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PMIS____GUI_Design
{
    public partial class ResourceMgmtAdd : Form
    {
        public ResourceMgmtAdd()
        {
            InitializeComponent();
        }

        private void Create()
        {
            using (DataContext context = new DataContext())
            {
                var resName = textBox1.Text.Trim();
                var resDescription = textBox2.Text.Trim();

                if (string.IsNullOrEmpty(resName)) //conditionals - input validation
                {
                    MessageBox.Show("\"Resource Name\" is required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(resDescription)) //conditionals - input validation
                {
                    MessageBox.Show("\"Resource Description\" is required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                context.Resources.Add(new ResourceData //sets a function to add the text box values to Project data context
                {
                    ResourceName = resName,
                    ResourceDescription = resDescription
                });

                //try-catch to add project to database
                try
                {
                    context.SaveChanges();
                    MessageBox.Show($"Resource created successfully!\n{resName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while writing the task to the database file.\nPlease try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Create();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
