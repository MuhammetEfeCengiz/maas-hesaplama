using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maaş_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int maasi,mesaisaati,zamlimaas;
            maasi = Convert.ToInt32(Maas_txt.Text);
            mesaisaati = Convert.ToInt32(Msaati_txt.Text);
            zamlimaas = (10 * mesaisaati)+maasi;
            sonuc_lbl.Text = Ad_txt.Text + " " + Soyad_txt.Text +   " ' Adlı Kişinin Maaşı : " + zamlimaas.ToString();
        }
    }
}
