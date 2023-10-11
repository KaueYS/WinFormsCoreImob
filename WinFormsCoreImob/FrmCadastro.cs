using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsCoreImob.Context;

namespace WinFormsCoreImob
{
    public partial class FrmCadastro : Form
    {

        public FrmCadastro()
        {
            InitializeComponent();
        }

        public void CarregarGrid()
        {
            using (var context = new AppDbContext())
            {
                var clientes = context.ClientesImoveis.OrderBy(x => x.Nome).ToList();

                grdCadastro.DataSource = clientes;

                grdCadastro.Columns["Id"].Visible = false;

                grdCadastro.Columns["ImovelVendendo"].HeaderText = "Imovel";
                grdCadastro.Columns["ImovelComprando"].HeaderText = "Interesse";
                grdCadastro.Columns["DataCadastro"].HeaderText = "Criado";
            }
        }

        private void LimparCampos()
        {
            txtNomeDoCliente.Clear();
            txtEmail.Clear();
            mskCelular.Clear();
            txtNomeImovelVendendo.Clear();
            txtNomeDoImovelCompra.Clear();
            txtValorPedido.Clear();
            txtObservacoes.Clear();
            dtCadastro.Value = DateTime.Now;
        }

        private bool ValidarCampos()
        {
            bool ret = true;
            string campos = "";

            if (txtNomeDoCliente.Text.Trim() == "")
            {
                ret = false;
                campos += "- Nome Completo \n";
            }
            if (txtEmail.Text.Trim() == "")
            {
                ret = false;
                campos += "- Email \n ";
            }
            if (mskCelular.Text == "")
            {
                ret = false;
                campos += "- Telefone \n ";
            }
            if (txtNomeImovelVendendo.Text.Trim() == "")
            {
                ret = false;
                campos += "- Nome do Imovel vendendo \n";
            }
            if (txtValorPedido.Text == "")
            {
                ret = false;
                campos += "- Valor \n";
            }

            if (txtNomeDoImovelCompra.Text.Trim() == "")
            {
                ret = false;
                campos += "- Nome do Imovel comprando \n";
            }

            if (!ret)
            {
                MessageBox.Show("Complete os campos solicitados \n\n" + campos, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }

        public void Cadastrar(ClienteImovel cadastro)
        {
            using (var context = new AppDbContext())
            {

                context.ClientesImoveis.Add(cadastro);
                context.SaveChanges();
            }
        }

        private void Alterar(ClienteImovel cad)
        {
            using (var context = new AppDbContext())
            {
                context.ClientesImoveis.AddOrUpdate(cad);

                context.SaveChanges();
            }
        }

        //==============================================================================

        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void CadastrartoolStripButton1_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                ClienteImovel obj = new ClienteImovel();
                obj.Nome = txtNomeDoCliente.Text.Trim().ToUpper();
                obj.Email = txtEmail.Text.Trim().ToLower();
                obj.Celular = mskCelular.Text;
                obj.ImovelVendendo = txtNomeImovelVendendo.Text.ToUpper().Trim();
                obj.Valor = Convert.ToDecimal(txtValorPedido.Text, System.Globalization.CultureInfo.InvariantCulture);
                obj.ImovelComprando = txtNomeDoImovelCompra.Text.ToUpper().Trim();
                obj.DataCadastro = Convert.ToDateTime(dtCadastro.Value);
                obj.Observacoes = txtObservacoes.Text;

                try
                {
                    Cadastrar(obj);
                    LimparCampos();
                    CarregarGrid();
                    MessageBox.Show("CLIENTE CADASTRADO COM SUCESSO", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao cadastrar", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AlterartoolStripButton1_Click(object sender, EventArgs e)
        {
            ClienteImovel obj = new ClienteImovel();

            obj.Nome = txtNomeDoCliente.Text.Trim().ToUpper();
            obj.Email = txtEmail.Text.Trim().ToLower();
            obj.Celular = mskCelular.Text;
            obj.ImovelVendendo = txtNomeImovelVendendo.Text.ToUpper().Trim();
            obj.Valor = Convert.ToDecimal(txtValorPedido.Text);
            obj.ImovelComprando = txtNomeDoImovelCompra.Text.ToUpper().Trim();
            obj.DataCadastro = Convert.ToDateTime(dtCadastro.Value);
            obj.Observacoes = txtObservacoes.Text;

            if (ValidarCampos())
            {
                try
                {
                    Alterar(obj);
                    CarregarGrid();
                    LimparCampos();
                    MessageBox.Show("CLIENTE ALTERADO COM SUCESSO - ATENCAO APAGUE O REGISTRO ANTERIOR", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception)
                {
                    MessageBox.Show("CLIENTE NAO ALTERADO", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void grdCadastro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Quando clica na GRID carrega o fomulario

            if (grdCadastro.Rows.Count > 0)
            {
                ClienteImovel produtos = grdCadastro.CurrentRow.DataBoundItem as ClienteImovel;

                {
                    txtNomeDoCliente.Text = produtos.Nome;
                    txtEmail.Text = produtos.Email;
                    mskCelular.Text = produtos.Celular;
                    dtCadastro.Value = produtos.DataCadastro;
                    txtNomeImovelVendendo.Text = produtos.ImovelVendendo;
                    txtValorPedido.Text = Convert.ToString(produtos.Valor);
                    txtNomeDoImovelCompra.Text = produtos.ImovelComprando;
                    txtObservacoes.Text = produtos.Observacoes;
                }
            }
        }

        private void ExcluirtoolStripButton1_Click(object sender, EventArgs e)
        {


            if (txtNomeDoCliente.Text == "")
            {
                MessageBox.Show("SELECIONE UM CLIENTE ANTES DE APAGAR E TENHA CERTEZA QUE DESEJA DELETAR ESSE CLIENTE");
            }
            else
            {

                try
                {
                    ClienteImovel clienteClicado = grdCadastro.CurrentRow.DataBoundItem as ClienteImovel;
                    using (var context = new AppDbContext())
                    {
                        ClienteImovel idEnconstrado = context.ClientesImoveis.FirstOrDefault(x => x.Id == clienteClicado.Id);
                        if (idEnconstrado != null)
                        {
                            context.ClientesImoveis.Remove(idEnconstrado);
                            context.SaveChanges();
                            MessageBox.Show("CLIENTE REMOVIDO COM SUCESSO", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    CarregarGrid();
                    LimparCampos();
                }

                catch (Exception)
                {
                    MessageBox.Show("SELECIONE UM CLIENTE PARA DELETAR", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void LimpartoolStripButton1_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void SairtoolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void VoltartoolStripButton1_Click(object sender, EventArgs e)
        {
            FrmMenu frm = new FrmMenu();
            this.Hide();
            frm.ShowDialog();
        }
    }
}


