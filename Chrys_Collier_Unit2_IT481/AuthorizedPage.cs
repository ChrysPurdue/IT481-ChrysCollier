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
    public partial class AuthorizedPage : Form
    {
        string conn;
        public AuthorizedPage(string server, string database, string user, string pass)
        {
            InitializeComponent();
            conn = "Server=" + server +
                ";Database=" + database +
                ";User Id=" + user +
                ";Password=" + pass +
                ";Integrated Security=False;Persist Security Info=True";
        }
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            flpResults.Controls.Clear();
            var count = 0;
            foreach (String name in GetCustomers())
            {
                count += 1;
                Label customerName = new Label();
                customerName.Text = name;
                customerName.Height = 50;
                flpResults.Controls.Add(customerName);
            }
            lblCount.Text = "Results: " + count.ToString();
            lblCount.Visible = true;
            lblCount.Refresh();
        }
        private List<String> GetCustomers()
        {
            List<String> customers = new List<String>();
            SqlConnection c;
            c = CreateConnection();
            string selectCustomers =
                "SELECT ContactName FROM Customers";
            using (c)
            {
                SqlCommand cmd = new SqlCommand(selectCustomers, c);
                try
                {
                    SqlDataReader r = cmd.ExecuteReader();
                    if (r.HasRows)
                    {
                        while (r.Read())
                        {
                            string name = r.GetString(0);
                            customers.Add(name);
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Permission Denied");
                }
            }
            return customers;
        }
        private void btnEmployees_Click(object sender, EventArgs e)
        {
            flpResults.Controls.Clear();
            var count = 0;
            foreach(String name in GetEmployees())
            {
                count += 1;
                Label employeeName = new Label();
                employeeName.Text = name;
                employeeName.Height = 50;
                flpResults.Controls.Add(employeeName);
            }
            lblCount.Text = "Results: "+count.ToString();
            lblCount.Visible = true;
            lblCount.Refresh();
        }
        private List<String> GetEmployees()
        {
            List<String> employees = new List<String>();
            SqlConnection c;
            c = CreateConnection();
            string selectEmployees =
                "SELECT FirstName, LastName FROM Employees";
            using (c)
            {
                SqlCommand cmd = new SqlCommand(selectEmployees, c);

                try
                {
                    SqlDataReader r = cmd.ExecuteReader();
                    if (r.HasRows)
                    {
                        while (r.Read())
                        {
                            string firstName = r.GetString(0);
                            string lastName = r.GetString(0);
                            employees.Add(firstName + ' ' + lastName);
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Permission Denied");
                }
            }
            return employees;
        }
        private void btnOrders_Click(object sender, EventArgs e)
        {
            flpResults.Controls.Clear();
            var count = 0;
            foreach (String order in GetOrders())
            {
                count += 1;
                Label orders = new Label();
                orders.Text = order;
                orders.Height = 50;
                flpResults.Controls.Add(orders);
            }
            lblCount.Text = "Results: " + count.ToString();
            lblCount.Visible = true;
            lblCount.Refresh();
        }
        private List<String> GetOrders()
        {
            List<String> orders = new List<String>();
            SqlConnection c;
            c = CreateConnection();
            string selectOrders =
                "SELECT OrderID,OrderDate FROM Orders";
            using (c)
            {
                SqlCommand cmd = new SqlCommand(selectOrders, c);
                try
                {
                    SqlDataReader r = cmd.ExecuteReader();
                    if (r.HasRows)
                    {
                        while (r.Read())
                        {
                            int orderId = r.GetInt32(0);
                            DateTime orderDate = Convert.ToDateTime(r["OrderDate"]);
                            orders.Add("Order " + orderId + " placed " + orderDate);
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Permission Denied");
                }
            }
            return orders;
        }
        private SqlConnection CreateConnection()
        {
            SqlConnection c = new SqlConnection(@conn);
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
