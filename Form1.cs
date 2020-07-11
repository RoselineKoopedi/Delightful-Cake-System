using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelightFul_Cake
{
    public partial class Form1 : Form
    {
        static FileHandler fh = new FileHandler();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string contact = txtContact.Text;
            string cake_Name = cmbCakeName.Text;
            string description = txtDescription.Text;
            string coke_Name = cmbDrink.Text;
            DateTime date = DateTime.Parse(timeCakes.Text);
            double total = 0;
            if(cmbDrink.Text =="Fanta")
            {
                total = total + 20;
            }
            if (cmbDrink.Text == "Coke")
            {
                total = total + 20;
            }
            if (cmbDrink.Text == "Water")
            {
                total = total + 30;
            }
            if (cmbDrink.Text == "Juice")
            {
                total = total + 45;
            }
            if (cmbSizz.Text == "Small")
            {
                total =total+ 200 ;
                lsbCakes.Items.Clear();
                fh.Write(name, surname, contact, cake_Name, 200, description, coke_Name, date);
                lsbCakes.Items.Add("Name : " + name);
                lsbCakes.Items.Add("Surname : " + surname);
                lsbCakes.Items.Add("Contact : " + contact);
                lsbCakes.Items.Add("Cake Name: " + cake_Name);
                lsbCakes.Items.Add("Price : 200");
                lsbCakes.Items.Add("Description : " + description);
                lsbCakes.Items.Add("Size : " + cmbSizz.Text);
                lsbCakes.Items.Add("Drink Name : " + coke_Name);
                lsbCakes.Items.Add("Date : " + date);
                lsbCakes.Items.Add("Total : " + total);
            }
            else if (cmbSizz.Text == "Medium")
            {
                total = total+250 ;
                lsbCakes.Items.Clear();
                fh.Write(name, surname, contact, cake_Name, 250, description, coke_Name, date);
                lsbCakes.Items.Add("Name : " + name);
                lsbCakes.Items.Add("Surname : " + surname);
                lsbCakes.Items.Add("Contact : " + contact);
                lsbCakes.Items.Add("Cake Name: " + cake_Name);
                lsbCakes.Items.Add("Price : 250");
                lsbCakes.Items.Add("Description : " + description);
                lsbCakes.Items.Add("Size : " + cmbSizz.Text);
                lsbCakes.Items.Add("Drink Name : " + coke_Name);
                lsbCakes.Items.Add("Date : " + date);
                lsbCakes.Items.Add("Total : " + total);
            }
            else if (cmbSizz.Text == "Large") 
            {
                total = total+ 300 ;
                lsbCakes.Items.Clear();
                fh.Write(name, surname, contact, cake_Name, 300, description, coke_Name, date);
                lsbCakes.Items.Add("Name : " + name);
                lsbCakes.Items.Add("Surname : " + surname);
                lsbCakes.Items.Add("Contact : " + contact);
                lsbCakes.Items.Add("Cake Name: " + cake_Name);
                lsbCakes.Items.Add("Price : 300");
                lsbCakes.Items.Add("Description : " + description);
                lsbCakes.Items.Add("Size : " + cmbSizz.Text);
                lsbCakes.Items.Add("Drink Name : " + coke_Name);
                lsbCakes.Items.Add("Date : " + date);
                lsbCakes.Items.Add("Total : " + total);
            }
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            View_Orders view = new View_Orders();
            this.Hide();
            view.Show();
        }
    }
}
