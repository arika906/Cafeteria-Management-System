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
using System.Data.SqlClient;

namespace Cafeteria_Sample
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BVV843R;Initial Catalog=LoginDB;Integrated Security=True");
            try
            {
                if(conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();
                String query = "SELECT COUNT(1) FROM User_Table WHERE User_Name=@User_Name AND Password=@Password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@User_Name", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Password);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if(count == 1)
                {
                    MainWindow Dashboard = new MainWindow();
                    Dashboard.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("User Name or Password is incorrect.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
