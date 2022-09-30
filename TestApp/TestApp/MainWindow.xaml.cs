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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<User> listUsers = new List<User>()
            {
                new User(1, "Name1", new DateTime(1990, 10, 15), "Address1"),
                new User(2, "Name2", new DateTime(1990, 2, 25), "Address2"),
                new User(3, "Name3", new DateTime(1990, 5, 9), "Address3"),
                new User(4, "Name4", new DateTime(1990, 12, 25), "Address4")
            };

            DataContext = listUsers;
        }
    }
}
