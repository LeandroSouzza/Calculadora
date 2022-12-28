namespace Calculadora.Interface
{
    public partial class FormPrincipal : Form
    {
        private double Num1 = 0, Num2 = 0;
        private char Calcular;
        public bool Resultado { get; set; }

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void clickOperacao(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            Operador(boton.Text);
        }

        private void Operador(string operacao)
        {
            if (Resultado)
            {
                LblValorCalcular.Text = "";
            }
            Resultado = false;

            if (TxtValorCalcular.Text != "")
            {
                Num1 = Convert.ToDouble(TxtValorCalcular.Text);

                Calcular = Convert.ToChar(operacao);

                LblValorCalcular.Text = TxtValorCalcular.Text;

                LblValorCalcular.Text += operacao;

                TxtValorCalcular.Text = "";
            }
        }

        private void agregarNumero(object sender, EventArgs e)
        {
            var button = ((Button)sender);
            const int TamanhoMaximo = 16;

            if (TxtValorCalcular.Text.Length > TamanhoMaximo)
                return;

            if (TxtValorCalcular.Text == "0")
            {
                TxtValorCalcular.Text = "";
            }
            else if (LblValorCalcular.Text == "0+")
            {
                TxtValorCalcular.Text = "";
                LblValorCalcular.Text = "";
            }
            else if (LblValorCalcular.Text == "0-")
            {
                TxtValorCalcular.Text = "";
                LblValorCalcular.Text = "";
            }
            else if (LblValorCalcular.Text == "0x")
            {
                TxtValorCalcular.Text = "";
                LblValorCalcular.Text = "";
            }
            else if (LblValorCalcular.Text == "0/")
            {
                TxtValorCalcular.Text = "";
                LblValorCalcular.Text = "";
            }
            else if (Resultado)
            {
                TxtValorCalcular.Text = "";
                LblValorCalcular.Text = "";
            }

            Resultado = false;

            TxtValorCalcular.Text += button.Text;
        }

        private void Apagador(string apagador)
        {
            if (TxtValorCalcular.Text != "")
            {
                string Apagar = TxtValorCalcular.Text;
                Apagar = Apagar.Remove(Apagar.Length - 1);
                TxtValorCalcular.Text = Apagar;
            }

            if (TxtValorCalcular.Text == "")

                TxtValorCalcular.Text = TxtValorCalcular.Text = "0";
        }

        private void Virgula(string virgula)
        {
            if (TxtValorCalcular.Text != "")
                if (!TxtValorCalcular.Text.Contains(","))

                    TxtValorCalcular.Text += ",";
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
            Virgula("virgula");
        }

        private void BtnApagar_Click(object sender, EventArgs e)
        {
            Apagador("apagador");
        }

        //Textbox aceitar só números//
        private void TxtValorCalcular_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.DecNumber(sender, e);
        }

        private void FormPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            TxtTeclado.Text = Convert.ToString(e.KeyValue);

            if (TxtValorCalcular.Text == "0")
            {
                TxtValorCalcular.Text = "";
            }

            /*if (Resultado)
            {
                LblValorCalcular.Text = "";
                TxtValorCalcular.Text = "";
            }
            Resultado = false;*/

            if (e.KeyValue == 107)
            {
                Operador("+");
            }

            if (e.KeyValue == 109)
            {
                Operador("-");
            }

            if (e.KeyValue == 106)
            {
                Operador("x");
            }

            if (e.KeyValue == 111)
            {
                Operador("/");
            }

            if (e.KeyValue == 13)
            {
                {
                    Igual("resultado");
                }
            }

            if (e.KeyValue == 8)
            {
                Apagador("apagador");
            }

            if (e.KeyValue == 188)
            {
                Virgula("virgula");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            TxtValorCalcular.Text = (double.Parse(TxtValorCalcular.Text) * -1).ToString();
        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            if (Calcular == 'x')
            {
                decimal Operacao = decimal.Parse(TxtValorCalcular.Text) / 100;
                TxtValorCalcular.Text = Operacao.ToString();
                LblValorCalcular.Text += TxtValorCalcular.Text;
            }
            //Rascunho do calculo porcentagem ao utiliza a SOMA
            else if (Calcular == '+')
            {
                TxtValorCalcular.Text = (Num1 / 100 * Num2).ToString();
            }
        }

        private void Igual(string resultado)
        {
            if (TxtValorCalcular.Text != "")
            {
                if (!Resultado)
                {
                    Num2 = Convert.ToDouble(TxtValorCalcular.Text);
                }

                AtribuirValores();

                if (Calcular == '+')
                {
                    TxtValorCalcular.Text = (Num1 + Num2).ToString();
                    Num1 = Convert.ToDouble(TxtValorCalcular.Text);
                }
                else if (Calcular == '-')
                {
                    TxtValorCalcular.Text = (Num1 - Num2).ToString();
                    Num1 = Convert.ToDouble(TxtValorCalcular.Text);
                }
                else if (Calcular == 'x')
                {
                    TxtValorCalcular.Text = (Num1 * Num2).ToString();
                    Num1 = Convert.ToDouble(TxtValorCalcular.Text);
                }
                else if (Calcular == '%')
                {
                    TxtValorCalcular.Text = (Num1 * Num2).ToString("N0");
                    Num1 = Convert.ToDouble(TxtValorCalcular.Text);
                }
                else if (Calcular == '/')
                {
                    if (TxtValorCalcular.Text != "0")
                    {
                        LblValorCalcular.Text = $"{LblValorCalcular.Text} {TxtValorCalcular.Text} =";
                        TxtValorCalcular.Text = (Num1 / Num2).ToString();
                        Num1 = Convert.ToDouble(TxtValorCalcular.Text);
                    }
                }
            }

            Resultado = true;
        }

        private void AtribuirValores()
        {
            LblValorCalcular.Text = $"{Num1}{Calcular}{Num2} = ";
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            {
                Igual("resultado");
            }
        }
    }
}