using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
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
    /// Логика взаимодействия для LoginUser.xaml
    /// </summary>
    public partial class LoginUser : Window
    {
        

        private void Window_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        public LoginUser()
        {
            
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string NewName = NameUser.Text;
            string NewFemale = FemaleUser.Text;           
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
                MessageBox.Show("Этот логин уже занят.");
            }  //Проверка на наличие уже существующего пользователя.

            if (Login.Text == "" || Pass.Text == "" || NameUser.Text == "" || FemaleUser.Text == "")
            {
                MessageBox.Show("Поля 'Имя','Фамилия','Логин','Пароль' обязательны к заполнению!");
            }  //Проверка на заполнение полей

            if ((user == null) && (Login.Text != "" && Pass.Text != "" && NameUser.Text != "" && FemaleUser.Text != ""))
            {
                user = new TbUser();
                user.Имя = NewName;
                user.Фамилия = NewFemale;
                user.Логин = NewLogin;
                user.Пароль = NewPass;
                
                
                db.TbUser.Add(user);
                db.SaveChanges();
                MessageBox.Show("Регистрация завершена успешно.");
                Close();

                Registr registr = new Registr();
                registr.Show();





            } //Добавление нового пользователя в БД.

        }


    }
}
