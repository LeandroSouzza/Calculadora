namespace Calculadora.Interface
{
    public partial class FormPrincipal : Form
    {
        private decimal ValorCalcular;
        private bool EhSoma, EhMultiplicacao, EhDivisao, EhSubtracao;

        private void BtnMenos_Click(object sender, EventArgs e)
        {
            EhSubtracao = true;
            ValorCalcular = Decimal.Parse(TxtValorCalcular.Text);

            LblValorCalcular.Text = $"{ValorCalcular} -";
        }

        private void BtnVezez_Click(object sender, EventArgs e)
        {
            EhMultiplicacao = true;
            ValorCalcular = Decimal.Parse(TxtValorCalcular.Text);

            LblValorCalcular.Text = $"{ValorCalcular} *";
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            EhDivisao = true;
            ValorCalcular = Decimal.Parse(TxtValorCalcular.Text);

            LblValorCalcular.Text = $"{ValorCalcular} /";
        }

        private void Btn0_Click(object sender, EventArgs e)
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
            else if (EhSubtracao)
            {

                decimal ValorTotal = ValorCalcular - decimal.Parse(TxtValorCalcular.Text);

                LblValorCalcular.Text = $"{LblValorCalcular.Text} {TxtValorCalcular.Text} =";

                TxtValorCalcular.Text = ValorTotal.ToString();

            }
            else if (EhMultiplicacao)
            {

                decimal ValorTotal = ValorCalcular * decimal.Parse(TxtValorCalcular.Text);

                LblValorCalcular.Text = $"{LblValorCalcular.Text} {TxtValorCalcular.Text} =";

                TxtValorCalcular.Text = ValorTotal.ToString();

            }
            else if (EhDivisao)
                    {
                decimal ValorTotal = ValorCalcular / decimal.Parse(TxtValorCalcular.Text);

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
