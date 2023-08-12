using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsCoreImob.Context;

namespace WinFormsCoreImob
{
    public partial class FrmBuscar : Form
    {
        public FrmBuscar()
        {
            InitializeComponent();
        }
        private void CarregarGridPossiveisCompradores()
        {
            try
            {
                using (var context = new AppDbContext())
                {

                    var consultaClientes = context.ClientesImoveis.ToList();

                    List<EncontrarVO> clienteEncontrado = new List<EncontrarVO>();
                    foreach (var venda in consultaClientes)
                    {
                        foreach (var compra in consultaClientes)
                        {
                            if (venda.ImovelVendendo == compra.ImovelComprando)
                            {
                                EncontrarVO encontrar = new EncontrarVO();

                                encontrar.Vendedor = venda.Nome;
                                encontrar.Imovel = venda.ImovelVendendo;
                                encontrar.Interessado = compra.Nome;
                                encontrar.Valor = Convert.ToDecimal(venda.Valor);

                                clienteEncontrado.Add(encontrar);
                            }
                        }
                    }

                    grdBuscar.DataSource = clienteEncontrado;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("NAO FOI POSSIVEL ENCONTRAR DADOS PARA MOSTRAR", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void FrmBuscar_Load(object sender, EventArgs e)
        {
            CarregarGridPossiveisCompradores();
        }

        private void VoltartoolStripButton1_Click(object sender, EventArgs e)
        {
            FrmMenu frm = new FrmMenu();
            this.Hide();
            frm.ShowDialog();


        }

        private void SairtoolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
