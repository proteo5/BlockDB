using BlockDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblMD5Hash.Text = Hashes.MD5Of(txtTexto.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lblSHA1.Text = Hashes.SHA1Of(txtTexto.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblSHA256.Text = Hashes.SHA256Of(txtTexto.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblSHA384.Text = Hashes.SHA384Of(txtTexto.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblSHA512.Text = Hashes.SHA512Of(txtTexto.Text);
        }
    }
}
