namespace Calculadora.Interface
{
    public partial class FormPrincipal : Form
    {
        private decimal ValorCalcular;
        private bool EhSoma, EhMultiplicacao, EhDivisao, EhSubtracao, EhPercentual;


        private void BtnMenos_Click(object sender, EventArgs e)
        {
            LimparOperacoes();

            EhSubtracao = true;

            if (TxtValorCalcular.Text != "")
                ValorCalcular = Decimal.Parse(TxtValorCalcular.Text);
            TxtValorCalcular.Text = "";
            LblValorCalcular.Text = $"{ValorCalcular} -";
        }

        private void LimparOperacoes()
        {
            EhSoma = false;
            EhDivisao = false;
            EhMultiplicacao = false;
            EhSubtracao = false;
            EhPercentual = false;
        }

        private void BtnVezez_Click(object sender, EventArgs e)

        {
            LimparOperacoes();

            EhMultiplicacao = true;

            if (TxtValorCalcular.Text != "")
                ValorCalcular = Decimal.Parse(TxtValorCalcular.Text);
            TxtValorCalcular.Text = "";
            LblValorCalcular.Text = $"{ValorCalcular} *";
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            LimparOperacoes();

            EhDivisao = true;

            if (TxtValorCalcular.Text != "")
                ValorCalcular = Decimal.Parse(TxtValorCalcular.Text);
            TxtValorCalcular.Text = "";
            LblValorCalcular.Text = $"{ValorCalcular} /";
        }

        private void BtnMais_Click(object sender, EventArgs e)
        {
            LimparOperacoes();

            EhSoma = true;

            if (TxtValorCalcular.Text != "")
                ValorCalcular = Decimal.Parse(TxtValorCalcular.Text);
            TxtValorCalcular.Text = "";
            LblValorCalcular.Text = $"{ValorCalcular} +";
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

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtValorCalcular.Text = "";
            TxtValorCalcular.Text = "0";
        }


        private void button2_Click(object sender, EventArgs e)
        {
            TxtValorCalcular.Text = "";
            TxtValorCalcular.Text = "0";
            LblValorCalcular.Text = "";
        }

        private void BtnVírgula_Click(object sender, EventArgs e)
        {
            if (TxtValorCalcular.Text != "")
                if (!TxtValorCalcular.Text.Contains(","))
                    TxtValorCalcular.Text += ",";
        }

        private void BtnApagar_Click(object sender, EventArgs e)
        {
            LimparOperacoes();
            try
            {
                string Apagar = TxtValorCalcular.Text;
                Apagar = Apagar.Remove(Apagar.Length - 1);
                TxtValorCalcular.Text = Apagar;
            }
            catch (Exception ex)
            {
                TxtValorCalcular.Text = TxtValorCalcular.Text = "";
            }


        }

        private void TxtValorCalcular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
            {

            }
        }

        private void TxtValorCalcular_KeyDown(object sender, KeyEventArgs e)
        {
        }


        private void FormPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {

                LblValorCalcular.Text = Convert.ToString(e.KeyValue);
                if (e.KeyValue == 107)
                {
                    LblValorCalcular.Text = "+";
                }
                if (e.KeyValue == 109)
                {
                    LblValorCalcular.Text = "-";
                }
                if (e.KeyValue == 106)
                {
                    LblValorCalcular.Text = "*";
                }
                if (e.KeyValue == 111)
                {
                    LblValorCalcular.Text = "/";
                }
                if (e.KeyValue == 98)
                {
                    LblValorCalcular.Text = "2";
                }
                if (e.KeyValue == 99)
                {
                    LblValorCalcular.Text = "3";
                }
                if (e.KeyValue == 8)

                    LimparOperacoes();
                string Apagar = TxtValorCalcular.Text;
                Apagar = Apagar.Remove(Apagar.Length - 1);
                TxtValorCalcular.Text = Apagar;
            }
            catch (Exception ex)
            {
                LblValorCalcular.Text = "";
            }
        }

        private void TxtValorCalcular_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblValorCalcular_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            LimparOperacoes();

            EhPercentual = true;

            if (TxtValorCalcular.Text != "")
                ValorCalcular = Decimal.Parse(TxtValorCalcular.Text);
            TxtValorCalcular.Text = "";
            LblValorCalcular.Text = $"{ValorCalcular} %";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            TxtValorCalcular.Text += "9";
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            if (TxtValorCalcular.Text != "")

                if (EhSoma)
                {
                    decimal ValorTotal = ValorCalcular + decimal.Parse(TxtValorCalcular.Text);

                    LblValorCalcular.Text = $"{LblValorCalcular.Text} {LblValorCalcular.Text} =";

                    TxtValorCalcular.Text = ValorTotal.ToString();
                }
                else if (EhPercentual)
                {
                    decimal ValorTotal = ValorCalcular * decimal.Parse(TxtValorCalcular.Text) / 100;

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
    }
}
