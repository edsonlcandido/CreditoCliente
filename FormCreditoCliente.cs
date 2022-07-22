using System.Windows.Forms;

namespace CreditoCliente
{
    public partial class FormCreditoCliente : Form
    {
        public FormCreditoCliente()
        {
            InitializeComponent();
        }

        private void buttonOpenCreditoCliente_Click(object sender, System.EventArgs e)
        {
            FormCreditoClienteDetalhes formCreditoClienteDetalhes = new FormCreditoClienteDetalhes();
            formCreditoClienteDetalhes.MdiParent = this;
            formCreditoClienteDetalhes.Width = this.DisplayRectangle.Width-5;
            formCreditoClienteDetalhes.Height = this.DisplayRectangle.Height-125;
            formCreditoClienteDetalhes.Location = new System.Drawing.Point(0,0);
            formCreditoClienteDetalhes.Show();
        }

        private void buttonCloseCreditoCliente_Click(object sender, System.EventArgs e)
        {
            if (this.MdiChildren.Length>0)
            {
                Form formCreditoClienteDetalhes = this.ActiveMdiChild;
                formCreditoClienteDetalhes.Close();
            }
            
        }
    }
}
