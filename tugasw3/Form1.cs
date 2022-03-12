using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugasw3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelBwh_Click(object sender, EventArgs e)
        {

        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            var cekHuruf = StringComparison.OrdinalIgnoreCase;
            var hitung = labelBwh.Font.Size;
            if (textBoxData.Text.Substring(0,4).Equals("ISI:",cekHuruf) )
            {
                labelBwh.Text = textBoxData.Text.Substring(4);
            }
            else if (textBoxData.Text.Equals("SHOWN", cekHuruf))
            {
                labelBwh.Visible = true;
            }
            else if (textBoxData.Text.Equals("HIDE", cekHuruf))
            {
                labelBwh.Visible = false;
            }
            else if (textBoxData.Text.Equals("WARNA:DEFAULT", cekHuruf))
            {
                labelBwh.ForeColor = Color.Black;
            }
            else if (textBoxData.Text.Equals("WARNA:MERAH", cekHuruf))
            {
                labelBwh.ForeColor = Color.Red;
            }
            else if (textBoxData.Text.Equals("WARNA:HIJAU", cekHuruf))
            {
                labelBwh.ForeColor = Color.Green;
            }
            else if (textBoxData.Text.Equals("WARNA:BIRU", cekHuruf))
            {
                labelBwh.ForeColor = Color.Blue;
            }
            else if (textBoxData.Text.Equals("RESTART", cekHuruf))
            {
                labelBwh.ForeColor = Color.Black;
                labelBwh.Font = new Font(labelBwh.Font.FontFamily, 15);
                labelBwh.Text = "[EMPTY]";
            }
            else if (textBoxData.Text.Equals("BESARKAN", cekHuruf))
            {
                hitung++;
                labelBwh.Font = new Font(labelBwh.Font.FontFamily, hitung);
            }
            else if (textBoxData.Text.Equals("kecilkan", cekHuruf))
            {
                hitung--;
                labelBwh.Font = new Font(labelBwh.Font.FontFamily, hitung);
            }
            else
            {
                MessageBox.Show("Syntax tidak terdaftar!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
