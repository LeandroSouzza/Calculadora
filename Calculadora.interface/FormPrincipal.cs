namespace Calculadora.Interface
{
    public partial class FormPrincipal : Form
    {
        private decimal Num1 = 0, Num2 = 0;
        private string Calcular;
        private bool InseriuNumeroPosResultado;
        public bool Resultado { get; set; }

        public bool SegundoNumeroFoiInserido { get; set; }

        public bool BotaoPorce { get; set; }

        public bool LimiteExcedeu { get; set; }

        public bool ResetHistorico { get; set; }

        public FormPrincipal()
        {
            InitializeComponent();
        }

        //Declarar variáveis

        private Panel pnHis;
        private Label lbl1His, lbl2His;
        private int nHis = 1;
        private Label[] lb1His = new Label[0], lb2His = new Label[0];

        //Função Histórico

        private void Historico(string num, string men)
        {
            pnHis = new Panel();
            lbl1His = new Label();
            lbl2His = new Label();

            pnHis.Height = 70;
            pnHis.Dock = DockStyle.Top;
            pnHis.MouseEnter += new EventHandler(PnFoco);
            pnHis.MouseLeave += new EventHandler(PnForaFoco);
            pnHis.Click += new EventHandler(PnCliqueHis);
            pnHis.Name = "pn" + nHis;

            lbl1His.Text = men;
            lbl1His.Font = new Font("Segoe UI", 10);
            lbl1His.Size = new Size(300, 50);
            lbl1His.Name = "lbl1_" + nHis;
            lbl1His.Left = panelHistorico.Width - lbl1His.Width;
            
            lbl2His.Text = num;
            lbl2His.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lbl2His.Top = 20;
            lbl2His.Size = new Size(300, 50);
            lbl2His.Name = "lbl2_" + nHis;
            lbl2His.Height = 32;
            lbl2His.Left = panelHistorico.Width - lbl2His.Width;

            panelHistorico.Controls.Add(pnHis);
            pnHis.Controls.Add(lbl2His);
            pnHis.Controls.Add(lbl1His);

            Array.Resize(ref lb1His, nHis);
            Array.Resize(ref lb2His, nHis);
            lb1His[nHis - 1] = lbl1His;
            lb2His[nHis - 1] = lbl2His;
            nHis++;
        }

        private void PnFoco(object sender, EventArgs e)
        {
            Panel pn = sender as Panel;
            pn.BackColor = Color.Silver;
        }

        private void PnForaFoco(object sender, EventArgs e)
        {
            Panel pn = sender as Panel;
            pn.BackColor = Color.Transparent;
        }

        private void PnCliqueHis(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            string a = panel.Name.Remove(0, 2);
            lbl1His = lb1His[int.Parse(a) - 1];
            lbl2His = lb2His[int.Parse(a) - 1];

            LblValorCalcular.Text = lbl1His.Text.Remove(lbl1His.Text.Length - 2, 2);
            LabelResultado.Text = lbl2His.Text;
        }

        private void AtalhoHistorico_Click(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Maximized;
                MaximumSize = this.Size;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void LimpaHist_Click(object sender, EventArgs e)
        {
            ResetHistorico = true;
            panelHistorico.Controls.Clear();

            if (ResetHistorico)
            {
                LblMensagemHist.Text = "Ainda não há histórico";
            }
        }

        private void clickOperacao(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            Operador(boton.Text);
        }

        private void Operador(string operacao)
        {
            InseriuNumeroPosResultado = false;
            if (Resultado)
            {
                LblValorCalcular.Text = "";
                Resultado = false;
            }

            if (SegundoNumeroFoiInserido)
            {
                Igual("resultado");
            }
            SegundoNumeroFoiInserido = false;

            if (LabelResultado.Text.LastOrDefault() == ',')
            {
                LabelResultado.Text = LabelResultado.Text.Replace(",", "");
            }
            else if (LabelResultado.Text.LastOrDefault() == '0')
            {
                LabelResultado.Text = LabelResultado.Text.Replace(",0", "");
            }

            if (LabelResultado.Text != "")
            {
                Num1 = Convert.ToDecimal(LabelResultado.Text);

                Calcular = operacao;

                LblValorCalcular.Text = LabelResultado.Text;

                //LblValorCalcular.Text = String.Format("{0:################}", Convert.ToDecimal(LblValorCalcular.Text));

                LblValorCalcular.Text += operacao;

                if (LimiteExcedeu)
                {
                    LabelResultado.Text = "";
                }

                LblMensagemHist.Text = "";
            }

            focoAlternativo.Focus();
        }

        private void agregarNumero(object sender, EventArgs e)
        {
            var button = ((Button)sender);
            InserirNumero(button.Text);
        }

        public void InserirNumero(string inserir)
        {
            const int TamanhoMaximo = 16;

            if (LabelResultado.Text.Length > TamanhoMaximo)
            {
                LimiteExcedeu = true;
                return;
            }
            if (LabelResultado.Text == "0")
            {
                LabelResultado.Text = "";
            }
            else if (Resultado)
            {
                SegundoNumeroFoiInserido = false;
                LabelResultado.Text = "";
                LblValorCalcular.Text = "";
                Resultado = false;
                InseriuNumeroPosResultado = true;
            }
            else if (BotaoPorce)
            {
                LabelResultado.Text = "";
                LblValorCalcular.Text = Num1.ToString() + Calcular.ToString();
            }
            else if (decimal.TryParse(LabelResultado.Text, out var labelResultadoDecimal)  && labelResultadoDecimal == Num1)
            {

                SegundoNumeroFoiInserido = true;
                LabelResultado.Text = "";
            }

            LabelResultado.Text += inserir;
            
           // LabelResultado.Text = String.Format("{0:#,###,###,###,###,###}", Convert.ToDecimal(LabelResultado.Text));

            LblMensagemHist.Text = "";

            focoAlternativo.Focus();
        }

        private void Apagador(string apagador)
        {
            if (LabelResultado.Text != "")
            {
                string Apagar = LabelResultado.Text;
                Apagar = Apagar.Remove(Apagar.Length - 1);
                LabelResultado.Text = Apagar;
            }

            if (LabelResultado.Text == "")

                LabelResultado.Text = "0";

            focoAlternativo.Focus();
        }

        private void Virgula(string virgula)
        {
            if (LabelResultado.Text != "")
                if (!LabelResultado.Text.Contains(","))

                    LabelResultado.Text += ",";

            if (Resultado)
            {
                LblValorCalcular.Text = "";
                LabelResultado.Text = "0";
            }

            focoAlternativo.Focus();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LblValorCalcular.Text = "";
            LabelResultado.Text = "0";

            Num1 = 0;
            Num2 = 0;
            Calcular = "";

            focoAlternativo.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LabelResultado.Text = "0";

            if (Resultado)
            {
                LblValorCalcular.Text = "";

                Num1 = 0;
                Num2 = 0;
                Calcular = "";

                focoAlternativo.Focus();
            }
        }

        private void BtnVírgula_Click(object sender, EventArgs e)
        {
            Virgula("virgula");
        }

        private void BtnApagar_Click(object sender, EventArgs e)
        {
            Apagador("apagador");
        }

        private void FormPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Textbox aceitar só números//
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            //chaves aplicadas com enumeração//

            if (e.KeyChar == (char)Keys.D0)
            {
                InserirNumero("0");
            }

            if (e.KeyChar == (char)Keys.D1)
            {
                InserirNumero("1");
            }

            if (e.KeyChar == (char)Keys.D2)
            {
                InserirNumero("2");
            }

            if (e.KeyChar == (char)Keys.D3)
            {
                InserirNumero("3");
            }
            if (e.KeyChar == (char)Keys.D4)
            {
                InserirNumero("4");
            }
            if (e.KeyChar == (char)Keys.D5)
            {
                InserirNumero("5");
            }
            if (e.KeyChar == (char)Keys.D6)
            {
                InserirNumero("6");
            }
            if (e.KeyChar == (char)Keys.D7)
            {
                InserirNumero("7");
            }
            if (e.KeyChar == (char)Keys.D8)
            {
                InserirNumero("8");
            }
            if (e.KeyChar == (char)Keys.D9)
            {
                InserirNumero("9");
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                Apagador("apagador");
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                focoAlternativo.Text = "";
                Igual("resultado");
            }
        }

        private void FormPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            TxtTeclado.Text = Convert.ToString(e.KeyValue);

            //chaves aplicadas com enumeração//

            if (e.KeyCode == Keys.Add)
            {
                Operador("+");
            }

            if (e.KeyCode == Keys.Subtract)
            {
                Operador("-");
            }

            if (e.KeyCode == Keys.Multiply)
            {
                Operador("x");
            }

            if (e.KeyCode == Keys.Divide)
            {
                Operador("/");
            }

            if (e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.Decimal)
            {
                Virgula("virgula");
            }

            focoAlternativo.Focus();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (LabelResultado.Text != "0")
            {
                LabelResultado.Text = (double.Parse(LabelResultado.Text) * -1).ToString();
                focoAlternativo.Focus();
            }
        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            BotaoPorce = true;

            try
            {
                if (Calcular == "x")
                {
                    decimal Operacao = decimal.Parse(LabelResultado.Text) / 100;
                    LabelResultado.Text = Operacao.ToString();
                    LblValorCalcular.Text = $"{Num1} {Calcular} {LabelResultado.Text} ";
                }
                else if (Calcular == "+")
                {
                    decimal Operacao = (decimal.Parse(LabelResultado.Text) / 100) * (decimal)Num1;

                    LabelResultado.Text = Operacao.ToString("N0");
                    LblValorCalcular.Text = $"{Num1} {Calcular} {LabelResultado.Text} ";
                }
                else if (Calcular == "/")
                {
                    decimal Operacao = decimal.Parse(LabelResultado.Text) / 100;
                    LabelResultado.Text = Operacao.ToString();
                    LblValorCalcular.Text = $"{Num1} {Calcular} {LabelResultado.Text} ";
                }

                else if (Calcular == "-")
                {
                    decimal Operacao = (decimal.Parse(LabelResultado.Text) / 100) * (decimal)Num1;
                    LabelResultado.Text = Operacao.ToString("N0");
                    LblValorCalcular.Text = $"{Num1} {Calcular} {LabelResultado.Text} ";
                }
            }
            catch (Exception)
            {
            }
        }

        private void panelHistorico_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Igual(string resultado)
        {
            if (LabelResultado.Text != "")
            {
                if (InseriuNumeroPosResultado)
                {
                    Num2 = Num1;
                    Num1 = Convert.ToDecimal(LabelResultado.Text);
                    InseriuNumeroPosResultado = false;
                }
                else if (!Resultado)
                {
                    Num2 = Convert.ToDecimal(LabelResultado.Text);
                }

                AtribuirValores();
                var resultadoCalculo = 0M;

                if (Calcular == "+")
                {
                    resultadoCalculo = Num1 + Num2;

                    if (LabelResultado.Text.LastOrDefault() == '0')
                    {
                        LabelResultado.Text = LabelResultado.Text.Replace(",0", "");
                    }
                }
                else if (Calcular == "-")
                {
                    resultadoCalculo = Num1 - Num2;
                }
                else if (Calcular == "x")
                {
                    var result = Math.Truncate(Num1 * Num2);
                    resultadoCalculo = Num1 * Num2;
                }
                else if (Calcular == "%")
                {
                    resultadoCalculo = Num1 * Num2;
                }
                else if (Calcular == "/")
                {
                    if (LabelResultado.Text != "0")
                    {
                        resultadoCalculo = Num1 / Num2;
                    }
                }

                focoAlternativo.Focus();

                try
                {
                    LabelResultado.Text = resultadoCalculo.ToString("###.###.###.###.###,#############");
                    Num1 = Convert.ToDecimal(LabelResultado.Text);
                }
                catch (Exception)
                {

                }
            }
            try
            {
                if (Num1 == 0)
                {
                    LblValorCalcular.Text = Num1.ToString().Replace("0", "");
                    LblValorCalcular.Text = Num2.ToString() + " =";
                    LabelResultado.Text = Num2.ToString();
                }
                Resultado = true;

                LabelResultado.Text = String.Format("{0:#,###,###,###,###,###}", Convert.ToDecimal(LabelResultado.Text));
                Historico(LabelResultado.Text.ToString(), LblValorCalcular.Text);
            }
            catch (Exception)
            {

            }
        }

        private void AtribuirValores()
        {
            // var numero1String = Num1 == 0 ? "" : $"{Num1}";

            LblValorCalcular.Text = $"{Num1} {Calcular} {Num2} = ";

            if (Num2 == 0)
            {
                LblValorCalcular.Text = Num2.ToString().Replace("0", "");
                LblValorCalcular.Text = Num1.ToString() + " =";
                LabelResultado.Text = Num1.ToString();
            }
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            {
                Igual("resultado");
            }
        }
    }
}