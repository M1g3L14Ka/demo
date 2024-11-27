using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public static List<User> Users = new List<User>();

        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void RegInBtn_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(txtRegLogin.Text) && !string.IsNullOrEmpty(txtRegPass.Password))
            {
                if(Users.Any(u => u.Login == txtRegLogin.Text))
                {
                    MessageBox.Show("Пользователь с таким логином уже существует :(");
                }
                else
                {
                    Users.Add(new User(txtRegLogin.Text, txtRegPass.Password));
                    LoginWindow loginwindow = new LoginWindow();
                    loginwindow.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Вы заполнили не все поля :(");
            }
        }

        private void goToLogBtn_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginwindow = new LoginWindow();
            loginwindow.Show();
            this.Close();
        }
    }
}