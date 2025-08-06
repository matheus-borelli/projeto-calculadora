namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            // Verifica se os campos de entrada estão preenchidos
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);

            // Realiza a soma dos números e exibe o resultado
            lblResultado.Text = (numero1 + numero2).ToString();

        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);

            lblResultado.Text = (numero1 - numero2).ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);

            lblResultado.Text = (numero1 * numero2).ToString();

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);

            lblResultado.Text = (numero1 / numero2).ToString();
        }
    }
}
