﻿namespace Calculadora.Interface
{
    public partial class FormPrincipal : Form
    {
        private double Num1 = 0, Num2 = 0;
        private char Calcular;

        public bool Resultado { get; set; }

        public bool ResetHistorico { get; set; }

        public FormPrincipal()
        {
            InitializeComponent();
        }

        //Declarar variáveis

        Panel pnHis;
        Label lbl1His, lbl2His;
        int nHis = 1;
        Label[] lb1His = new Label[0], lb2His = new Label[0];

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
            lbl1His.Name = "lbl1_" + nHis;
            lbl1His.Left = panelHistorico.Width - lbl1His.Width;

            lbl2His.Text = num;
            lbl2His.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lbl2His.Top = 20;
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
            if (Resultado)
            {
                LblValorCalcular.Text = "";
            }
            Resultado = false;
            
            if (LabelResultado.Text.LastOrDefault() == ',')
            {
               LabelResultado.Text = LabelResultado.Text.Replace(",", "");
            }

            if (LabelResultado.Text != "")
            { 
                Num1 = Convert.ToDouble(LabelResultado.Text);

                Calcular = Convert.ToChar(operacao);

                LblValorCalcular.Text = LabelResultado.Text;

                LblValorCalcular.Text += operacao;

                LabelResultado.Text = "";

            }

            focoAlternativo.Focus();

        }

        private void agregarNumero(object sender, EventArgs e)
        {
            var button = ((Button)sender);
            const int TamanhoMaximo = 16;

            if (LabelResultado.Text.Length > TamanhoMaximo)
                return;

            if (LabelResultado.Text == "0")
            {
                LabelResultado.Text = "";
            }
            else if (Resultado)
            {
                LabelResultado.Text = "";
                LblValorCalcular.Text = "";
            }

            Resultado = false;

            LabelResultado.Text += button.Text;

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

            focoAlternativo.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LabelResultado.Text = "0";

            if (Resultado)
            {
                LblValorCalcular.Text = "";
                LabelResultado.Text = "0";

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
            
            if (e.KeyChar == 48)
            {
                if (LabelResultado.Text == "0")
                {
                    LabelResultado.Text = "";
                }
                else if (Resultado)
                {
                    LabelResultado.Text = "";
                    LblValorCalcular.Text = "";
                }

                Resultado = false;

                LabelResultado.Text += 0;
            }

            if (e.KeyChar == 13)
            {
                LabelResultado.Text = "\r";
            }

                if (e.KeyChar == 49)
            {
                if (LabelResultado.Text == "0")
                {
                    LabelResultado.Text = "";
                }
                else if (Resultado)
                {
                    LabelResultado.Text = "";
                    LblValorCalcular.Text = "";
                }

                Resultado = false;

                LabelResultado.Text += 1;
            }

            if (e.KeyChar == 50)
            {

                if (LabelResultado.Text == "0")
                {
                    LabelResultado.Text = "";
                }
                else if (Resultado)
                {
                    LabelResultado.Text = "";
                    LblValorCalcular.Text = "";
                }

                Resultado = false;

                LabelResultado.Text += 2;
            }

            if (e.KeyChar == 51)
            {

                if (LabelResultado.Text == "0")
                {
                    LabelResultado.Text = "";
                }
                if (LabelResultado.Text == "0")
                {
                    LabelResultado.Text = "";
                }
                else if (Resultado)
                {
                    LabelResultado.Text = "";
                    LblValorCalcular.Text = "";
                }

                Resultado = false;

                LabelResultado.Text += 3;
            }
            if (e.KeyChar == 52)
            {

                if (LabelResultado.Text == "0")
                {
                    LabelResultado.Text = "";
                }
                if (LabelResultado.Text == "0")
                {
                    LabelResultado.Text = "";
                }
                else if (Resultado)
                {
                    LabelResultado.Text = "";
                    LblValorCalcular.Text = "";
                }

                Resultado = false;

                LabelResultado.Text += 4;
            }
            if (e.KeyChar == 53)
            {

                if (LabelResultado.Text == "0")
                {
                    LabelResultado.Text = "";
                }
                if (LabelResultado.Text == "0")
                {
                    LabelResultado.Text = "";
                }
                else if (Resultado)
                {
                    LabelResultado.Text = "";
                    LblValorCalcular.Text = "";
                }

                Resultado = false;

                LabelResultado.Text += 5;

            }
            if (e.KeyChar == 54)
            {

                if (LabelResultado.Text == "0")
                {
                    LabelResultado.Text = "";
                }
                if (LabelResultado.Text == "0")
                {
                    LabelResultado.Text = "";
                }
                else if (Resultado)
                {
                    LabelResultado.Text = "";
                    LblValorCalcular.Text = "";
                }

                Resultado = false;

                LabelResultado.Text += 6;
            }
            if (e.KeyChar == 55)
            {

                if (LabelResultado.Text == "0")
                {
                    LabelResultado.Text = "";
                }
                if (LabelResultado.Text == "0")
                {
                    LabelResultado.Text = "";
                }
                else if (Resultado)
                {
                    LabelResultado.Text = "";
                    LblValorCalcular.Text = "";
                }

                Resultado = false;

                LabelResultado.Text += 7;
            }
            if (e.KeyChar == 56)
            {

                if (LabelResultado.Text == "0")
                {
                    LabelResultado.Text = "";
                }
                if (LabelResultado.Text == "0")
                {
                    LabelResultado.Text = "";
                }
                else if (Resultado)
                {
                    LabelResultado.Text = "";
                    LblValorCalcular.Text = "";
                }

                Resultado = false;

                LabelResultado.Text += 8;
            }
            if (e.KeyChar == 57)
            {

                if (LabelResultado.Text == "0")
                {
                    LabelResultado.Text = "";
                }
                if (LabelResultado.Text == "0")
                {
                    LabelResultado.Text = "";
                }
                else if (Resultado)
                {
                    LabelResultado.Text = "";
                    LblValorCalcular.Text = "";
                }

                Resultado = false;

                LabelResultado.Text += 9;
            }



        }

        private void FormPrincipal_KeyDown(object sender, KeyEventArgs e)
        {

            TxtTeclado.Text = Convert.ToString(e.KeyValue);


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
            if (e.KeyValue == 8)
            {
                Apagador("apagador");
            }

            if (e.KeyValue == 188 || e.KeyValue == 110)
            {
                Virgula("virgula");
            }
            
            if (e.KeyValue == 13)
            {
                Igual("resultado");
            }

            focoAlternativo.Focus();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            LabelResultado.Text = (double.Parse(LabelResultado.Text) * -1).ToString();
        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            if (Calcular == 'x')
            {
                decimal Operacao = decimal.Parse(LabelResultado.Text) / 100;
                LabelResultado.Text = Operacao.ToString();
                LblValorCalcular.Text += LabelResultado.Text;
            }
            else if (Calcular == '+')
            {
                decimal Operacao = (decimal.Parse(LabelResultado.Text) / 100) * (decimal)Num1;

                LabelResultado.Text = Operacao.ToString("N0");
                LblValorCalcular.Text += LabelResultado.Text;
            }
            else if (Calcular == '/')
            {
                decimal Operacao = decimal.Parse(LabelResultado.Text) / 100;
                LabelResultado.Text = Operacao.ToString();
                LblValorCalcular.Text += LabelResultado.Text;
            }
            else if (Calcular == '-')
            {
                decimal Operacao = (decimal.Parse(LabelResultado.Text) / 100) * (decimal)Num1;

                LabelResultado.Text = Operacao.ToString("N0");
                LblValorCalcular.Text += LabelResultado.Text;
            }
        }

        private void panelHistorico_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Igual(string resultado)
        {
            if (LabelResultado.Text != "")
            {
                if (!Resultado)
                {
                    Num2 = Convert.ToDouble(LabelResultado.Text);
                }

                AtribuirValores();

                if (Calcular == '+')
                {
                    LabelResultado.Text = (Num1 + Num2).ToString();
                    Num1 = Convert.ToDouble(LabelResultado.Text);
                }
                else if (Calcular == '-')
                {
                    LabelResultado.Text = (Num1 - Num2).ToString();
                    Num1 = Convert.ToDouble(LabelResultado.Text);
                }
                else if (Calcular == 'x')
                {
                    LabelResultado.Text = (Num1 * Num2).ToString("N0");
                    Num1 = Convert.ToDouble(LabelResultado.Text);
                }
                else if (Calcular == '%')
                {
                    LabelResultado.Text = (Num1 * Num2).ToString();
                    Num1 = Convert.ToDouble(LabelResultado.Text);
                }
                else if (Calcular == '/')
                {
                    if (LabelResultado.Text != "0")
                    {
                        LabelResultado.Text = (Num1 / Num2).ToString();
                        Num1 = Convert.ToDouble(LabelResultado.Text);
                    }
                }
            }

            Resultado = true;
            Historico(LabelResultado.Text.ToString(), LblValorCalcular.Text);
            
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