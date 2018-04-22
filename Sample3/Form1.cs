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

namespace Sample3
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
            lblValid.Text = "";
        }

        private void btnValid_Click(object sender, EventArgs e)
        {
            lblValid.Text = Mine.ValidateHash(txtHash.Text, int.Parse(txtBlock.Text), txtTexto.Text, long.Parse(txtNonce.Text), "0000000000000000000000000000000000000000000000000000000000000000", txtCharacter.Text.ToCharArray()[0], int.Parse(txtDificulty.Text)) ? "Is Valid" : "Is not Valid";
        }

        private void btnMine2_Click(object sender, EventArgs e)
        {
            DateTime startTime = DateTime.Now;
            long nonce = 0;
            txtHash2.Text = "";
            txtNonce2.Text = "";
            Application.DoEvents();
            txtHash2.Text = Mine.GetHash(int.Parse(txtBlock2.Text), txtTexto2.Text, ref nonce, txtHash.Text, txtCharacter.Text.ToCharArray()[0], int.Parse(txtDificulty.Text));
            txtNonce2.Text = nonce.ToString();
            lblDuration2.Text = DateTime.Now.Subtract(startTime).ToString("c", CultureInfo.InvariantCulture);
            lblValid2.Text = "";
        }

        private void btnValida2_Click(object sender, EventArgs e)
        {
            lblValid2.Text = Mine.ValidateHash(txtHash2.Text, int.Parse(txtBlock2.Text), txtTexto2.Text, long.Parse(txtNonce2.Text), txtHash.Text, txtCharacter.Text.ToCharArray()[0], int.Parse(txtDificulty.Text)) ? "Is Valid" : "Is not Valid";
        }

        private void btnMine3_Click(object sender, EventArgs e)
        {
            DateTime startTime = DateTime.Now;
            long nonce = 0;
            txtHash3.Text = "";
            txtNonce3.Text = "";
            Application.DoEvents();
            txtHash3.Text = Mine.GetHash(int.Parse(txtBlock3.Text), txtTexto3.Text, ref nonce, txtHash2.Text, txtCharacter.Text.ToCharArray()[0], int.Parse(txtDificulty.Text));
            txtNonce3.Text = nonce.ToString();
            lblDuration3.Text = DateTime.Now.Subtract(startTime).ToString("c", CultureInfo.InvariantCulture);
            lblValid3.Text = "";
        }

        private void btnValida3_Click(object sender, EventArgs e)
        {
            lblValid3.Text = Mine.ValidateHash(txtHash3.Text, int.Parse(txtBlock3.Text), txtTexto3.Text, long.Parse(txtNonce3.Text), txtHash2.Text, txtCharacter.Text.ToCharArray()[0], int.Parse(txtDificulty.Text)) ? "Is Valid" : "Is not Valid";
        }

        private void btnValidaTodo_Click(object sender, EventArgs e)
        {
            bool valid = Mine.ValidateHash(txtHash.Text, int.Parse(txtBlock.Text), txtTexto.Text, long.Parse(txtNonce.Text), "0000000000000000000000000000000000000000000000000000000000000000", txtCharacter.Text.ToCharArray()[0], int.Parse(txtDificulty.Text));
            bool valid2 = Mine.ValidateHash(txtHash2.Text, int.Parse(txtBlock2.Text), txtTexto2.Text, long.Parse(txtNonce2.Text), txtHash.Text, txtCharacter.Text.ToCharArray()[0], int.Parse(txtDificulty.Text));
            bool valid3 = Mine.ValidateHash(txtHash3.Text, int.Parse(txtBlock3.Text), txtTexto3.Text, long.Parse(txtNonce3.Text), txtHash2.Text, txtCharacter.Text.ToCharArray()[0], int.Parse(txtDificulty.Text));

            lblValid.Text = valid ? "Is Valid" : "Is not Valid";
            lblValid2.Text = valid2 ? "Is Valid" : "Is not Valid";
            lblValid3.Text = valid3 ? "Is Valid" : "Is not Valid";
            lblValidAll.Text = valid && valid2 && valid3 ? "Is Valid" : "Is not Valid";
        }
    }
}
