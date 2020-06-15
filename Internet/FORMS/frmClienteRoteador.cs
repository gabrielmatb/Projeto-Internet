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

            //CAMADAS.BLL.Clientes bllCliente = new CAMADAS.BLL.Clientes();
            dtgCliente.DataSource = "";
            dtgCliente.DataSource = bllClientes.Select();

            CAMADAS.BLL.Roteador bllRoteador = new CAMADAS.BLL.Roteador();
            cmbRoteador.DisplayMember = "nome";
            cmbRoteador.ValueMember = "id";
            cmbRoteador.DataSource = bllRoteador.Select();

            dtgRoteador.DataSource = "";
            dtgRoteador.DataSource = bllRoteador.Select();

            habilitaControles(false);
            limpaCampos();
            gpbFiltrar.Visible = false;
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

        private void habilitaControles(bool status)
        {
            txtRoteadorID.Enabled = !status;
            cmbRoteador.Enabled = !status;
            dtpDataFinal.Enabled = false;
            btnCancelar.Enabled = status;
            btnGravar.Enabled = status;
        }

        /*private void verificaRoteador()
        {
            int idRoteador = Convert.ToInt32(txtRoteadorID.Text);
            CAMADAS.BLL.Roteador bllRoteador = new CAMADAS.BLL.Roteador();
            List<CAMADAS.MODEL.Roteador> listaRoteador = bllRoteador.SelectByID(idRoteador);
            if(listaRoteador.Count > 0)
            {
                CAMADAS.MODEL.Roteador roteador = listaRoteador[0];
                if(roteador.situacao == 2)
                {
                    MessageBox.Show("Roteador " + roteador.nome.Trim() + " já está emprestado!!!");
                    cmbRoteador.Focus();
                }
            }
        }*/

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
                //verificaRoteador();
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

        //botoes
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            gpbFiltrar.Visible = !gpbFiltrar.Visible;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }        
    }
}
