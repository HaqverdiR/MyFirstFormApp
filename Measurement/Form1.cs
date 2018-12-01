using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Measurement
{
    public partial class Form1 : Form
    {
        TextBox lastOne = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            
            if (lastOne.Name == "txt_cm")
            {
                txt_dm.Text = (decimal.Parse(lastOne.Text) / 10).ToString();
                txt_m.Text = (decimal.Parse(lastOne.Text) / 100).ToString();
            }
            else if (lastOne.Name == "txt_dm")
            {
                txt_cm.Text = (decimal.Parse(lastOne.Text) * 10).ToString();
                txt_m.Text = (decimal.Parse(lastOne.Text) / 10).ToString();
            }
           else
            {
                txt_cm.Text = (decimal.Parse(lastOne.Text) * 100).ToString();
                txt_dm.Text = (decimal.Parse(lastOne.Text) * 10).ToString();
            }
        }        

        private void textBox_KeyUp(object sender, KeyEventArgs e)
        {
            lastOne = (TextBox)sender;
            var data = this.Controls.OfType<TextBox>().Where(w => w.Name != lastOne.Name).ToList();
            foreach (TextBox txt in data)
            {
                txt.Text = "";
            }
        }


    }
}
