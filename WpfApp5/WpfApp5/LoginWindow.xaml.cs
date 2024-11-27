using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void logInBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogLogin.Text) || string.IsNullOrWhiteSpace(txtLogPass.Password))
            {
                MessageBox.Show("Вы заполнили не все поля :(");
                return;
            }

            // Проверка для администратора и техника
            if ((txtLogLogin.Text == "admin" && txtLogPass.Password == "123") ||
                (txtLogLogin.Text == "worker" && txtLogPass.Password == "321") ||
                (txtLogLogin.Text == "operator" && txtLogPass.Password == "123"))
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                // Проверка для зарегистрированных пользователей
                var user = RegisterWindow.Users.FirstOrDefault(u => u.Login == txtLogLogin.Text && u.Password == txtLogPass.Password);
                if (user != null)
                {
                    MainUserWindow mainUserWindow = new MainUserWindow();
                    mainUserWindow.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль :(");
                }
            }
        }

        private void goToRegBtn_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerWindow = new RegisterWindow();
            registerWindow.Show();
            this.Close();
        }
    }
}
