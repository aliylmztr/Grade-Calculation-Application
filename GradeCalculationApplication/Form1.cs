using System;
using System.Windows.Forms;

namespace GradeApplicationApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }    

        private void btn_ortalamaHesapla_Click(object sender, EventArgs e)
        {
            double ortalama = (Convert.ToDouble(txt_birinciNot.Text) + Convert.ToDouble(txt_ikinciNot.Text)) / 2;
            lbl_ortalamaSonuc.Text = ortalama.ToString();
        }
    }
}
