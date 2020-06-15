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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            CAMADAS.BLL.Clientes bllClientes = new CAMADAS.BLL.Clientes();
            //dtgClientes.DataSource = "";
            dtgClientes.DataSource = bllClientes.Select();
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
            txtCPF.Text = "";
            txtTelefone.Text = "";
            txtIdade.Text = "";
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            txtID.Text = "-1";
            string mensagem = "Deseja Inserir novo Cliente?";
            string tituloMensagem = "Inserir";

            DialogResult resposta = MessageBox.Show(mensagem, tituloMensagem, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (resposta == DialogResult.Yes)
            {
                CAMADAS.MODEL.Clientes cliente = new CAMADAS.MODEL.Clientes();

                cliente.nome = txtNome.Text;
                cliente.cpf = txtCPF.Text;
                cliente.telefone = txtTelefone.Text;
                cliente.idade = Convert.ToInt32(txtIdade.Text);

                CAMADAS.BLL.Clientes bllClientes = new CAMADAS.BLL.Clientes();
                bllClientes.Insert(cliente);

                //dtgClientes.DataSource = "";
                dtgClientes.DataSource = bllClientes.Select();
                limpaControles();
            }
            else
                limpaControles();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(txtID.Text != "")
            {
                string mensagem = "Deseja Editar o Cliente?";
                string tituloMensagem = "Editar";

                DialogResult resposta = MessageBox.Show(mensagem, tituloMensagem, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (resposta == DialogResult.Yes)
                {
                    CAMADAS.MODEL.Clientes cliente = new CAMADAS.MODEL.Clientes();

                    cliente.id = Convert.ToInt32(txtID.Text);
                    cliente.nome = txtNome.Text;
                    cliente.cpf = txtCPF.Text;
                    cliente.telefone = txtTelefone.Text;
                    cliente.idade = Convert.ToInt32(txtIdade.Text);

                    CAMADAS.BLL.Clientes bllClientes = new CAMADAS.BLL.Clientes();
                    bllClientes.Update(cliente);

                    //dtgClientes.DataSource = "";
                    dtgClientes.DataSource = bllClientes.Select();
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
                string mensagem = "Deseja Remover o Cliente?";
                string tituloMensagem = "Remover";

                DialogResult resposta = MessageBox.Show(mensagem, tituloMensagem, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (resposta == DialogResult.Yes)
                {
                    int idCliente = Convert.ToInt32(txtID.Text);

                    CAMADAS.BLL.Clientes bllClientes = new CAMADAS.BLL.Clientes();
                    bllClientes.Delete(idCliente);

                    //dtgClientes.DataSource = "";
                    dtgClientes.DataSource = bllClientes.Select();
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

        private void dtgClientes_DoubleClick(object sender, EventArgs e)
        {
            txtID.Text = dtgClientes.SelectedRows[0].Cells["id"].Value.ToString();
            txtNome.Text = dtgClientes.SelectedRows[0].Cells["nome"].Value.ToString();
            txtCPF.Text = dtgClientes.SelectedRows[0].Cells["cpf"].Value.ToString();
            txtTelefone.Text = dtgClientes.SelectedRows[0].Cells["telefone"].Value.ToString();
            txtIdade.Text = dtgClientes.SelectedRows[0].Cells["idade"].Value.ToString();
            habilitaControles(false);
        }
    }
}
