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
    public partial class View_Orders : Form
    {
        static FileHandler fh = new FileHandler();
        List<Client> users = fh.Read();
        public View_Orders()
        {
            InitializeComponent();
        }

        private void dgViewCakes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void View_Orders_Load(object sender, EventArgs e)
        {
            List<Client> clients = new List<Client>();
            dgViewCakes.DataSource = users;
            foreach (var item in users)
            {
                if (item.Date.Month == DateTime.Now.Month)
                {
                    clients.Add(item);
                }
            }
            dgviewCurrent.DataSource = clients;

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Order fm = new Order();
            this.Hide();
            fm.Show();
        }
    }
}
