using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace LALASA
{
    public partial class form_LoginPage : Form
    {
        MySqlConnection sqlConnect = new MySqlConnection("server=139.255.11.84;uid=student;pwd=isbmantap;database=SAD_LALASA");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        bool loginSucceeded = false;

        public form_LoginPage()
        {
            InitializeComponent();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                sqlQuery = $"select staff_id from STAFF where staff_id = '{tb_StaffID.Text}' and staff_password = '{tb_Password.Text}';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);

                //sqlConnect.Open();
                //sqlCommand = new MySqlCommand(namaprocedure, sqlConnect);
                //sqlCommand.CommandType = CommandType.StoredProcedure;
                //sqlCommand.Parameters.AddWithValue(namaParameter, isinya);
                //sqlConnect.Close();

                // Tabel
                //sqlAdapter = new MySqlDataAdapter(sqlCommand);

                // Bukan tabel
                //string staffID = (string)sqlCommand.ExecuteScalar(); // return first row
                //sqlCommand.ExecuteNonQuery();



                sqlConnect.Open();
                string staffID = (string)sqlCommand.ExecuteScalar();
                sqlConnect.Close();

                if (staffID == null)
                {
                    MessageBox.Show("Staff ID or Password is incorrect!");
                    tb_Password.Text = String.Empty;
                }
                else
                {
                    loginSucceeded = true;
                    form_Menu menu= new form_Menu(tb_StaffID.Text.ToUpper());
                    menu.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoginPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!loginSucceeded) Application.Exit();
        }
    }
}
