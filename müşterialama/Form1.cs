using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace müşterialama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            bool dulum = false;
            string ad = textBox1.Text;
            do
            {
                if (listBox1.Items[i].ToString() == ad)
                {
                    MessageBox.Show(ad + " adlı müşteri bulundu!");
                    dulum = true;
                    break;
                    {
                        i++;
                    } while (i < listBox1.Items.Count) ;
                    if (dulum == false)
                    {
                        MessageBox.Show(ad, "adlı müşteri bulunamadı");
                    }
                }
            }
            }
    }
}


