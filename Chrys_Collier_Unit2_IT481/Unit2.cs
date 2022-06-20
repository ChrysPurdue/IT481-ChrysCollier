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

namespace Chrys_Collier_Unit2_IT481
{
    public partial class Unit2 : Form
    {
        public Unit2()
        {
            InitializeComponent();
        }
        private void btnGetCustomers_Click(object sender, EventArgs e)
        {
            var count = 0;
            foreach(String name in GetCustomers())
            {
                count += 1;
                Label customerName = new Label();
                customerName.Text = name;
                customerName.Height = 50;
                flpCustomers.Controls.Add(customerName);
            }
            lblCustomerCount.Text = "Results: "+count.ToString();
            lblCustomerCount.Visible = true;
            lblCustomerCount.Refresh();
        }
        private List<String> GetCustomers()
        {
            List<String> customers = new List<String>();
            SqlConnection c;
            c = CreateConnection();
            string SelectCustomers =
                "SELECT ContactName FROM Customers";
            using (c)
            {
                SqlCommand cmd = new SqlCommand(SelectCustomers, c);
                SqlDataReader r = cmd.ExecuteReader();
                if(r.HasRows)
                {
                    while(r.Read())
                    {
                        string name = r.GetString(0);
                        customers.Add(name);
                    }
                }
            }
            return customers;
        }
        private SqlConnection CreateConnection()
        {
            SqlConnection c;
            c = new SqlConnection("Data Source=DESKTOP-V2VF2CL;Initial Catalog=Northwind;Integrated Security=True");
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
