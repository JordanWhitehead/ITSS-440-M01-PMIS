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
    public partial class NewStakeholder : Form
    {
        public NewStakeholder()
        {
            InitializeComponent();
        }
        private void Create()
        {
            using (DataContext context = new DataContext())
            {
                var stakeholderName = textBox1.Text.Trim();
                var stakeholderTitle = textBox2.Text.Trim();
                var stakeholderRole = textBox3.Text.Trim();
                var stakeholderDescription = textBox4.Text.Trim();

                if (string.IsNullOrEmpty(stakeholderName)) //conditionals - input validation
                {
                    MessageBox.Show("\"Stakeholder Name\" is required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                context.Stakeholders.Add(new StakeholderData //sets a function to add the text box values to Project data context
                {
                    StakeholderName = stakeholderName,
                    StakeholderTitle = stakeholderTitle,
                    StakeholderRole = stakeholderRole,
                    StakeholderDescription = stakeholderDescription
                });

                //try-catch to add project to database
                try
                {
                    context.SaveChanges();
                    MessageBox.Show($"Stakeholder created successfully!\n{stakeholderName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while writing the task to the database file.\nPlease try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Create();
        }
    }
}
