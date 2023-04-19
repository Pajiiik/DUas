using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vyjimky2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0;
            try
            {
                if (int.TryParse(textBox2.Text, out n))
                {
                    n = int.Parse(textBox2.Text);
                }
                int vysledek = 0;
                for (int i = 0; i < n && i < textBox1.Lines.Count(); i++)
                {
                    vysledek += int.Parse(textBox1.Lines[i]);
                }
                label1.Text = vysledek.ToString();
            }
            catch (FormatException ex)
            {
                label1.Text = ex.ToString();
            }
            catch (OverflowException ex)
            {
                label1.Text = ex.ToString();
            }
            catch (IndexOutOfRangeException ex)
            {
                label1.Text = ex.ToString();
            }
        }
    }
}
