using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internet.FORMS
{
    public partial class frmClienteRoteador : Form
    {
        public frmClienteRoteador()
        {
            InitializeComponent();
        }

        private void frmClienteRoteador_Load(object sender, EventArgs e)
        {
            CAMADAS.BLL.Clientes bllClientes = new CAMADAS.BLL.Clientes();
            cmbCliente.DisplayMember = "nome";
            cmbCliente.ValueMember = "id";
            cmbCliente.DataSource = bllClientes.Select();

            dtgCliente.DataSource = "";
            dtgCliente.DataSource = bllClientes.Select();

            CAMADAS.BLL.Roteador bllRoteador = new CAMADAS.BLL.Roteador();
            cmbRoteador.DisplayMember = "nome";
            cmbRoteador.ValueMember = "id";
            cmbRoteador.DataSource = bllRoteador.Select();

            dtgRoteador.DataSource = "";
            dtgRoteador.DataSource = bllRoteador.Select();

            CAMADAS.BLL.ClienteRoteador bllClienteRoteador = new CAMADAS.BLL.ClienteRoteador();
            dtgClienteRoteador.DataSource = "";
            dtgClienteRoteador.DataSource = bllClienteRoteador.Select();

            habilitaCampos(false);
            dtpDataFinal.Enabled = false;
            limpaCampos();
            gpbFiltrar.Visible = false;

            habilitaBotoes(true);
        }

        //funcoes
        private void limpaCampos()
        {
            lblOperacaoID.Text = "-1";
            txtClienteID.Text = "";
            txtRoteadorID.Text = "";
            dtpData.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            dtpDataFinal.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        }

        private void habilitaCampos(bool status)
        {
            txtClienteID.Enabled = status;
            cmbCliente.Enabled = status;
            txtRoteadorID.Enabled = status;
            cmbRoteador.Enabled = status;
            dtpData.Enabled = status;
        }

        private void habilitaBotoes(bool status)
        {
            btnNovo.Enabled = status;
            btnEditar.Enabled = !status;
            btnDevolver.Enabled = !status;
        }

        //cliente
        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtClienteID.Text = cmbCliente.SelectedValue.ToString();
        }

        private void cmbCliente_Leave(object sender, EventArgs e)
        {
            cmbCliente_SelectedIndexChanged(null, null);
        }

        private void txtClienteID_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtClienteID.Text != "")
                {
                    cmbCliente.SelectedValue = Convert.ToInt32(txtClienteID.Text);
                }
            }
            catch
            {
                MessageBox.Show("Cliente Invalido");
                cmbCliente.Focus();
            }
        }

        private void dtgCliente_DoubleClick(object sender, EventArgs e)
        {
            cmbCliente.SelectedValue = Convert.ToInt32(dtgCliente.SelectedRows[0].Cells["id"].Value.ToString());
            txtClienteID.Text = dtgCliente.SelectedRows[0].Cells["id"].Value.ToString();
        }

        //roteador
        private void cmbRoteador_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoteadorID.Text = cmbRoteador.SelectedValue.ToString();
        }
        private void cmbRoteador_Leave(object sender, EventArgs e)
        {
            try
            {
                cmbRoteador_SelectedIndexChanged(null, null);
            }
            catch
            {
                MessageBox.Show("Informe um Roteador...");
                cmbRoteador.Focus();
            }
        }

        private void txtRoteadorID_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtRoteadorID.Text != "")
                {
                    cmbRoteador.SelectedValue = Convert.ToInt32(txtRoteadorID.Text);
                }
            }
            catch
            {
                MessageBox.Show("Roteador Invalido");
                cmbRoteador.Focus();
            }
        }

        private void dtgRoteador_DoubleClick(object sender, EventArgs e)
        {
            cmbRoteador.SelectedValue = Convert.ToInt32(dtgRoteador.SelectedRows[0].Cells["id_roteador"].Value.ToString());
            txtRoteadorID.Text = dtgRoteador.SelectedRows[0].Cells["id_roteador"].Value.ToString();
        }

        //botoes
        private void btnNovo_Click(object sender, EventArgs e)
        {
            limpaCampos();
            habilitaCampos(true);
            lblOperacaoID.Text = "-1";
            cmbCliente.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitaCampos(true);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.ClienteRoteador clienteRoteador = new CAMADAS.MODEL.ClienteRoteador();

            clienteRoteador.clienteID = Convert.ToInt32(txtClienteID.Text);
            clienteRoteador.roteadorID = Convert.ToInt32(txtRoteadorID.Text);
            clienteRoteador.dataInicio = Convert.ToDateTime(dtpData.Text);
            clienteRoteador.dataFim = Convert.ToDateTime("01/01/1900");

            CAMADAS.BLL.ClienteRoteador bllClienteRoteador = new CAMADAS.BLL.ClienteRoteador();

            if (lblOperacaoID.Text == "-1")
            {
                //CAMADAS.DAL.ClienteRoteador dalClienteRoteador = new CAMADAS.DAL.ClienteRoteador();
                CAMADAS.BLL.Roteador bllRoteador = new CAMADAS.BLL.Roteador();
                List<CAMADAS.MODEL.Roteador> listaRoteador = bllRoteador.SelectByID(clienteRoteador.roteadorID);
                CAMADAS.MODEL.Roteador roteador = listaRoteador[0];

                if (roteador.situacao == 1)
                {
                    bllClienteRoteador.Insert(clienteRoteador);
                    limpaCampos();
                }
                else
                {
                    string mensagem = "Roteador já em uso";
                    MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                clienteRoteador.id = Convert.ToInt32(lblOperacaoID.Text);
                bllClienteRoteador.Update(clienteRoteador);
            }

            dtgClienteRoteador.DataSource = bllClienteRoteador.Select();
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            dtpDataFinal.Enabled = true;

            CAMADAS.MODEL.ClienteRoteador clienteRoteador = new CAMADAS.MODEL.ClienteRoteador();

            clienteRoteador.id = Convert.ToInt32((lblOperacaoID.Text).ToString());
            clienteRoteador.clienteID = Convert.ToInt32((txtClienteID.Text).ToString());
            clienteRoteador.roteadorID = Convert.ToInt32((txtRoteadorID.Text).ToString());
            clienteRoteador.dataInicio = Convert.ToDateTime(dtpData.Text);
            clienteRoteador.dataFim = Convert.ToDateTime(dtpDataFinal.Text);

            CAMADAS.DAL.ClienteRoteador dalClienteRoteador = new CAMADAS.DAL.ClienteRoteador();

            CAMADAS.BLL.Roteador bllRoteador = new CAMADAS.BLL.Roteador();

            List<CAMADAS.MODEL.Roteador> listaRoteador = bllRoteador.SelectByID(clienteRoteador.roteadorID);
            CAMADAS.MODEL.Roteador roteador = listaRoteador[0];

            CAMADAS.BLL.ClienteRoteador bllClienteRoteador = new CAMADAS.BLL.ClienteRoteador();
            if ((lblOperacaoID.Text != "-1") && (roteador.situacao == 2))
            {
                bllClienteRoteador.Devolver(clienteRoteador);

                string mensagem = "Roteador Devolvido!";
                string tituloMensagem = "Devolver";

                DialogResult resposta = MessageBox.Show(mensagem, tituloMensagem, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string mensagem = "Roteador não está disponível para Entrega!";
                string tituloMensagem = "Devolver";

                DialogResult resposta = MessageBox.Show(mensagem, tituloMensagem, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            dtgClienteRoteador.DataSource = bllClienteRoteador.Select();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaCampos();
            habilitaCampos(false);
            habilitaBotoes(true);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            gpbFiltrar.Visible = !gpbFiltrar.Visible;
            rdbID.Enabled = false;
            rdbNome.Enabled = false;
            txtPesquisar.Enabled = false;
            btnPesquisarImagem.Enabled = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dtgClienteRoteador_DoubleClick(object sender, EventArgs e)
        {
            lblOperacaoID.Text = dtgClienteRoteador.SelectedRows[0].Cells["id_ClienteRoteador"].Value.ToString();
            cmbCliente.SelectedValue = Convert.ToInt32(dtgClienteRoteador.SelectedRows[0].Cells["clienteID"].Value.ToString());
            txtClienteID.Text = dtgClienteRoteador.SelectedRows[0].Cells["clienteID"].Value.ToString();
            cmbRoteador.SelectedValue = Convert.ToInt32(dtgClienteRoteador.SelectedRows[0].Cells["roteadorID"].Value.ToString());
            txtRoteadorID.Text = dtgClienteRoteador.SelectedRows[0].Cells["roteadorID"].Value.ToString();
            dtpData.Value = Convert.ToDateTime(dtgClienteRoteador.SelectedRows[0].Cells["dataInicio"].Value.ToString());
            dtpDataFinal.Value = Convert.ToDateTime(dtgClienteRoteador.SelectedRows[0].Cells["dataFim"].Value.ToString());

            habilitaBotoes(false);

            if(dtpDataFinal.Value == Convert.ToDateTime("01/01/1900")){
                dtpDataFinal.Enabled = true;
            }
            else
            {
                dtpDataFinal.Enabled = false;
            }
            habilitaCampos(false);
        }

        private void cmbSelecao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbSelecao.SelectedItem != null)
            {
                rdbID.Enabled = true;
                rdbNome.Enabled = true;
            }
        }

        private void rdbID_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisar.Enabled = true;
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisar.Enabled = true;
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            if(txtPesquisar.Text != "")
            {
                btnPesquisarImagem.Enabled = true;
            }
            else
            {
                btnPesquisarImagem.Enabled = false;
            }
        }

        private void btnPesquisarImagem_Click(object sender, EventArgs e)
        {
            string mensagem;
            string tituloMensagem;
            try
            {
                if (cmbSelecao.SelectedItem.ToString() == "Clientes")
                {
                    CAMADAS.BLL.Clientes bllClientes = new CAMADAS.BLL.Clientes();
                    if (rdbID.Checked)
                    {
                        int idCliente = Convert.ToInt32(txtPesquisar.Text);
                        dtgCliente.DataSource = bllClientes.SelectByID(idCliente);
                    }
                    else if (rdbNome.Checked)
                    {
                        string nomeCliente = txtPesquisar.Text;
                        dtgCliente.DataSource = bllClientes.SelectByNome(nomeCliente);
                    }
                }
                else if (cmbSelecao.SelectedItem.ToString() == "Roteador")
                {
                    CAMADAS.BLL.Roteador bllRoteador = new CAMADAS.BLL.Roteador();
                    if (rdbID.Checked)
                    {
                        int idRoteador = Convert.ToInt32(txtPesquisar.Text);
                        dtgRoteador.DataSource = bllRoteador.SelectByID(idRoteador);
                    }
                    else if (rdbNome.Checked)
                    {
                        string nomeRoteador = txtPesquisar.Text;
                        dtgRoteador.DataSource = bllRoteador.SelectByNome(nomeRoteador);
                    }
                }
            }
            catch
            {
                mensagem = "Valor Pesquisado não Pertence a Tabela de Dados";
                tituloMensagem = "Erro";
                MessageBox.Show(mensagem, tituloMensagem, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            CAMADAS.BLL.Clientes bllClientes = new CAMADAS.BLL.Clientes();
            CAMADAS.BLL.Roteador bllRoteador = new CAMADAS.BLL.Roteador();
            
            if (cmbSelecao.SelectedItem.ToString() == "Clientes")
            {
                dtgCliente.DataSource = bllClientes.Select();
            }
                else if (cmbSelecao.SelectedItem.ToString() == "Roteador")
                {
                     dtgRoteador.DataSource = bllRoteador.Select();
                }
                    else if (cmbSelecao.SelectedItem.ToString() == "Geral")
                    {
                        dtgCliente.DataSource = bllClientes.Select();
                        dtgRoteador.DataSource = bllRoteador.Select();
                        rdbID.Enabled = false;
                        rdbNome.Enabled = false;
                    }
        }
    }
}
