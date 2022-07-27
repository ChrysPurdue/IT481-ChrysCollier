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

namespace Chrys_Collier_IT481
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtServer.Text) || String.IsNullOrEmpty(txtDatabase.Text) || String.IsNullOrEmpty(txtUser.Text) || String.IsNullOrEmpty(txtPassword.Text))
            {
                lblError.Text = "Please complete all fields.";
                lblError.Refresh();
                lblError.Visible = true;
            }
            else if (txtPassword.Text.Length < 8) {
                lblError.Text = "Password length must be 8 characters or more.";
                lblError.Refresh();
                lblError.Visible = true;
            }
            else
            {
                lblError.Visible = false;
                AuthorizedPage authorized = new AuthorizedPage(txtServer.Text, txtDatabase.Text, txtUser.Text, txtPassword.Text);
                authorized.FormClosed += new FormClosedEventHandler(authorizedPage_FormClosed);
                this.Hide();
                authorized.Show();
            }
        }
        void authorizedPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private SqlConnection CreateConnection(string server, string database, string user, string pass)
        {
            SqlConnection c;
            c = new SqlConnection("Server=" + server + ";Data Source="+server+";Initial Catalog="+database+";Integrated Security=True;User ID="+user+";Password="+pass);
            try
            {
                c.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return c;
        }
    }
}
