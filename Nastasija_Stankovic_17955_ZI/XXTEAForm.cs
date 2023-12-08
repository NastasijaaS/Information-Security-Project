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

namespace Nastasija_Stankovic_17955_ZI
{
    public partial class XXTEAForm : Form
    {
        XXTEA xxtea;
        OFB ofb;
        bool def_flag = true;

        bool kljucP;
        bool ofb_flag = true;

        byte[] ucitanFajl;
        string putanjaCitanje;
 

        public XXTEAForm()
        {
            xxtea = new XXTEA();
            ofb = new OFB();

            InitializeComponent();

            groupBox2.Controls.Add(OFBYes);
            groupBox2.Controls.Add(OFBNo);
            groupBox3.Controls.Add(Crprbn);
            groupBox3.Controls.Add(Decrbn);
            IVgb.Controls.Add(SetIV);
            IVgb.Controls.Add(ivTB);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void DifKljucbtn_Click(object sender, EventArgs e)
        {
            string[] value = this.xxtea.PostaviDifoltniKljuc();
            SetKeyTbx(value);
            kljucP = true;

        }

        private void SetKeyTbx(string[] value)
        {
            K1tb.Text = value[0];
            K2tb.Text = value[1];
            K3tb.Text = value[2];
            K4tb.Text = value[3];
        }

        private void SetKljucbtn_Click(object sender, EventArgs e)
        {
            String[] s = new String[4];
            bool prazno = string.IsNullOrEmpty(K1tb.Text);
            prazno |= string.IsNullOrEmpty(K2tb.Text);
            prazno |= string.IsNullOrEmpty(K3tb.Text);
            prazno |= string.IsNullOrEmpty(K4tb.Text);

            if (prazno)
            {
                MessageBox.Show("Popunite sva 4 polja za kljuceve.",
                        "Obavestenje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                return;
            }
            s[0] = K1tb.Text;
            s[1] = K2tb.Text;
            s[2] = K3tb.Text;
            s[3] = K4tb.Text;
            xxtea.Kljuc = s;
            kljucP = true;
            if (xxtea.ValidnostKljuca)
            {
                MessageBox.Show("Uspesno ste postavili kljuc!",
                "Obavestenje",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Kljuc je neispravan.",
                "Obavestenje",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
                return;
            }
        }

        private void CdpDecbtn_Click(object sender, EventArgs e)
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

            if (Crprbn.Checked == false && Decrbn.Checked==false )
            {
                MessageBox.Show("Izaberite da li zelite kriptovanje/dekriptovanje.",
                        "Notification",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                return;
            }
            if (Crprbn.Checked == true)
                def_flag = true;
            else
                def_flag = false;
            ofb_flag = OFBYes.Checked;
            //IVgb.Enabled = ofb_flag;
            if (ofb_flag)
            {
                this.KDtb.Text = kljucP ? def_flag ? ofb.EnkriptujOFB(this.unosTB.Text) : ofb.DekriptujOFB(this.unosTB.Text) : "";
            }
            else
                this.KDtb.Text = kljucP ? def_flag ? xxtea.Kriptovanje(this.unosTB.Text) : xxtea.Dekriptovanje(this.unosTB.Text) : "";

        }

        private void UcitajBtn_Click(object sender, EventArgs e)
        {

        }

        private void SacuvajBtn_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Bitmap Files (*.bmp) | *.bmp";
            dialog.ShowDialog();
            if (dialog.FileName != "")
            {
                pictureBox1.ImageLocation = dialog.FileName;
                pictureBox1.Refresh();
                unosTB.Text = dialog.FileName;
            }

        }
        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void kripBMP_Click(object sender, EventArgs e)
        {
            if (!kljucP)
            {
                MessageBox.Show("Postavite kljuc!",
                        "Notification",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                return;
            }
            byte[] bmpD = xxtea.EncryptBMP(unosTB.Text);
            using (MemoryStream stream = new MemoryStream(bmpD))
            {
                Bitmap image = new Bitmap(stream);
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Bitmap Files (*.bmp) | *.bmp";
                dialog.ShowDialog();
                if (dialog.FileName != "")
                {
                    image.Save(dialog.FileName);
                    pictureBox1.ImageLocation = (dialog.FileName);
                    pictureBox1.Refresh();
                }
            }
                            MessageBox.Show("Uspesno ste kriptovali BMP.",
                "Obavestenje",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
                return;
        }

        private void decBMP_Click(object sender, EventArgs e)
        {
            if (!kljucP)
            {
                MessageBox.Show("Postavite kljuc!",
                        "Notification",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                return;
            }
            byte[] bmpD = xxtea.DecryptBMP(unosTB.Text);

            using (MemoryStream stream = new MemoryStream(bmpD))
            {
                Bitmap image = new Bitmap(stream);
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Bitmap Files (*.bmp) | *.bmp";
                dialog.ShowDialog();
                if (dialog.FileName != "")
                {
                    image.Save(dialog.FileName);
                    pictureBox1.ImageLocation = (dialog.FileName);
                    pictureBox1.Refresh();
                }
            }

                     MessageBox.Show("Uspesno ste dekriptovali BMP.",
                "Obavestenje",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
                return;
        }

        private void SetIV_Click(object sender, EventArgs e)
        {
            bool prazno = string.IsNullOrEmpty(ivTB.Text);

            if (prazno)
            {
                MessageBox.Show("Unesite IV.",
                        "Notification",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                return;
            }
            if(ivTB.Text.Length<8)
            {
                                MessageBox.Show("Duzina mora da bude 8!",
                        "Notification",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                return;
            }
            string iV = ivTB.Text;
            ofb.InitializationVector = Encoding.ASCII.GetBytes(ivTB.Text);
                                 MessageBox.Show("Uspesno ste postavili IV!",
                        "Notification",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog folderDialog = new SaveFileDialog();
            folderDialog.Filter = "Text|*.txt|All|*.*";
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fajlZaUpis = null;
                try
                {
                    byte[] tekstZaUpis = new byte[this.KDtb.TextLength];
                    tekstZaUpis = Encoding.UTF8.GetBytes(this.KDtb.Text);

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
    }
}
