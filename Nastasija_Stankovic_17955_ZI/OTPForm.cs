using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nastasija_Stankovic_17955_ZI
{
    public partial class OTPForm : Form
    {
        OTP otp;
        bool kljucP;
        byte[] ucitanFajl;
        string putanjaCitanje;

        string putanjaCitanjeParallel;
        string kljucParallel;
        string putanjaUpisParallel;
        public OTPForm()
        {
            otp = new OTP();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s;
            bool prazno = string.IsNullOrEmpty(tbKljuc.Text);
            if (prazno)
            {
                MessageBox.Show("Postavite kljuc.",
                        "Obavestenje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                return;
            }
            s = tbKljuc.Text;
            otp.Kljuc = s;
            kljucP = true;

                MessageBox.Show("Uspesno ste postavili kljuc.",
                "Obavestenje",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
                return;
        }

        private void btnCrpDe_Click(object sender, EventArgs e)
        {
            if (!kljucP)
            {
                MessageBox.Show("Postavite kljuc!",
                        "Notification",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                return;
            }
            if (this.unosTB.Text.Length == 0)
            {
                MessageBox.Show("Unesite tekst.",
                        "Notification",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                return;
            }
            this.izlazTB.Text = otp.KriptovanjeDekriptovanje(this.unosTB.Text);
        }
        private void SetKeyTbx(string value)
        {
            tbKljuc.Text = value;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string value = this.otp.PostaviDifoltniKljuc();
            SetKeyTbx(value);
            kljucP = true;
        }

        private void UcitajBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text|*.txt|All|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                putanjaCitanje = dialog.FileName;
                FileStream fajlZaCitanje = null;

                try
                {
                    fajlZaCitanje = new FileStream(putanjaCitanje, FileMode.Open);
                    int velicina = (int)fajlZaCitanje.Length;
                    byte[] nizBajtova = new byte[velicina];
                    fajlZaCitanje.Read(nizBajtova, 0, velicina);
                    ucitanFajl = nizBajtova;
                    unosTB.Text = Encoding.ASCII.GetString(ucitanFajl);

                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.ToString(),
                "Error",
                 MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                }
                fajlZaCitanje.Close();
            }
        }

        private void sacuvajBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog folderDialog = new SaveFileDialog();
            folderDialog.Filter = "Text|*.txt|All|*.*";
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fajlZaUpis = null;
                try
                {
                    byte[] tekstZaUpis = new byte[this.izlazTB.TextLength];
                    tekstZaUpis = Encoding.UTF8.GetBytes(this.izlazTB.Text);

                    fajlZaUpis = new FileStream(folderDialog.FileName, FileMode.Create);
                    fajlZaUpis.Write(tekstZaUpis, 0, tekstZaUpis.Length);

                }
                catch (IOException ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    fajlZaUpis.Close();
                }
                MessageBox.Show("Uspesno ste sacuvali fajl.",
                "Obavestenje",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {


    
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void OTPForm_Load(object sender, EventArgs e)
        {

        }

        private void KDParallel_Click(object sender, EventArgs e)
        {
            if (kljucTb.Text == "" || tekstTb.Text == "" || upisTb.Text == "")
            {
                 MessageBox.Show("Morate da izaberete fajl gde vam se nalazi kljuc,tekst i gde da se sacuva izlaz kriptovanja/dekriptovanja!",
                "Obavestenje",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
                return;
            }
            else
            {
                otp.ParallelOTP(6, kljucTb.Text, tekstTb.Text, upisTb.Text);
                MessageBox.Show("Uspesno!",
                "Obavestenje",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
                return;
            }

        }

        private void srcKljuc_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text Files (*.txt) | *.txt";
            dialog.ShowDialog();
            if (File.Exists(dialog.FileName))
            {

                kljucTb.Text = dialog.FileName;
            }
        }

        private void srcParallel_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text Files (*.txt) | *.txt";
            dialog.ShowDialog();
            if (File.Exists(dialog.FileName))
            {

                tekstTb.Text = dialog.FileName;
            }

        }

        private void destParallel_Click(object sender, EventArgs e)
        {
            SaveFileDialog folderDialog = new SaveFileDialog();
            folderDialog.Filter = "Text Files (*.txt) | *.txt";
            folderDialog.ShowDialog();
            if (folderDialog.FileName != "")
            {
                upisTb.Text = folderDialog.FileName;
            }

        }
    }
}
