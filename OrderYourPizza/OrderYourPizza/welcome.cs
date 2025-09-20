using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderYourPizza
{
    public partial class welcome: Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain form = new FrmMain();
            form.ShowDialog();
          
        }

        private void welcome_Load(object sender, EventArgs e)
        {
            
        }
    }
}
