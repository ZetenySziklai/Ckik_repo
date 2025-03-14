using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2025_02_21_Elemekgeneralasa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int k = 10;
        int g = 10;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            string szoveg = "0";
            
            
            
            for (int i = 0; i < 3; i++)
            {
                k = 10;
                g += 100;
                
                for (int j = 0;  j < 3;  j++)
                {
                    int kar = Convert.ToInt32(szoveg);
                    kar++;
                    szoveg = Convert.ToString(kar);

                    k += 150;
                    Button gomb = new Button();
                    gomb.Text = szoveg;
                    gomb.Name = "ujGomb"+szoveg;
                    gomb.Width = button1.Width;
                    gomb.Height = button1.Height;
                    gomb.Location = new Point(200 + k,g);
                    gomb.Click += new EventHandler(GombClick);
                    this.Controls.Add(gomb);
                }
            }
            
            
            
        }
        private void GombClick(object sender, EventArgs e)
        {
           Button gombSajatMaga = (Button)sender;
            MessageBox.Show(gombSajatMaga.Text);
        }
        
        

    }
}
