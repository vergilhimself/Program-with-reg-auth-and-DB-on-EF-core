namespace lab4WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            using (var db = new ProductContext())
            {
                var usersearch = db.Users.FirstOrDefault(u => u.Username == UsernameTextBox.Text && u.Password == PasswordTextBox.Text);
                if (usersearch != null)
                {
                    MessageBox.Show("Пользователь существует");
                }
                else
                {
                    var user = new User { Username = UsernameTextBox.Text, Password = PasswordTextBox.Text, Role = "user" };
                    db.Users.Add(user);
                    db.SaveChanges();
                    MessageBox.Show("Вы зарегестрированы!");
                }

            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            using (var db = new ProductContext())
            {
                var user = db.Users.FirstOrDefault(u => u.Username == UsernameTextBox.Text && u.Password == PasswordTextBox.Text);
                if (user != null)
                {
                    MessageBox.Show("Успешный вход в систему!");
                    if (user.Role == "admin")
                    {
                        AdminWindow userWindow = new AdminWindow();
                        userWindow.Show();
                        this.Hide();
                    }
                    if (user.Role == "user")
                    {
                        UserWindow userWindow = new UserWindow();
                        userWindow.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Неверное имя пользователя или пароль.");
                }
            }
        }
    }
}
