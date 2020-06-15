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
    public partial class frmRede : Form
    {
        public frmRede()
        {
            InitializeComponent();
        }

        private void frmRede_Load(object sender, EventArgs e)
        {
            CAMADAS.BLL.Rede bllRede = new CAMADAS.BLL.Rede();
            dtgRede.DataSource = bllRede.Select();
            txtID.Enabled = false;
            habilitaControles(true);
        }

        private void habilitaControles(bool status)
        {
            btnInserir.Enabled = status;
            btnEditar.Enabled = !status;
            btnRemover.Enabled = !status;
        }

        private void limpaControles()
        {
            txtID.Text = "";
            txtIP.Text = "";
            txtGateway.Text = "";
            txtMascara.Text = "";
            txtValor.Text = "";
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            txtID.Text = "-1";
            string mensagem = "Deseja Inserir nova Rede?";
            string tituloMensagem = "Inserir";

            DialogResult resposta = MessageBox.Show(mensagem, tituloMensagem, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if(resposta == DialogResult.Yes)
            {
                CAMADAS.MODEL.Rede rede = new CAMADAS.MODEL.Rede();

                rede.id = Convert.ToInt32(txtID.Text);
                rede.ip = txtIP.Text;
                rede.gateway = txtGateway.Text;
                rede.mascara = txtMascara.Text;
                rede.valor = Convert.ToSingle(txtValor.Text);

                CAMADAS.BLL.Rede bllRede = new CAMADAS.BLL.Rede();
                bllRede.Insert(rede);

                dtgRede.DataSource = bllRede.Select();
                limpaControles();
            }
            else
                limpaControles();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(txtID.Text != "")
            {
                string mensagem = "Deseja Editar a Rede?";
                string tituloMensagem = "Editar";

                DialogResult resposta = MessageBox.Show(mensagem, tituloMensagem, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (resposta == DialogResult.Yes)
                {
                    CAMADAS.MODEL.Rede rede = new CAMADAS.MODEL.Rede();

                    rede.id = Convert.ToInt32(txtID.Text);
                    rede.ip = txtIP.Text;
                    rede.gateway = txtGateway.Text;
                    rede.mascara = txtMascara.Text;
                    rede.valor = Convert.ToSingle(txtValor.Text);

                    CAMADAS.BLL.Rede bllRede = new CAMADAS.BLL.Rede();
                    bllRede.Update(rede);

                    dtgRede.DataSource = bllRede.Select();
                    limpaControles();
                }
                else
                    limpaControles();
            }
            else
            {
                string mensagem = "Não há Dados para Editar!";
                string tituloMensagem = "Editar";

                DialogResult resposta = MessageBox.Show(mensagem, tituloMensagem, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if(txtID.Text != "")
            {
                string mensagem = "Deseja Remover a Rede?";
                string tituloMensagem = "Remover";

                DialogResult resposta = MessageBox.Show(mensagem, tituloMensagem, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (resposta == DialogResult.Yes)
                {
                    int idRede = Convert.ToInt32(txtID.Text);

                    CAMADAS.DAL.Rede dalRede = new CAMADAS.DAL.Rede();
                    dalRede.Delete(idRede);

                    dtgRede.DataSource = dalRede.Select();
                    limpaControles();
                }
                else
                    limpaControles();
            }
            else
            {
                string mensagem = "Não há Dados para Remover!";
                string tituloMensagem = "Remover";

                DialogResult resposta = MessageBox.Show(mensagem, tituloMensagem, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaControles();
            habilitaControles(true);
            txtIP.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgRede_DoubleClick(object sender, EventArgs e)
        {
            txtID.Text = dtgRede.SelectedRows[0].Cells["id"].Value.ToString();
            txtIP.Text = dtgRede.SelectedRows[0].Cells["ip"].Value.ToString();
            txtGateway.Text = dtgRede.SelectedRows[0].Cells["gateway"].Value.ToString();
            txtMascara.Text = dtgRede.SelectedRows[0].Cells["mascara"].Value.ToString();
            txtValor.Text = dtgRede.SelectedRows[0].Cells["valor"].Value.ToString();

            habilitaControles(false);
        }
    }
}
