using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Integrador.Controls;

namespace Integrador
{
    public partial class Dashboard : KryptonForm
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form1 = Application.OpenForms["Form1"] as Form1;
            if (form1 != null)
            {
                form1.Close();
            }
        }
        private void addUserControl(UserControl userControl)
        {
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
      
            userControl.BringToFront();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            UC_Dashboard dashboard = new UC_Dashboard();
            addUserControl(dashboard);         

        }  

       

       

       

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            UC_Dashboard dashboard = new UC_Dashboard();
            addUserControl(dashboard);

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            UC_Settings settings = new UC_Settings();
            addUserControl(settings);
        }

        private void btnClients_Click(object sender, EventArgs e)
        {

            UC_Clients clients = new UC_Clients();
            addUserControl(clients);

        }

        private void btnIncomes_Click(object sender, EventArgs e)
        {
            UC_Incomes incomes = new UC_Incomes();
            addUserControl(incomes);

        }
    }
}
