using BlockDB;
using Sample4.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'blockDBDataSet.EstadoDeCuenta' table. You can move, or remove it, as needed.
            this.estadoDeCuentaTableAdapter.Fill(this.blockDBDataSet.EstadoDeCuenta);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.estadoDeCuentaTableAdapter.Update(this.blockDBDataSet.EstadoDeCuenta);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.estadoDeCuentaTableAdapter.Fill(this.blockDBDataSet.EstadoDeCuenta);
        }

        private void btnMine_Click(object sender, EventArgs e)
        {
            var db = new BlockDBEntities();
            var registrosSinMinar = db.EstadoDeCuentas.Where(x => x.Hash == null).ToList();



            foreach (var item in registrosSinMinar)
            {
                string HashAnterior = "0000000000000000000000000000000000000000000000000000000000000000";
                if (item.ID != 1)
                {
                    HashAnterior = db.EstadoDeCuentas.Where(x => x.Hash != null).OrderByDescending(x => x.ID).Take(1).FirstOrDefault().Hash;
                }

                long nonce = 0;
                item.Hash = Mine.GetHash(item.ID, string.Join(item.Cuenta, item.Entrada.ToString(), item.Salida.ToString(), item.Saldo.ToString(), item.Fecha.ToString()), ref nonce, HashAnterior);
                item.Nonce = (int)nonce;
                db.SaveChanges();
            }
            
            this.estadoDeCuentaTableAdapter.Fill(this.blockDBDataSet.EstadoDeCuenta);
        }

        private void btnValidte_Click(object sender, EventArgs e)
        {
            var db = new BlockDBEntities();
            bool valido = true;
            var registrosMinados = db.EstadoDeCuentas.Where(x => x.Hash != null).OrderBy(x => x.ID);

            string HashAnterior = "0000000000000000000000000000000000000000000000000000000000000000";

            foreach (var item in registrosMinados)
            {
                valido = Mine.ValidateHash(item.Hash, item.ID, string.Join(item.Cuenta, item.Entrada.ToString(), item.Salida.ToString(), item.Saldo.ToString(), item.Fecha.ToString()), (long)item.Nonce, HashAnterior);
                if (!valido)
                {
                    break;
                }
                HashAnterior = item.Hash;
            }
            string mens = valido ? "" : " no";
            MessageBox.Show($"La cadena es{mens} valida.");
        }
    }
}
