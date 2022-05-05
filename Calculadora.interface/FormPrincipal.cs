namespace Calculadora.Interface
{
    public partial class FormPrincipal : Form
    {
        private decimal ValorCalcular;
        private bool EhSoma, EhMultiplicacao, EhDivisao, EhSubtracao;

        private void BtnMenos_Click(object sender, EventArgs e)
        {

        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            if (EhSoma)
            {
                decimal ValorTotal = ValorCalcular + decimal.Parse(TxtValorCalcular.Text);

                LblValorCalcular.Text = $"{LblValorCalcular.Text} {TxtValorCalcular.Text} =";

                TxtValorCalcular.Text = ValorTotal.ToString();

            }
        }
            public FormPrincipal()
            {
                InitializeComponent();
            }

            private void BtnMais_Click(object sender, EventArgs e)
            {
                EhSoma = true;
                ValorCalcular = Decimal.Parse(TxtValorCalcular.Text);

                LblValorCalcular.Text = $"{ValorCalcular} +";
            }
        }
    }
