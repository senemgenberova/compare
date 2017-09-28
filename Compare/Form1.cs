using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            nameLableandButtons();
        }

        private void nameLableandButtons() {
            Random r = new Random();
            this.button1.Text = r.Next(0, 100).ToString();
            this.button2.Text = r.Next(0, 100).ToString();
        }

        private void compareFunction(Button b1 , Button b2) {

            if (Convert.ToInt64(b1.Text) > Convert.ToInt64(b2.Text))
            {
                MessageBox.Show("bu button Boyukdur");
            }
            else if (Convert.ToInt64(b1.Text) == Convert.ToInt64(b2.Text))
            {
                MessageBox.Show("bu buttonlar beraberdir");
            }
            else
            {
                MessageBox.Show("bu button Kicikdir");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.compareFunction(this.button1, this.button2);

        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            this.compareFunction(this.button2, this.button1);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            nameLableandButtons();
        }
    }
}
