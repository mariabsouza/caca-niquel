using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            
            Random rnd = new Random();

            int nmr1, nmr2, nmr3;
            nmr1 = rnd.Next(1,7);
            nmr2 = rnd.Next(1,7);
            nmr3 = rnd.Next(1, 7);

            textBox1.Text = nmr1.ToString();
            textBox2.Text = nmr2.ToString();
            textBox3.Text = nmr3.ToString();

            if (nmr1 == nmr2 && nmr2 == nmr3)
            {
                MessageBox.Show("Parabéns!");
            }

        }
    }
}
