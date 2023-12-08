using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nastasija_Stankovic_17955_ZI
{
    public partial class Pocetna : Form
    {
        public Pocetna()
        {
            InitializeComponent();
        }
        private void OTPbutton_Click(object sender, EventArgs e)
        {
            OTPForm OTP = new OTPForm();
            OTP.Show();
        }
        private void FSCbutton_Click(object sender, EventArgs e)
        {
            FSCForm FSC = new FSCForm();
            FSC.Show();
        }
        private void XXTEAbtn_Click(object sender, EventArgs e)
        {
            XXTEAForm XXTEA = new XXTEAForm();
            XXTEA.Show();
        }

    }
}
