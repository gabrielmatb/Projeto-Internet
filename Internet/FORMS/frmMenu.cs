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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes formClientes = new frmClientes();
            formClientes.MdiParent = this;
            formClientes.Show();
        }

        private void roteadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRoteador formRoteador = new frmRoteador();
            formRoteador.MdiParent = this;
            formRoteador.Show();
        }

        private void redeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRede formRede = new frmRede();
            formRede.MdiParent = this;
            formRede.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre formSobre = new frmSobre();
            formSobre.MdiParent = this;
            formSobre.Show();
        }

        private void clienteRoteadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClienteRoteador formClienteRoteador = new frmClienteRoteador();
            formClienteRoteador.MdiParent = this;
            formClienteRoteador.Show();
        }

        private void clienteRoteadorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RELATORIOS.relatorioClienteRoteador.relClienteRoteador();
        }
    }
}
