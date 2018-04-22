using BlockDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMine_Click(object sender, EventArgs e)
        {
            DateTime startTime = DateTime.Now;
            long nonce = 0;
            txtHash.Text = "";
            txtNonce.Text = "";
            Application.DoEvents();
            txtHash.Text = Mine.GetHash(int.Parse(txtBlock.Text), txtTexto.Text, ref nonce, "0000000000000000000000000000000000000000000000000000000000000000", txtCharacter.Text.ToCharArray()[0], int.Parse(txtDificulty.Text));
            txtNonce.Text = nonce.ToString();
            lblDuration.Text = DateTime.Now.Subtract(startTime).ToString("c", CultureInfo.InvariantCulture);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime startTime = DateTime.Now;
            int nonce2 = 0;
            txtHash.Text = "";
            txtNonce.Text = "";
            Application.DoEvents();
            txtHash.Text = Mine.GetHashParallel(int.Parse(txtBlock.Text), txtTexto.Text, ref nonce2, "0000000000000000000000000000000000000000000000000000000000000000", txtCharacter.Text.ToCharArray()[0], int.Parse(txtDificulty.Text));
            txtNonce.Text = nonce2.ToString();
            lblDuration2.Text = DateTime.Now.Subtract(startTime).ToString("c", CultureInfo.InvariantCulture);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblValid.Text = Mine.ValidateHash(txtHash.Text, int.Parse(txtBlock.Text), txtTexto.Text, long.Parse(txtNonce.Text), "0000000000000000000000000000000000000000000000000000000000000000", txtCharacter.Text.ToCharArray()[0], int.Parse(txtDificulty.Text)) ? "Is Valid" : "Is not Valid";
        }
    }
}
