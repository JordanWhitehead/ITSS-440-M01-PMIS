using System;
using System.Buffers;
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
    public partial class ProjectView : Form
    {
        public int projectID;
        public bool textBoxChange = false;
        //public SearchProjectsWindow searchProjectsWindow;
        public ProjectView(int projectID)
        {
            InitializeComponent();
            this.projectID = projectID;
            LoadProjectInfo();
        }

        private void LoadProjectInfo()
        {
            using (DataContext context = new DataContext()) //set up data context object for EF
            {
                var project = context.Projects
                    .FirstOrDefault(p => p.ProjectId == projectID); //matches ProjectID (data model) with projectID (from control listView1)
                labelTitle.Text = $"{project.ProjectId}: {project.ProjectName}";
                //start text boxes
                textBoxProjID.Text = project.ProjectId.ToString();
                textBoxProjName.Text = project.ProjectName.ToString();
                textBoxProjDescr.Text = string.IsNullOrEmpty(project.ProjectDescr) ? "" : project.ProjectDescr; //this is a "if-then" shorthand syntax in C#
                textBoxProjInitiative.Text = string.IsNullOrEmpty(project.ProjectInitiative) ? "" : project.ProjectInitiative;
                textBoxProjManager.Text = string.IsNullOrEmpty(project.ProjectManager) ? "" : project.ProjectManager;
                textBoxProjStart.Text = string.IsNullOrEmpty(project.ProjectStart) ? "" : project.ProjectStart;
                textBoxProjEnd.Text = string.IsNullOrEmpty(project.ProjectEnd) ? "" : project.ProjectEnd;
                textBoxProjRevEnd.Text = string.IsNullOrEmpty(project.ProjectRevEnd) ? "" : project.ProjectRevEnd;
                numericUpDown1.Value = (decimal)project.ProjectCompletion;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TaskListView taskListView = new TaskListView(projectID);
            taskListView.ShowDialog();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            //enable editing
            textBoxProjName.ReadOnly = false;
            textBoxProjDescr.ReadOnly = false;
            textBoxProjInitiative.ReadOnly = false;
            textBoxProjManager.ReadOnly = false;
            textBoxProjStart.ReadOnly = false;
            textBoxProjEnd.ReadOnly = false;
            textBoxProjRevEnd.ReadOnly = false;
            numericUpDown1.ReadOnly = false;

            button2.Enabled = false;
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //save update pt 2
            using DataContext context = new DataContext();
            {
                var project = context.Projects
                    .FirstOrDefault(p => p.ProjectId == projectID);

                project.ProjectName = string.IsNullOrEmpty(textBoxProjName.Text) ? "name left empty" : textBoxProjName.Text;
                project.ProjectDescr = textBoxProjDescr.Text;
                project.ProjectInitiative = textBoxProjInitiative.Text;
                project.ProjectManager = textBoxProjManager.Text;
                project.ProjectStart = textBoxProjStart.Text;
                project.ProjectEnd = textBoxProjEnd.Text;
                project.ProjectRevEnd = textBoxProjRevEnd.Text;
                project.ProjectCompletion = numericUpDown1.Value;

                context.SaveChanges();

                textBoxProjName.ReadOnly = true;
                textBoxProjDescr.ReadOnly = true;
                textBoxProjInitiative.ReadOnly = true;
                textBoxProjManager.ReadOnly = true;
                textBoxProjStart.ReadOnly = true;
                textBoxProjEnd.ReadOnly = true;
                textBoxProjRevEnd.ReadOnly = true;
                numericUpDown1.ReadOnly = true;

                button2.Enabled = true;
                button3.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //delete
            using (DataContext context = new DataContext())
            {
                Project foundProject = context.Projects.Find(projectID);
                if (foundProject != null)
                {
                    var messageBoxAnswer = MessageBox.Show($"Are you sure you would like to delete this project?\nDoing so will delete all tasks, resource assignments, stakeholder assignments, requirements, and milestones.\nProject Name: {foundProject.ProjectName}", "Delete Project", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (messageBoxAnswer == DialogResult.Yes)
                    {
                        //get tasks in list of objects
                        var tasksMatchProject = context.Tasks
                            .Where(p => p.Task_ProjectId_FK == projectID).ToList();

                        //resource assignments to tasks
                        //need list of tasks first
                        var taskIds = tasksMatchProject.Select(p => p.TaskId).ToList();
                        var assignmentsMatchTask = context.AssignedResources
                            .Where(p => taskIds.Contains(p.TaskID_FK)).ToList();

                        //delete tasks and resource assignments
                        foreach (var task in tasksMatchProject)
                        {
                            context.Remove(task);
                        }
                        foreach (var resAssignment in assignmentsMatchTask)
                        {
                            context.Remove(resAssignment);
                        }

                        //stakeholder assignments to project
                        var assignmentsMatchProject = context.AssignedStakeholders
                            .Where(p => p.ProjectID_FK == projectID).ToList();
                        foreach (var stkhldrAssignment in assignmentsMatchProject)
                        {
                            context.Remove(stkhldrAssignment);
                        }

                        //requirements
                        var requirementsMatchProject = context.Requirements
                            .Where(p => p.Requirement_ProjectId_FK == projectID).ToList();
                        foreach (var req in requirementsMatchProject)
                        {
                            context.Remove(req);
                        }

                        //milestones
                        var milestonesMatchProject = context.Milestones
                            .Where(p => p.Milestone_ProjectId_FK == projectID).ToList();
                        foreach (var ms in milestonesMatchProject)
                        {
                            context.Remove(ms);
                        }

                        //project itself
                        context.Remove(foundProject);
                        context.SaveChanges();
                        this.Close();
                    }
                }
            }
        }

        public void button5_Click(object sender, EventArgs e)
        {
            AssignStakeholderToProject assignStakeholderToProject = new AssignStakeholderToProject(projectID);
            assignStakeholderToProject.ShowDialog();
        }

        public void button6_Click(object sender, EventArgs e)
        {
            ViewAssignedStakeholders viewAssignedStakeholders = new ViewAssignedStakeholders(projectID);
            viewAssignedStakeholders.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MilestoneList milestoneList = new MilestoneList(projectID);
            milestoneList.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RequirementList requirementList = new RequirementList(projectID);
            requirementList.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ProjectCharter projectCharter = new ProjectCharter(projectID);
            projectCharter.WritePDF();
        }
    }
}