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
    public partial class FrmConsulta : Form
    {
        
        
        public FrmConsulta()
        {
            InitializeComponent();
            
        }
        public void CarregarGrid()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var clientes = context.ClientesImoveis.OrderBy(x => x.Nome).ToList();

                    grdConsulta.DataSource = clientes;

                    grdConsulta.Columns["Id"].Visible = false;

                    grdConsulta.Columns["ImovelVendendo"].HeaderText = "Imovel";
                    grdConsulta.Columns["ImovelComprando"].HeaderText = "Interesse";
                    grdConsulta.Columns["DataCadastro"].HeaderText = "Criado";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nao foi possivel encontrar dados para mostrar", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void FrmConsulta_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            
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

        private void btnFiltrarNome_Click(object sender, EventArgs e)
        {

            var filtro = txtFiltrar.Text.ToUpper().Trim();
            List<ClienteImovel> clienteImoveis = new List<ClienteImovel>();
            List<ClienteImovel> listaConsulta = new List<ClienteImovel>();

            using (var context = new AppDbContext())
            {

                listaConsulta = context.ClientesImoveis.ToList();

                foreach (var item in listaConsulta)
                {
                    if (item.Nome.Contains(filtro) || item.ImovelVendendo.Contains(filtro) || item.ImovelComprando.Contains(filtro))
                    {
                        ClienteImovel vo = new ClienteImovel();

                        vo.Id = item.Id;
                        vo.Nome = item.Nome;
                        vo.Email = item.Email;
                        vo.Celular = item.Celular;
                        vo.ImovelVendendo = item.ImovelVendendo;
                        vo.ImovelComprando = item.ImovelComprando;
                        vo.Valor = item.Valor;
                        vo.DataCadastro = item.DataCadastro;
                        vo.Observacoes = item.Observacoes;

                        clienteImoveis.Add(vo);
                    }
                }
            }

            grdConsulta.DataSource = clienteImoveis;
            grdConsulta.Columns["Id"].Visible = false;

            grdConsulta.Columns["ImovelVendendo"].HeaderText = "Imovel";
            grdConsulta.Columns["ImovelComprando"].HeaderText = "Interesse";
            grdConsulta.Columns["DataCadastro"].HeaderText = "Criado";

            LimparCampos();

        }

        private void btnFiltrarValor_Click(object sender, EventArgs e)
        {

            if (ValidarCampos())
            {
                var valorMin = Convert.ToDecimal(txtValorMin.Text.Trim());
                var valorMax = Convert.ToDecimal(txtValorMax.Text.Trim());
                List<ClienteImovel> clienteImoveis = new List<ClienteImovel>();
                List<ClienteImovel> listaConsulta = new List<ClienteImovel>();

                using (var context = new AppDbContext())
                {

                    listaConsulta = context.ClientesImoveis.ToList();

                    foreach (var item in listaConsulta)
                    {
                        if (item.Valor >= valorMin && item.Valor <= valorMax)
                        {
                            ClienteImovel vo = new ClienteImovel();

                            vo.Id = item.Id;
                            vo.Nome = item.Nome;
                            vo.Email = item.Email;
                            vo.Celular = item.Celular;
                            vo.ImovelVendendo = item.ImovelVendendo;
                            vo.ImovelComprando = item.ImovelComprando;
                            vo.Valor = item.Valor;
                            vo.DataCadastro = item.DataCadastro;
                            vo.Observacoes = item.Observacoes;

                            clienteImoveis.Add(vo);
                        }
                    }
                }

                grdConsulta.DataSource = clienteImoveis;
                grdConsulta.Columns["Id"].Visible = false;

                grdConsulta.Columns["ImovelVendendo"].HeaderText = "Imovel";
                grdConsulta.Columns["ImovelComprando"].HeaderText = "Interesse";
                grdConsulta.Columns["DataCadastro"].HeaderText = "Criado";

                LimparCampos();
            }
        }



        private void LimparCampos()
        {
            txtFiltrar.Clear();
            txtValorMin.Clear();
            txtValorMax.Clear();
        }
        private bool ValidarCampos()
        {
            bool ret = true;
            string campos = "";

            if (txtValorMin.Text.Trim() == "")
            {
                ret = false;
                campos += "- Valor Minimo \n";
            }
            if (txtValorMax.Text.Trim() == "")
            {
                ret = false;
                campos += "- Valor Max \n ";
            }


            if (!ret)
            {
                MessageBox.Show("Complete os campos solicitados \n\n" + campos, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }

    }
}
