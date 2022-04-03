using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_AtYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        Random rnd = new Random(); // Rastgele sayı üretmek için yazdık.
        private void timer1_Tick(object sender, EventArgs e)
        {
            pbGolge.Left += rnd.Next(5, 16); // koşmalarını sağladık.
            pbRuzgar.Left += rnd.Next(5, 16);
            pbGunBatimi.Left += rnd.Next(5, 16);

            if (pbRuzgar.Right >= lblFinish.Left)
            {
                timer1.Stop(); // her yarışta süreyi durdurduk.
                DialogResult dr = MessageBox.Show("Yarısı Rüzgar kazandı \nTekrar oynamak ister misiniz?", "Rüzgarın esişi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    pbGolge.Left = pbRuzgar.Left = pbGunBatimi.Left = 0; // baştan başlanmak isterse hepsini sıfırladık.

                }
                else
                {
                    Application.Exit();
                }
            }

            else if (pbGolge.Right >= lblFinish.Left)
            {
                timer1.Stop();
                DialogResult dr = MessageBox.Show("Yarısı Gölge kazandı \nTekrar oynamak ister misiniz", "Gölgelerin gücü", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    pbGolge.Left = pbRuzgar.Left = pbGunBatimi.Left = 0;
                }
                else
                {
                    Application.Exit();
                }
            }

            else if (pbGunBatimi.Right >= lblFinish.Left)
            {
                timer1.Stop();
                DialogResult dr = MessageBox.Show("Yarısı GünBatımı kazanarak günü ismine layık bir şekilde sonlandırdı", "Günbattı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    pbGolge.Left = pbRuzgar.Left = pbGunBatimi.Left = 0;
                }
                else
                {
                    Application.Exit();
                }

            }
        }
    }
}
