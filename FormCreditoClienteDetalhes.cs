using System.Windows.Forms;

namespace CreditoCliente
{
    public partial class FormCreditoClienteDetalhes : Form
    {
        public FormCreditoClienteDetalhes()
        {
            InitializeComponent();
        }

        private void buttonIncluir_Click(object sender, System.EventArgs e)
        {
            Form formIncluirCredito = new FormIncluirCredito();
            formIncluirCredito.ShowDialog();
        }

        private void buttonExcluir_Click(object sender, System.EventArgs e)
        {
            Form formERP_Login = new FormERP_Login();
            formERP_Login.ShowDialog();
        }

        private void buttonTransferir_Click(object sender, System.EventArgs e)
        {
            Form formTransferir = new FormTransferir();
            formTransferir.ShowDialog();
        }

        private void button7_Click(object sender, System.EventArgs e)
        {
            Form formOBS_CreditoCliente = new FormOBS_CreditoCliente();
            formOBS_CreditoCliente.ShowDialog();
        }
    }
}
