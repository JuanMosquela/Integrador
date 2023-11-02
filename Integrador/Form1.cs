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

namespace Integrador
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
           InitializeComponent();
        }   

       

        private void Form1_Load(object sender, EventArgs e)
        {           

        }

       
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();      
            dashboard.Show();         
           
        }

        private void kryptonRichTextBox2_Enter(object sender, EventArgs e)
        {
            if (kryptonRichTextBox2.Text == "Enter your password...")
            {
                kryptonRichTextBox2.Text = "";
            }

        }

        private void kryptonRichTextBox2_Leave(object sender, EventArgs e)
        {
           
            if (kryptonRichTextBox2.Text == "")
            {
                kryptonRichTextBox2.Text = "Enter your password...";
            }

        }
    }
}
