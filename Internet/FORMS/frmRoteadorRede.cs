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
    public partial class frmRoteadorRede : Form
    {
        public frmRoteadorRede()
        {
            InitializeComponent();
        }

        private void frmRoteadorRede_Load(object sender, EventArgs e)
        {
            CAMADAS.BLL.Rede bllRede = new CAMADAS.BLL.Rede();
            cmbRede.DisplayMember = "ip";
            cmbRede.ValueMember = "id";
            cmbRede.DataSource = bllRede.Select();

            dtgRede.DataSource = "";
            dtgRede.DataSource = bllRede.Select();

            CAMADAS.BLL.Roteador bllRoteador = new CAMADAS.BLL.Roteador();
            cmbRoteador.DisplayMember = "nome";
            cmbRoteador.ValueMember = "id";
            cmbRoteador.DataSource = bllRoteador.Select();

            dtgRoteador.DataSource = "";
            dtgRoteador.DataSource = bllRoteador.Select();

            CAMADAS.BLL.RoteadorRede bllRoteadorRede = new CAMADAS.BLL.RoteadorRede();
            dtgRoteadorRede.DataSource = "";
            dtgRoteadorRede.DataSource = bllRoteadorRede.Select();

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
            txtRedeID.Text = "";
            txtRoteadorID.Text = "";
            dtpData.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            dtpDataFinal.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        }

        private void habilitaCampos(bool status)
        {
            txtRedeID.Enabled = status;
            cmbRede.Enabled = status;
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
        //rede
        private void cmbRede_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRedeID.Text = cmbRede.SelectedValue.ToString();
        }

        private void cmbRede_Leave(object sender, EventArgs e)
        {
            cmbRede_SelectedIndexChanged(null, null);
        }

        private void txtRedeID_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtRedeID.Text != "")
                {
                    cmbRede.SelectedValue = Convert.ToInt32(txtRedeID.Text);
                }
            }
            catch
            {
                MessageBox.Show("Rede Invalida");
                cmbRede.Focus();
            }
        }

        private void dtgRede_DoubleClick(object sender, EventArgs e)
        {
            cmbRede.SelectedValue = Convert.ToInt32(dtgRede.SelectedRows[0].Cells["id_rede"].Value.ToString());
            txtRedeID.Text = dtgRede.SelectedRows[0].Cells["id_rede"].Value.ToString();
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
            cmbRede.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitaCampos(true);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.RoteadorRede roteadorRede = new CAMADAS.MODEL.RoteadorRede();

            roteadorRede.roteadorID = Convert.ToInt32(txtRoteadorID.Text);
            roteadorRede.redeID = Convert.ToInt32(txtRedeID.Text);
            roteadorRede.dataInicio = Convert.ToDateTime(dtpData.Text);
            roteadorRede.dataFim = Convert.ToDateTime("01/01/1900");

            CAMADAS.BLL.RoteadorRede bllRoteadorRede = new CAMADAS.BLL.RoteadorRede();

            if (lblOperacaoID.Text == "-1")
            {
                //CAMADAS.DAL.RoteadorRede dalRoteadorRede = new CAMADAS.DAL.RoteadorRede();
                CAMADAS.BLL.Rede bllRede = new CAMADAS.BLL.Rede();
                List<CAMADAS.MODEL.Rede> listaRede = bllRede.SelectByID(roteadorRede.redeID);
                CAMADAS.MODEL.Rede rede = listaRede[0];

                if (rede.situacao == 1)
                {
                    bllRoteadorRede.Insert(roteadorRede);
                    limpaCampos();
                }
                else
                {
                    string mensagem = "Rede já em uso";
                    MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                roteadorRede.id = Convert.ToInt32(lblOperacaoID.Text);
                bllRoteadorRede.Update(roteadorRede);
            }

            dtgRoteadorRede.DataSource = bllRoteadorRede.Select();
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            dtpDataFinal.Enabled = true;

            CAMADAS.MODEL.RoteadorRede roteadorRede = new CAMADAS.MODEL.RoteadorRede();

            roteadorRede.id = Convert.ToInt32((lblOperacaoID.Text).ToString());
            roteadorRede.roteadorID = Convert.ToInt32((txtRoteadorID.Text).ToString());
            roteadorRede.redeID = Convert.ToInt32((txtRedeID.Text).ToString());
            roteadorRede.dataInicio = Convert.ToDateTime(dtpData.Text);
            roteadorRede.dataFim = Convert.ToDateTime(dtpDataFinal.Text);

            CAMADAS.DAL.RoteadorRede dalRoteadorRede = new CAMADAS.DAL.RoteadorRede();

            CAMADAS.BLL.Rede bllRede = new CAMADAS.BLL.Rede();

            List<CAMADAS.MODEL.Rede> listaRede = bllRede.SelectByID(roteadorRede.redeID);
            CAMADAS.MODEL.Rede rede = listaRede[0];

            CAMADAS.BLL.RoteadorRede bllRoteadorRede = new CAMADAS.BLL.RoteadorRede();
            if ((lblOperacaoID.Text != "-1") && (rede.situacao == 2))
            {
                bllRoteadorRede.Devolver(roteadorRede);

                string mensagem = "Rede Devolvido!";
                string tituloMensagem = "Devolver";

                DialogResult resposta = MessageBox.Show(mensagem, tituloMensagem, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string mensagem = "Rede não está disponível para Entrega!";
                string tituloMensagem = "Devolver";

                DialogResult resposta = MessageBox.Show(mensagem, tituloMensagem, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            dtgRoteadorRede.DataSource = bllRoteadorRede.Select();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaCampos();
            habilitaCampos(false);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            gpbFiltrar.Visible = !gpbFiltrar.Visible;
            rdbID.Enabled = false;
            rdbNome.Enabled = false;
            rdbIP.Enabled = false;
            txtPesquisar.Enabled = false;
            btnPesquisarImagem.Enabled = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dtgRoteadorRede_DoubleClick(object sender, EventArgs e)
        {
            lblOperacaoID.Text = dtgRoteadorRede.SelectedRows[0].Cells["id_RoteadorRede"].Value.ToString();
            cmbRoteador.SelectedValue = Convert.ToInt32(dtgRoteadorRede.SelectedRows[0].Cells["roteadorID"].Value.ToString());
            txtRoteadorID.Text = dtgRoteadorRede.SelectedRows[0].Cells["roteadorID"].Value.ToString();
            cmbRede.SelectedValue = Convert.ToInt32(dtgRoteadorRede.SelectedRows[0].Cells["redeID"].Value.ToString());
            txtRedeID.Text = dtgRoteadorRede.SelectedRows[0].Cells["redeID"].Value.ToString();
            dtpData.Value = Convert.ToDateTime(dtgRoteadorRede.SelectedRows[0].Cells["dataInicio"].Value.ToString());
            dtpDataFinal.Value = Convert.ToDateTime(dtgRoteadorRede.SelectedRows[0].Cells["dataFim"].Value.ToString());

            habilitaBotoes(false);

            if (dtpDataFinal.Value == Convert.ToDateTime("01/01/1900"))
            {
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
            if (cmbSelecao.SelectedItem != null)
            {
                if(cmbSelecao.SelectedItem == "Rede")
                {
                    rdbIP.Enabled = true;
                    rdbNome.Enabled = false;
                }
                else
                {
                    rdbNome.Enabled = true;
                    rdbIP.Enabled = false;
                }
                rdbID.Enabled = true;
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

        private void rdbIP_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisar.Enabled = true;
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisar.Text != "")
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
                if (cmbSelecao.SelectedItem.ToString() == "Rede")
                {
                    CAMADAS.BLL.Rede bllRede = new CAMADAS.BLL.Rede();
                    if (rdbID.Checked)
                    {
                        int idRede = Convert.ToInt32(txtPesquisar.Text);
                        dtgRede.DataSource = bllRede.SelectByID(idRede);
                    }
                    else if (rdbIP.Checked)
                    {
                        string ipRede = txtPesquisar.Text;
                        dtgRede.DataSource = bllRede.SelectByIP(ipRede);
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
            CAMADAS.BLL.Rede bllRede = new CAMADAS.BLL.Rede();
            CAMADAS.BLL.Roteador bllRoteador = new CAMADAS.BLL.Roteador();

            if (cmbSelecao.SelectedItem.ToString() == "Rede")
            {
                dtgRede.DataSource = bllRede.Select();
            }
            else if (cmbSelecao.SelectedItem.ToString() == "Roteador")
            {
                dtgRoteador.DataSource = bllRoteador.Select();
            }
            else if (cmbSelecao.SelectedItem.ToString() == "Geral")
            {
                dtgRede.DataSource = bllRede.Select();
                dtgRoteador.DataSource = bllRoteador.Select();
                rdbID.Enabled = false;
                rdbNome.Enabled = false;
                rdbIP.Enabled = false;
            }
        }

        
    }
}
