namespace Calculadora // Define o namespace (espaço de nomes) para organizar o código
{
    public partial class Calculadora : Form // Declara a classe Calculadora que herda de Form (janela do Windows Forms)
    {
        public Calculadora() // Construtor da classe
        {
            InitializeComponent(); // Inicializa todos os componentes visuais definidos no Designer
        }

        private void btnSomar_Click(object sender, EventArgs e) // Evento disparado quando o botão Somar é clicado
        {
            // Verifica se os campos estão vazios ou só com espaços
            if (string.IsNullOrWhiteSpace(txtNumero1.Text) || string.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                MessageBox.Show("O campo está vazio ou só tem espaços!"); // Mostra mensagem de erro
                return; // Encerra o método (não prossegue com cálculo)
            }

            // Tenta converter o texto do primeiro campo em número
            if (!double.TryParse(txtNumero1.Text, out double numero1))
            {
                MessageBox.Show("O primeiro valor não é um número válido!"); // Mostra erro se conversão falhar
                return; // Encerra o método
            }

            // Tenta converter o texto do segundo campo em número
            if (!double.TryParse(txtNumero2.Text, out double numero2))
            {
                MessageBox.Show("O segundo valor não é um número válido!"); // Mostra erro se conversão falhar
                return; // Encerra o método
            }

            // Faz a soma e exibe o resultado no label
            lblResultado.Text = (numero1 + numero2).ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e) // Evento do botão Subtrair
        {
            // Converte e valida o primeiro número
            if (!double.TryParse(txtNumero1.Text, out double numero1))
            {
                MessageBox.Show("O primeiro valor não é um número válido!");
                return;
            }

            // Converte e valida o segundo número
            if (!double.TryParse(txtNumero2.Text, out double numero2))
            {
                MessageBox.Show("O segundo valor não é um número válido!");
                return;
            }

            // Faz a subtração e exibe o resultado
            lblResultado.Text = (numero1 - numero2).ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e) // Evento do botão Multiplicar
        {
            // Converte e valida o primeiro número
            if (!double.TryParse(txtNumero1.Text, out double numero1))
            {
                MessageBox.Show("O primeiro valor não é um número válido!");
                return;
            }

            // Converte e valida o segundo número
            if (!double.TryParse(txtNumero2.Text, out double numero2))
            {
                MessageBox.Show("O segundo valor não é um número válido!");
                return;
            }

            // Faz a multiplicação e exibe o resultado
            lblResultado.Text = (numero1 * numero2).ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e) // Evento do botão Dividir
        {
            // Converte e valida o primeiro número
            if (!double.TryParse(txtNumero1.Text, out double numero1))
            {
                MessageBox.Show("O primeiro valor não é um número válido!");
                return;
            }

            // Converte e valida o segundo número
            if (!double.TryParse(txtNumero2.Text, out double numero2))
            {
                MessageBox.Show("O segundo valor não é um número válido!");
                return;
            }

            // Verifica divisão por zero
            if (numero2 == 0)
            {
                MessageBox.Show("Não é possível dividir por zero!");
                return;
            }

            // Faz a divisão e exibe o resultado
            lblResultado.Text = (numero1 / numero2).ToString();
        }
    }
}
