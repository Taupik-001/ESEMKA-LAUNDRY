namespace Test
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }
        private EsemkaContext context = new EsemkaContext();
        public static string? recby { get; set; }
        public static int IdEmployee { get; set; }
        public static string logout
        {
            get { recby = null; return string.Empty; }
            set { recby = null; }
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var employee = context.Employees?.FirstOrDefault(emp => emp.Email == input_username.Text && emp.Password == input_password.Text);

            if (employee != null)
            {
                if (employee.Name?.ToString() != "Admin")
                {
                    recby = employee.Name;
                    IdEmployee = employee.Id;
                    this.Hide();
                    Main_Form main = new Main_Form();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Hahaha anda hanyalah Member");
                }
            }
            else
            {
                MessageBox.Show("Please Try Again, Your Data is not Valid!");
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            input_username.Clear();
            input_password.Clear();
        }
    }
}
