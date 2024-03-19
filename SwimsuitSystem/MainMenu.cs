namespace SwimsuitSystem
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            this.Hide();
            addUser.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            this.Hide();
            searchForm.Show();
        }
    }
}
