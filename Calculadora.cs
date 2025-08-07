namespace Calculadora // Define o namespace (espa�o de nomes) para organizar o c�digo
{
    public partial class Calculadora : Form // Declara a classe Calculadora que herda de Form (janela do Windows Forms)
    {
        public Calculadora() // Construtor da classe
        {
            InitializeComponent(); // Inicializa todos os componentes visuais definidos no Designer
        }

        private void btnSomar_Click(object sender, EventArgs e) // Evento disparado quando o bot�o Somar � clicado
        {
            // Verifica se os campos est�o vazios ou s� com espa�os
            if (string.IsNullOrWhiteSpace(txtNumero1.Text) || string.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                MessageBox.Show("O campo est� vazio ou s� tem espa�os!"); // Mostra mensagem de erro
                return; // Encerra o m�todo (n�o prossegue com c�lculo)
            }

            // Tenta converter o texto do primeiro campo em n�mero
            if (!double.TryParse(txtNumero1.Text, out double numero1))
            {
                MessageBox.Show("O primeiro valor n�o � um n�mero v�lido!"); // Mostra erro se convers�o falhar
                return; // Encerra o m�todo
            }

            // Tenta converter o texto do segundo campo em n�mero
            if (!double.TryParse(txtNumero2.Text, out double numero2))
            {
                MessageBox.Show("O segundo valor n�o � um n�mero v�lido!"); // Mostra erro se convers�o falhar
                return; // Encerra o m�todo
            }

            // Faz a soma e exibe o resultado no label
            lblResultado.Text = (numero1 + numero2).ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e) // Evento do bot�o Subtrair
        {
            // Converte e valida o primeiro n�mero
            if (!double.TryParse(txtNumero1.Text, out double numero1))
            {
                MessageBox.Show("O primeiro valor n�o � um n�mero v�lido!");
                return;
            }

            // Converte e valida o segundo n�mero
            if (!double.TryParse(txtNumero2.Text, out double numero2))
            {
                MessageBox.Show("O segundo valor n�o � um n�mero v�lido!");
                return;
            }

            // Faz a subtra��o e exibe o resultado
            lblResultado.Text = (numero1 - numero2).ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e) // Evento do bot�o Multiplicar
        {
            // Converte e valida o primeiro n�mero
            if (!double.TryParse(txtNumero1.Text, out double numero1))
            {
                MessageBox.Show("O primeiro valor n�o � um n�mero v�lido!");
                return;
            }

            // Converte e valida o segundo n�mero
            if (!double.TryParse(txtNumero2.Text, out double numero2))
            {
                MessageBox.Show("O segundo valor n�o � um n�mero v�lido!");
                return;
            }

            // Faz a multiplica��o e exibe o resultado
            lblResultado.Text = (numero1 * numero2).ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e) // Evento do bot�o Dividir
        {
            // Converte e valida o primeiro n�mero
            if (!double.TryParse(txtNumero1.Text, out double numero1))
            {
                MessageBox.Show("O primeiro valor n�o � um n�mero v�lido!");
                return;
            }

            // Converte e valida o segundo n�mero
            if (!double.TryParse(txtNumero2.Text, out double numero2))
            {
                MessageBox.Show("O segundo valor n�o � um n�mero v�lido!");
                return;
            }

            // Verifica divis�o por zero
            if (numero2 == 0)
            {
                MessageBox.Show("N�o � poss�vel dividir por zero!");
                return;
            }

            // Faz a divis�o e exibe o resultado
            lblResultado.Text = (numero1 / numero2).ToString();
        }
    }
}
