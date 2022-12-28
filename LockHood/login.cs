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
        databaseClass objdb = new databaseClass();
        
        public static String email = "";

        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            objdb.createConn();

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
                //sql query saved in a string
                string query = "SELECT * FROM login WHERE Email ='" + mail + "' AND Password='" + pass + "'";

                //use sqlreader to check if user is valid and save it in variable
                var reader = objdb.readDatathroughReader(query);
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        usertype = reader.GetValue(3).ToString();

                        if (usertype == "head")
                        {
                            email = txtPass.Text;
                            frmHeadHome headHome = new frmHeadHome();
                            headHome.Show();

                            this.Hide();
                        }
                        else if (usertype == "supervisor")
                        {
                            email = txtPass.Text;
                            frmSupHome superHome = new frmSupHome();
                            superHome.Show();

                            this.Hide();
                        }
                        else
                        {
                            email = txtPass.Text;
                            frmManHome manHome = new frmManHome();
                            manHome.Show();

                            this.Hide();
                        }
                    }
                    //MessageBox.Show("Admin Loggin Successfull");
                    reader.Close();
                    objdb.closeConn();
                


                }
                else
                {
                    reader.Close();
                    objdb.closeConn();
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
