using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
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
    /// Логика взаимодействия для RequestWindow.xaml
    /// </summary>
    public partial class RequestWindow : Window
    {
        public ObservableCollection<Request> Requests { get; set; } = new ObservableCollection<Request>();
        public Request Request { get; set; }

        public RequestWindow()
        {
            InitializeComponent();
            newRequest.ItemsSource = Requests;
        }

        public RequestWindow(Request request) : this()
        {
            Request = request;
        }

        private void addNewRequestBtn_Click(object sender, RoutedEventArgs e)
        {
            var requestManagerWindow = new RequestManagerWindow();
            requestManagerWindow.ShowDialog();
            if (requestManagerWindow.Request != null)
            {
                Requests.Add(requestManagerWindow.Request);
            }
        }

        private void editRequestBtn_Click(object sender, RoutedEventArgs e)
        {
            if (newRequest.SelectedItem is Request selectedRequest)
            {
                var requestWindow = new RequestWindow(selectedRequest);
                requestWindow.ShowDialog();
                if (requestWindow.Request != null)
                {
                    int index = Requests.IndexOf(selectedRequest);
                    Requests[index] = requestWindow.Request;
                }
            }
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            MainUserWindow mainUserWindow = new MainUserWindow();
            mainUserWindow.Show();
            this.Close();
        }
    }
}