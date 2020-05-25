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

namespace UI3
{
    /// <summary>
    /// Логика взаимодействия для AdminOrUser.xaml
    /// </summary>
    public partial class AdminOrUser : Window
    {
        public AdminOrUser()
        {
            InitializeComponent();
        }

        private void Button_admin_Click(object sender, RoutedEventArgs e)
        {
            MainWindow wd = new MainWindow();
            wd.Show();

        }

        private void Button_user_Click(object sender, RoutedEventArgs e)
        {
            LoginUser loginUser = new LoginUser();
                loginUser.Show();

        }


        private void button_login_Click(object sender, RoutedEventArgs e)
        {
            Registr window = new Registr();
            window.Show();
        }
    }
}
