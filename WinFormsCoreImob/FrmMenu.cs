using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCoreImob
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnTelaCadastro_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmCadastro())
            {
                this.Hide();
                frm.ShowDialog();
            }
        }

        private void btnTelaConsulta_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmConsulta())
            {
                this.Hide();
                frm.ShowDialog();
            }
        }

        private void btnTelaBuscar_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmBuscar())
            {
                this.Hide();
                frm.ShowDialog();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
