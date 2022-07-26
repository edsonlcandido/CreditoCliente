using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CreditoCliente
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            toolStripStatusLabelVersao.Text = Application.ProductVersion.ToString();
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formCreditoCliente = new FormCreditoCliente();
            formCreditoCliente.ShowDialog();
        }
    }
}
