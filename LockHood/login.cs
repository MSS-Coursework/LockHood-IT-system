using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LockHood
{
    public partial class login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N7LQHOM;Initial Catalog=LockHood;Integrated Security=True");
        public static String email = "";

        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            lblError.Text = "";
            lblEmailError.Text = "";
            lblPassError.Text = "";

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            // Read Form Value
            String mail = txtEmail.Text;
            String pass = txtPass.Text;
            String usertype = "";

            // Empty Error Labels
            lblError.Text = "";
            lblEmailError.Text = "";
            lblPassError.Text = "";

            // Validations
            if (mail == "")
            {
                lblEmailError.Text = "This field is required !";

            }

            if (pass == "")
            {
                lblPassError.Text = "This field is required !";
            }

            else
            {

                SqlCommand Com = new SqlCommand("select * from login where Email='" + mail + "' and Password ='" + pass + "'", con);
                SqlDataReader DR1 = Com.ExecuteReader();
                if (DR1.Read())
                {
                    usertype = DR1.GetValue(3).ToString();

                    if (usertype == "head")
                    {
                        email = txtPass.Text;
                        frmHeadHome headHome = new frmHeadHome();
                        headHome.Show();
                    }
                    else if (usertype == "supervisor")
                    {
                        email = txtPass.Text;
                        frmSupHome superHome = new frmSupHome();
                        superHome.Show();
                    }
                    else
                    {
                        email = txtPass.Text;
                        frmManHome manHome = new frmManHome();
                        manHome.Show();
                    }
                }

                else
                {
                    lblError.Text = "Invalid Username or Password !";
                    txtPass.Text = "";
                    txtEmail.Text = "";
                }
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
