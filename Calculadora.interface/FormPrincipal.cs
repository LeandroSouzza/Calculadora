namespace Calculadora.Interface
{
    public partial class FormPrincipal : Form
    {
        private decimal ValorCalcular;
        private bool EhSoma, EhMultiplicacao, EhDivisao, EhSubtracao, EhPercentual;
        private void LimparOperacoes()

        {
            EhSoma = false;
            EhDivisao = false;
            EhMultiplicacao = false;
            EhSubtracao = false;
            EhPercentual = false;
        }

        private void agregarNumero(object sender, EventArgs e)
        {
            var button = ((Button)sender);

            if (TxtValorCalcular.Text == "0")
                TxtValorCalcular.Text = "";

            TxtValorCalcular.Text += button.Text;
        }

        private void BtnMenos_Click(object sender, EventArgs e)
        {
            LimparOperacoes();

            EhSubtracao = true;

            if (TxtValorCalcular.Text != "")
                ValorCalcular = Decimal.Parse(TxtValorCalcular.Text);
            TxtValorCalcular.Text = "";
            LblValorCalcular.Text = $"{ValorCalcular} -";

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
        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            decimal ValorTotal = ValorCalcular * decimal.Parse(TxtValorCalcular.Text) / 100;

            LblValorCalcular.Text = $"{LblValorCalcular.Text} {TxtValorCalcular.Text} =";

            TxtValorCalcular.Text = ValorTotal.ToString();

            LimparOperacoes();

            EhPercentual = true;

            if (TxtValorCalcular.Text != "")
                ValorCalcular = Decimal.Parse(TxtValorCalcular.Text);
            TxtValorCalcular.Text = "";
            TxtValorCalcular.Text = $"{ValorCalcular}";
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
                TxtValorCalcular.Text = TxtValorCalcular.Text = "0";
            }


        }
        //Textbox aceitar só números//
        private void TxtValorCalcular_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.DecNumber(sender, e);

        }

        private void TxtValorCalcular_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void FormPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
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

                    LimparOperacoes();
                string Apagar = TxtValorCalcular.Text;
                Apagar = Apagar.Remove(Apagar.Length - 1);
                TxtValorCalcular.Text = Apagar;
            }
            catch
            {
                
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
            TxtValorCalcular.Text = (double.Parse(TxtValorCalcular.Text) * -1).ToString();
        }

        private void FormPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void TxtTeclado_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void TxtTeclado_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
        private void BtnIgual_Click(object sender, EventArgs e)
        {
            if (TxtValorCalcular.Text != "")

                if (EhSoma)
                {
                    decimal ValorTotal = ValorCalcular + decimal.Parse(TxtValorCalcular.Text);

                    LblValorCalcular.Text = $"{LblValorCalcular.Text} {TxtValorCalcular.Text} =";

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
