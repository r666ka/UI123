using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UI3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-VH9GA09\SQLEXPRESS; Initial Catalog=LoginAdmin; Integrated Security=True");
            try
            {
                if (sqlCon.State == System.Data.ConnectionState.Closed)
                    sqlCon.Open();
                String query = "SELECT COUNT(1) FROM TbAdmin WHERE AdminName=@AdminName AND Password=@Passowrd";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon)
                {
                    CommandType = System.Data.CommandType.Text
                };
                sqlCmd.Parameters.AddWithValue("@AdminName", User.Text);
                sqlCmd.Parameters.AddWithValue("@Passowrd", Pass.Password);
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                if (count == 1)
                {
                    WindowAdmin dashboard = new WindowAdmin();
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("AdminName or Passoword не верно.");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }



        }

    }
}
