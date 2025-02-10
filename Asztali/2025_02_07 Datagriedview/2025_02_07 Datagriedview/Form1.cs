using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2025_02_07_Datagriedview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TablaBeallitasok();
            TablaAdatok();
        }

        private void TablaAdatok()
        {
            tablaDGV.Rows[0].Cells[0].Value = "0,0";
            tablaDGV.Rows[0].HeaderCell.Value = "12";
            tablaDGV.Columns[0].HeaderText = "név";
        }

        void TablaBeallitasok()
        {
            tablaDGV.RowCount = 337;
            tablaDGV.ColumnCount = 6;

            int magassag = 30;
            //int szelesseg = 30;
            SorMagassagBeallitasa(magassag);
            //OszlopSzelessegBeallitasa(szelesseg);
            //tablaDGV.ColumnHeadersVisible = false;
            //tablaDGV.RowHeadersVisible = false;
            //tablaDGV.Width = tablaDGV.ColumnCount * szelesseg + 3;
            //tablaDGV.Height = tablaDGV.RowCount * magassag + 3;

        }

        private void OszlopSzelessegBeallitasa(int szelesseg)
        {
            for (int i = 0; i < tablaDGV.ColumnCount; i++)
            {
                tablaDGV.Columns[i].Width = szelesseg;
            }
        }

        private void SorMagassagBeallitasa(int magassag)
        {
            for (int i = 0; i < tablaDGV.RowCount; i++)
            {
                tablaDGV.Rows[i].Height = magassag;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            StreamReader f = new StreamReader("eredmenyek.csv");
            string[] sv = f.ReadLine().Split(';'); 
            for (int k = 0; k < sv.Length; k++)
            {
                tablaDGV.Columns[k].HeaderCell.Value = sv[k];
            }
            
            int j  = 0;
            while (!f.EndOfStream)
            {

                string[] st = f.ReadLine().Split(';');
                
                for (int i = 0;i < st.Length; i++)
                {
                    tablaDGV.Rows[j].Cells[i].Value = st[i];
                    
                }
                j++;
     

            }
            f.Close();
        }
    }
}
