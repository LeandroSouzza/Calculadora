namespace Calculadora.Interface
{
    public partial class FormPrincipal : Form
    {
        double Num1 = 0, Num2 = 0;
        char Operacao;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void clickOperacao(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            Num1 = Convert.ToDouble(TxtValorCalcular.Text);
            Operacao = Convert.ToChar(boton.Text);

            LblValorCalcular.Text += boton.Text;
            TxtValorCalcular.Text = "";
        }


        private void agregarNumero(object sender, EventArgs e)
        {
            var button = ((Button)sender);

            if (TxtValorCalcular.Text == "0")
                TxtValorCalcular.Text = "";

            TxtValorCalcular.Text += button.Text;
            LblValorCalcular.Text += button.Text;
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
                    LblValorCalcular.Text += ",";
        }

        private void BtnApagar_Click(object sender, EventArgs e)
        {
            try
            {
                string Apagar = TxtValorCalcular.Text;
                Apagar = Apagar.Remove(Apagar.Length - 1);
                TxtValorCalcular.Text = Apagar;
            }
            catch (Exception ex)
            {
                TxtValorCalcular.Text = TxtValorCalcular.Text = "0";
            }
        }

        //Textbox aceitar só números//
        private void TxtValorCalcular_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.DecNumber(sender, e);
        }

        private void FormPrincipal_KeyDown(object sender, KeyEventArgs e)
        {/*
            try
            {
                TxtTeclado.Text = Convert.ToString(e.KeyValue);
                if (e.KeyValue == 107)
                {
                    LblValorCalcular.Text = "+";

                    LimparOperacoes();

                    EhSoma = true;

                    if (TxtValorCalcular.Text != "")
                        ValorCalcular = Decimal.Parse(TxtValorCalcular.Text);
                    TxtValorCalcular.Text = "";
                    LblValorCalcular.Text = $"{ValorCalcular} +";
                }
                if (e.KeyValue == 109)
                {
                    LblValorCalcular.Text = "-";

                    LimparOperacoes();

                    EhSubtracao = true;

                    if (TxtValorCalcular.Text != "")
                        ValorCalcular = Decimal.Parse(TxtValorCalcular.Text);
                    TxtValorCalcular.Text = "";
                    LblValorCalcular.Text = $"{ValorCalcular} -";
                }
                if (e.KeyValue == 106)
                {
                    LblValorCalcular.Text = "*";

                    LimparOperacoes();

                    EhMultiplicacao = true;

                    if (TxtValorCalcular.Text != "")
                        ValorCalcular = Decimal.Parse(TxtValorCalcular.Text);
                    TxtValorCalcular.Text = "";
                    LblValorCalcular.Text = $"{ValorCalcular} *";
                }
                if (e.KeyValue == 111)
                {
                    LblValorCalcular.Text = "/";

                    LimparOperacoes();

                    EhDivisao = true;

                    if (TxtValorCalcular.Text != "")
                        ValorCalcular = Decimal.Parse(TxtValorCalcular.Text);
                    TxtValorCalcular.Text = "";
                    LblValorCalcular.Text = $"{ValorCalcular} /";
                }
                if (e.KeyValue == 13)
                {
                    if (TxtValorCalcular.Text != "")

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

                if (e.KeyValue == 8)
                {
                    LimparOperacoes();
                    string Apagar = TxtValorCalcular.Text;
                    Apagar = Apagar.Remove(Apagar.Length - 1);
                    TxtValorCalcular.Text = Apagar;
                }
            }
            catch
            {
            }*/
        }

        private void button14_Click(object sender, EventArgs e)
        {
            TxtValorCalcular.Text = (double.Parse(TxtValorCalcular.Text) * -1).ToString();
        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
                decimal Operacao = decimal.Parse(TxtValorCalcular.Text) / 100;

                TxtValorCalcular.Text = Operacao.ToString();
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            Num2 = Convert.ToDouble(TxtValorCalcular.Text);

            if (Operacao == '+')
            {
                TxtValorCalcular.Text = (Num1 + Num2).ToString();
                Num1 = Convert.ToDouble(TxtValorCalcular.Text);
            }
            else if (Operacao == '-')
            {
                TxtValorCalcular.Text = (Num1 - Num2).ToString();
                Num1 = Convert.ToDouble(TxtValorCalcular.Text);
            }
            else if (Operacao == 'x')
            {
                TxtValorCalcular.Text = (Num1 * Num2).ToString();
                Num1 = Convert.ToDouble(TxtValorCalcular.Text);
            }
            else if (Operacao == '%')
            {
                TxtValorCalcular.Text = (Num1 * Num2).ToString("N0");
                Num1 = Convert.ToDouble(TxtValorCalcular.Text);
            }
            else if (Operacao == '/')
            {
                if (TxtValorCalcular.Text != "0")
                {
                    TxtValorCalcular.Text = (Num1 / Num2).ToString();
                    Num1 = Convert.ToDouble(TxtValorCalcular.Text);
                }
            }


        }
    }
}