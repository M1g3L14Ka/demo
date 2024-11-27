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
    /// Логика взаимодействия для RequestManagerWindow.xaml
    /// </summary>
    public partial class RequestManagerWindow : Window
    {
        public Request Request { get; set; }
        public RequestManagerWindow( Request request = null)
        {
            InitializeComponent();
            Request = Request ?? new Request();
            DataContext = Request;
        }

        private void SaveRequestBtn_Click(object sender, RoutedEventArgs e)
        {
            Request.DateAdd = DateTime.Now;
            this.DialogResult = true;
            this.Close();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            RequestWindow requestWindow = new RequestWindow();  
            requestWindow.Show();
            this.Close();
        }
    }
}
