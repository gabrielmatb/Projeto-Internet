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
    public partial class frmRoteador : Form
    {
        public frmRoteador()
        {
            InitializeComponent();
        }

        private void frmRoteador_Load(object sender, EventArgs e)
        {
            CAMADAS.BLL.Roteador bllRoteador = new CAMADAS.BLL.Roteador();
            dtgRoteador.DataSource = bllRoteador.Select();
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
            txtNome.Text = "";
            txtMarca.Text = "";
            txtUsuario.Text = "";
            txtSenha.Text = "";
            txtMac.Text = "";
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            txtID.Text = "-1";
            string mensagem = "Deseja Inserir novo Roteador?";
            string tituloMensagem = "Inserir";

            DialogResult resposta = MessageBox.Show(mensagem, tituloMensagem, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (resposta == DialogResult.Yes)
            {
                CAMADAS.MODEL.Roteador roteador = new CAMADAS.MODEL.Roteador();

                roteador.nome = txtNome.Text;
                roteador.marca = txtMarca.Text;
                roteador.usuario = txtUsuario.Text;
                roteador.senha = txtSenha.Text;
                roteador.mac = txtMac.Text;

                CAMADAS.BLL.Roteador bllRoteador = new CAMADAS.BLL.Roteador();
                bllRoteador.Insert(roteador);

                dtgRoteador.DataSource = bllRoteador.Select();
                limpaControles();
            }
            else
                limpaControles();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(txtID.Text != "")
            {
                string mensagem = "Deseja Editar o Roteador?";
                string tituloMensagem = "Editar";

                DialogResult resposta = MessageBox.Show(mensagem, tituloMensagem, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (resposta == DialogResult.Yes)
                {
                    CAMADAS.MODEL.Roteador roteador = new CAMADAS.MODEL.Roteador();

                    roteador.id = Convert.ToInt32(txtID.Text);
                    roteador.nome = txtNome.Text;
                    roteador.marca = txtMarca.Text;
                    roteador.usuario = txtUsuario.Text;
                    roteador.senha = txtSenha.Text;
                    roteador.mac = txtMac.Text;

                    CAMADAS.BLL.Roteador bllRoteador = new CAMADAS.BLL.Roteador();
                    bllRoteador.Update(roteador);

                    dtgRoteador.DataSource = bllRoteador.Select();
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
                string mensagem = "Deseja Remover o Roteador?";
                string tituloMensagem = "Remover";

                DialogResult resposta = MessageBox.Show(mensagem, tituloMensagem, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (resposta == DialogResult.Yes)
                {
                    int idRoteador = Convert.ToInt32(txtID.Text);

                    CAMADAS.BLL.Roteador bllRoteador = new CAMADAS.BLL.Roteador();
                    bllRoteador.Delete(idRoteador);

                    dtgRoteador.DataSource = bllRoteador.Select();
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
            txtNome.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgRoteador_DoubleClick(object sender, EventArgs e)
        {
            txtID.Text = dtgRoteador.SelectedRows[0].Cells["id"].Value.ToString();
            txtNome.Text = dtgRoteador.SelectedRows[0].Cells["nome"].Value.ToString();
            txtMarca.Text = dtgRoteador.SelectedRows[0].Cells["marca"].Value.ToString();
            txtUsuario.Text = dtgRoteador.SelectedRows[0].Cells["usuario"].Value.ToString();
            txtSenha.Text = dtgRoteador.SelectedRows[0].Cells["senha"].Value.ToString();
            txtMac.Text = dtgRoteador.SelectedRows[0].Cells["mac"].Value.ToString();
  
            habilitaControles(false);
        }
    }
}
