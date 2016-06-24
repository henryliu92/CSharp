using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDatabase1
{
    public partial class Form1 : Form
    {
        List<HCustomer> listofCustomers = new List<HCustomer>();
        int customerListIndex = 0;
        
        public Form1()
        {
            InitializeComponent();
            buttonAdd.Enabled = false;
            buttonNext.Enabled = false;
            buttonPrevious.Enabled = false;
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            using (ClientsEntities myEntities = new ClientsEntities())
            {
                var Customer = from c in myEntities.HCustomers
                               select c;
                listofCustomers = Customer.ToList();
            }
            DisplayCustomer(customerListIndex);
            buttonAdd.Enabled = true;
            buttonNext.Enabled = true;
            buttonPrevious.Enabled = true;
        }

        private void DisplayCustomer(int customerID)
        {
            if (listofCustomers[customerID] != null)
            {
                textBoxName.Text = listofCustomers[customerID].name;
                textBoxAddress.Text = listofCustomers[customerID].address;
                textBoxPostcode.Text = listofCustomers[customerID].Postcode;
                textBoxPhoneNo.Text = listofCustomers[customerID].PhoneNo;
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            customerListIndex++;

            if (customerListIndex >= listofCustomers.Count)
            {
                customerListIndex = 0;
            }
            DisplayCustomer(customerListIndex);
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            customerListIndex--;

            if (customerListIndex <0)
            {
                customerListIndex = listofCustomers.Count - 1;
            }
            DisplayCustomer(customerListIndex);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (ClientsEntities myEntities = new ClientsEntities())
            {
                HCustomer newCustomer = new HCustomer();

                newCustomer.name = textBoxName.Text;
                newCustomer.address = textBoxAddress.Text;
                newCustomer.Postcode = textBoxPostcode.Text;
                newCustomer.PhoneNo = textBoxPhoneNo.Text;

                myEntities.HCustomers.Add(newCustomer);
                myEntities.SaveChanges();
            }
        }
    }
}
