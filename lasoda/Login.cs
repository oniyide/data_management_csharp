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
using System.Configuration;
namespace lasoda
{
    public partial class Login : Form
    {
        string LoginName, LoginPassword;
        public DataTable loginDataTable;
        String ConString;
        Int16 Ctr;
        public Login()
        {
            InitializeComponent();
            ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            loginDataTable = new DataTable();
            LoginName = tbUsername.Text;
            LoginPassword = tbPassword.Text;
            string query = "select count(*) from [User] where username = '" + LoginName +"' and password = '" + LoginPassword +"'";

            string query2 = "select * from [User] where username = '" + LoginName + "' and password = '" + LoginPassword + "'";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConString);
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            Ctr++;
            sda.Fill(dt);
            con.Close();
            
           
            if (dt.Rows[0][0].ToString() == "1")
            {
                sda = new SqlDataAdapter(query2, con);
                sda.Fill(loginDataTable);
                var Lasodamanage = new Lasodamanage(loginDataTable);
                Lasodamanage.Show();
                this.Hide();
                con.Close();
            }
            if(Ctr < 3)
            {
                lMessage.Visible = true;
                lMessage.Text = "Incorrect username or password. Please try Again!";
                tbUsername.Focus();
                
            }
            else
            {
                MessageBox.Show("THis is an unauthorized Access. Aborting");
                Close();
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
