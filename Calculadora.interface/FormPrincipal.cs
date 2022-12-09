namespace Calculadora.Interface
{
    public partial class FormPrincipal : Form
    {
        double Num1 = 0, Num2 = 0;
        char Operacao;


        public double Resultado { get; set; }

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void clickOperacao(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            if (TxtValorCalcular.Text != "")
            {
                Num1 = Convert.ToDouble(TxtValorCalcular.Text);

                Operacao = Convert.ToChar(boton.Text);

                LblValorCalcular.Text += TxtValorCalcular.Text;

                LblValorCalcular.Text += boton.Text;

                TxtValorCalcular.Text = "";
            }

        }

        private void agregarNumero(object sender, EventArgs e)
        {
            var button = ((Button)sender);

            if (TxtValorCalcular.Text == "0")
            {
                TxtValorCalcular.Text = "";
            }
            else if (TxtValorCalcular.Text != "")
            {
                TxtValorCalcular.Text += "";
                LblValorCalcular.Text = "";
            }

            TxtValorCalcular.Text += button.Text;
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
        {
            TxtTeclado.Text = Convert.ToString(e.KeyValue);

            if (e.KeyValue == 107)
            
                LblValorCalcular.Text = "+";
            LblValorCalcular.Text += TxtValorCalcular.Text;

            if (e.KeyValue == 109)
            
                LblValorCalcular.Text = "-";

            if (e.KeyValue == 106)
            
                LblValorCalcular.Text = "*";

            if (e.KeyValue == 111)
            
                LblValorCalcular.Text = "/";

            if (e.KeyValue == 13)
            {

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            TxtValorCalcular.Text = (double.Parse(TxtValorCalcular.Text) * -1).ToString();
        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
                decimal Operacao = decimal.Parse(TxtValorCalcular.Text) / 100;

                TxtValorCalcular.Text = Operacao.ToString();

                LblValorCalcular.Text += TxtValorCalcular.Text;
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            if (TxtValorCalcular.Text != "")
            

                Num2 = Convert.ToDouble(TxtValorCalcular.Text);

            if (Operacao == '+')
            {
                LblValorCalcular.Text = $"{LblValorCalcular.Text} {TxtValorCalcular.Text} =";   
                TxtValorCalcular.Text = (Num1 + Num2).ToString();
                Num1 = Convert.ToDouble(TxtValorCalcular.Text);
            }
            else if (Operacao == '-')
            {
                LblValorCalcular.Text = $"{LblValorCalcular.Text} {TxtValorCalcular.Text} =";
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
                    LblValorCalcular.Text = $"{LblValorCalcular.Text} {TxtValorCalcular.Text} =";
                    TxtValorCalcular.Text = (Num1 / Num2).ToString();
                    Num1 = Convert.ToDouble(TxtValorCalcular.Text);
                }
            }
        }
    }
}