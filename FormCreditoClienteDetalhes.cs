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
            FormIncluirCredito formIncluirCredito = new FormIncluirCredito();
            formIncluirCredito.ShowDialog();
        }
    }
}
