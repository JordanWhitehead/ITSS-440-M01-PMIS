namespace PMIS____GUI_Design
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            //send text box to ReadAndSearch fx
            var tb1Value = textBox1.Text.Trim().ToLower();

            SearchProjectsWindow searchProjectsWindow = new SearchProjectsWindow(tb1Value);
            searchProjectsWindow.ShowDialog();
        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            SearchProjectsWindow searchProjectsWindow = new SearchProjectsWindow("");
            searchProjectsWindow.ShowDialog();
        }

        private void CreateProjButton_Click(object sender, EventArgs e)
        {
            NewProjectWindow newProjectWindow = new NewProjectWindow();
            newProjectWindow.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageResourcesWindow manageResourcesWindow = new ManageResourcesWindow();
            manageResourcesWindow.ShowDialog();
        }

        private void buttonStakeholderMgmt_Click(object sender, EventArgs e)
        {
            StakeholderManagement stakeholderManagement = new StakeholderManagement();
            stakeholderManagement.ShowDialog();
        }
    }
}
