using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Логика взаимодействия для Registr.xaml
    /// </summary>
    public partial class Registr : Window
    {
        private void Window_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
        public Registr()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            {

                string NewLogin = Login.Text;
                string NewPass = Pass.Text;


                LoginUserEntities db = new LoginUserEntities();
                db.TbUser.Load();

                var user = db.TbUser
                    .Where(u => u.Логин == NewLogin)
                    .FirstOrDefault();
                //Загрузка данных из БД

                if (user != null)
                {
                    UserWindow window = new UserWindow();
                    window.Show();
                }  

                
            }
        }
    }
}
