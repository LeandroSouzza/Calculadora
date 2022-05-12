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
            TxtValorCalcular.Text += "0";
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            TxtValorCalcular.Text += "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            TxtValorCalcular.Text += "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            TxtValorCalcular.Text += "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            TxtValorCalcular.Text += "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            TxtValorCalcular.Text += "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            TxtValorCalcular.Text += "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            TxtValorCalcular.Text += "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            TxtValorCalcular.Text += "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            TxtValorCalcular.Text += "9";
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
