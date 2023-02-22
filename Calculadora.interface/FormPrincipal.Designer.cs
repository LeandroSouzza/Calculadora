namespace Calculadora.Interface
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LblValorCalcular = new Label();
            BtnIgual = new Button();
            BtnVírgula = new Button();
            btn0 = new Button();
            button14 = new Button();
            BtnMais = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            BtnMenos = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            BtnVezez = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            BtnDivide = new Button();
            btnPorcentagem = new Button();
            BtnApagar = new Button();
            BtnLimpar = new Button();
            cancelarRegistro = new Button();
            TxtTeclado = new Button();
            panelHistorico = new Panel();
            LblMensagemHist = new Label();
            LimpaHist = new Button();
            AtalhoHistorico = new Button();
            LabelResultado = new Label();
            focoAlternativo = new Label();
            labelHistorico = new Label();
            SuspendLayout();
            // 
            // LblValorCalcular
            // 
            LblValorCalcular.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblValorCalcular.Location = new Point(4, 26);
            LblValorCalcular.Name = "LblValorCalcular";
            LblValorCalcular.Size = new Size(335, 21);
            LblValorCalcular.TabIndex = 2;
            LblValorCalcular.TextAlign = ContentAlignment.TopRight;
            // 
            // BtnIgual
            // 
            BtnIgual.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BtnIgual.Location = new Point(261, 335);
            BtnIgual.Margin = new Padding(3, 2, 3, 2);
            BtnIgual.Name = "BtnIgual";
            BtnIgual.Size = new Size(79, 44);
            BtnIgual.TabIndex = 3;
            BtnIgual.TabStop = false;
            BtnIgual.Text = "=";
            BtnIgual.UseVisualStyleBackColor = true;
            BtnIgual.Click += BtnIgual_Click;
            // 
            // BtnVírgula
            // 
            BtnVírgula.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            BtnVírgula.Location = new Point(178, 336);
            BtnVírgula.Margin = new Padding(3, 2, 3, 2);
            BtnVírgula.Name = "BtnVírgula";
            BtnVírgula.RightToLeft = RightToLeft.No;
            BtnVírgula.Size = new Size(79, 44);
            BtnVírgula.TabIndex = 8;
            BtnVírgula.TabStop = false;
            BtnVírgula.Text = ",";
            BtnVírgula.UseVisualStyleBackColor = true;
            BtnVírgula.Click += BtnVírgula_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn0.Location = new Point(94, 334);
            btn0.Margin = new Padding(3, 2, 3, 2);
            btn0.Name = "btn0";
            btn0.Size = new Size(79, 46);
            btn0.TabIndex = 27;
            btn0.TabStop = false;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += agregarNumero;
            // 
            // button14
            // 
            button14.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button14.Location = new Point(10, 335);
            button14.Margin = new Padding(3, 2, 3, 2);
            button14.Name = "button14";
            button14.Size = new Size(79, 44);
            button14.TabIndex = 18;
            button14.TabStop = false;
            button14.Text = "+/-";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // BtnMais
            // 
            BtnMais.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BtnMais.Location = new Point(262, 286);
            BtnMais.Margin = new Padding(3, 2, 3, 2);
            BtnMais.Name = "BtnMais";
            BtnMais.Size = new Size(79, 46);
            BtnMais.TabIndex = 1;
            BtnMais.TabStop = false;
            BtnMais.Text = "+";
            BtnMais.UseVisualStyleBackColor = true;
            BtnMais.Click += clickOperacao;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.Location = new Point(178, 286);
            btn3.Margin = new Padding(3, 2, 3, 2);
            btn3.Name = "btn3";
            btn3.Size = new Size(79, 46);
            btn3.TabIndex = 28;
            btn3.TabStop = false;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += agregarNumero;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(94, 286);
            btn2.Margin = new Padding(3, 2, 3, 2);
            btn2.Name = "btn2";
            btn2.Size = new Size(79, 46);
            btn2.TabIndex = 29;
            btn2.TabStop = false;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += agregarNumero;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location = new Point(10, 286);
            btn1.Margin = new Padding(3, 2, 3, 2);
            btn1.Name = "btn1";
            btn1.Size = new Size(79, 46);
            btn1.TabIndex = 30;
            btn1.TabStop = false;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += agregarNumero;
            // 
            // BtnMenos
            // 
            BtnMenos.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BtnMenos.Location = new Point(262, 236);
            BtnMenos.Margin = new Padding(3, 2, 3, 2);
            BtnMenos.Name = "BtnMenos";
            BtnMenos.Size = new Size(79, 46);
            BtnMenos.TabIndex = 4;
            BtnMenos.TabStop = false;
            BtnMenos.Text = "-";
            BtnMenos.UseVisualStyleBackColor = true;
            BtnMenos.Click += clickOperacao;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.Location = new Point(178, 236);
            btn6.Margin = new Padding(3, 2, 3, 2);
            btn6.Name = "btn6";
            btn6.Size = new Size(79, 46);
            btn6.TabIndex = 31;
            btn6.TabStop = false;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += agregarNumero;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.Location = new Point(94, 236);
            btn5.Margin = new Padding(3, 2, 3, 2);
            btn5.Name = "btn5";
            btn5.Size = new Size(79, 46);
            btn5.TabIndex = 32;
            btn5.TabStop = false;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += agregarNumero;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.Location = new Point(10, 236);
            btn4.Margin = new Padding(3, 2, 3, 2);
            btn4.Name = "btn4";
            btn4.Size = new Size(79, 46);
            btn4.TabIndex = 33;
            btn4.TabStop = false;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += agregarNumero;
            // 
            // BtnVezez
            // 
            BtnVezez.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BtnVezez.Location = new Point(262, 189);
            BtnVezez.Margin = new Padding(3, 2, 3, 2);
            BtnVezez.Name = "BtnVezez";
            BtnVezez.Size = new Size(79, 44);
            BtnVezez.TabIndex = 5;
            BtnVezez.TabStop = false;
            BtnVezez.Text = "x";
            BtnVezez.UseVisualStyleBackColor = true;
            BtnVezez.Click += clickOperacao;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.Location = new Point(178, 188);
            btn9.Margin = new Padding(3, 2, 3, 2);
            btn9.Name = "btn9";
            btn9.Size = new Size(79, 46);
            btn9.TabIndex = 34;
            btn9.TabStop = false;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += agregarNumero;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.Location = new Point(94, 187);
            btn8.Margin = new Padding(3, 2, 3, 2);
            btn8.Name = "btn8";
            btn8.Size = new Size(79, 46);
            btn8.TabIndex = 35;
            btn8.TabStop = false;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += agregarNumero;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.Location = new Point(10, 187);
            btn7.Margin = new Padding(3, 2, 3, 2);
            btn7.Name = "btn7";
            btn7.Size = new Size(79, 46);
            btn7.TabIndex = 36;
            btn7.TabStop = false;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += agregarNumero;
            // 
            // BtnDivide
            // 
            BtnDivide.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BtnDivide.Location = new Point(262, 137);
            BtnDivide.Margin = new Padding(3, 2, 3, 2);
            BtnDivide.Name = "BtnDivide";
            BtnDivide.Size = new Size(79, 46);
            BtnDivide.TabIndex = 6;
            BtnDivide.TabStop = false;
            BtnDivide.Text = "/";
            BtnDivide.UseVisualStyleBackColor = true;
            BtnDivide.Click += clickOperacao;
            // 
            // btnPorcentagem
            // 
            btnPorcentagem.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnPorcentagem.Location = new Point(262, 88);
            btnPorcentagem.Margin = new Padding(3, 2, 3, 2);
            btnPorcentagem.Name = "btnPorcentagem";
            btnPorcentagem.Size = new Size(79, 46);
            btnPorcentagem.TabIndex = 25;
            btnPorcentagem.TabStop = false;
            btnPorcentagem.Text = "%";
            btnPorcentagem.UseVisualStyleBackColor = true;
            btnPorcentagem.Click += btnPorcentagem_Click;
            // 
            // BtnApagar
            // 
            BtnApagar.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            BtnApagar.Location = new Point(178, 87);
            BtnApagar.Margin = new Padding(3, 2, 3, 2);
            BtnApagar.Name = "BtnApagar";
            BtnApagar.Size = new Size(79, 97);
            BtnApagar.TabIndex = 22;
            BtnApagar.TabStop = false;
            BtnApagar.Text = "←";
            BtnApagar.UseVisualStyleBackColor = true;
            BtnApagar.Click += BtnApagar_Click;
            // 
            // BtnLimpar
            // 
            BtnLimpar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BtnLimpar.Location = new Point(94, 88);
            BtnLimpar.Margin = new Padding(3, 2, 3, 2);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(79, 96);
            BtnLimpar.TabIndex = 23;
            BtnLimpar.TabStop = false;
            BtnLimpar.Text = "C";
            BtnLimpar.UseVisualStyleBackColor = true;
            BtnLimpar.Click += BtnLimpar_Click;
            // 
            // cancelarRegistro
            // 
            cancelarRegistro.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cancelarRegistro.Location = new Point(10, 88);
            cancelarRegistro.Margin = new Padding(3, 2, 3, 2);
            cancelarRegistro.Name = "cancelarRegistro";
            cancelarRegistro.Size = new Size(79, 96);
            cancelarRegistro.TabIndex = 24;
            cancelarRegistro.TabStop = false;
            cancelarRegistro.Text = "CE";
            cancelarRegistro.UseVisualStyleBackColor = true;
            cancelarRegistro.Click += button2_Click;
            // 
            // TxtTeclado
            // 
            TxtTeclado.Location = new Point(10, 0);
            TxtTeclado.Margin = new Padding(3, 2, 3, 2);
            TxtTeclado.Name = "TxtTeclado";
            TxtTeclado.Size = new Size(82, 22);
            TxtTeclado.TabIndex = 26;
            TxtTeclado.UseVisualStyleBackColor = true;
            TxtTeclado.Visible = false;
            // 
            // panelHistorico
            // 
            panelHistorico.Location = new Point(356, 62);
            panelHistorico.Margin = new Padding(3, 2, 3, 2);
            panelHistorico.Name = "panelHistorico";
            panelHistorico.Size = new Size(328, 307);
            panelHistorico.TabIndex = 37;
            // 
            // LblMensagemHist
            // 
            LblMensagemHist.AutoSize = true;
            LblMensagemHist.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblMensagemHist.Location = new Point(382, 39);
            LblMensagemHist.Name = "LblMensagemHist";
            LblMensagemHist.Size = new Size(0, 21);
            LblMensagemHist.TabIndex = 1;
            // 
            // LimpaHist
            // 
            LimpaHist.BackColor = SystemColors.ButtonShadow;
            LimpaHist.Location = new Point(690, 342);
            LimpaHist.Margin = new Padding(3, 2, 3, 2);
            LimpaHist.Name = "LimpaHist";
            LimpaHist.Size = new Size(22, 27);
            LimpaHist.TabIndex = 0;
            LimpaHist.Text = "🗑";
            LimpaHist.UseVisualStyleBackColor = false;
            LimpaHist.Click += LimpaHist_Click;
            // 
            // AtalhoHistorico
            // 
            AtalhoHistorico.BackColor = SystemColors.AppWorkspace;
            AtalhoHistorico.Location = new Point(300, 1);
            AtalhoHistorico.Margin = new Padding(3, 2, 3, 2);
            AtalhoHistorico.Name = "AtalhoHistorico";
            AtalhoHistorico.Size = new Size(22, 21);
            AtalhoHistorico.TabIndex = 39;
            AtalhoHistorico.Text = "🕗";
            AtalhoHistorico.UseVisualStyleBackColor = false;
            AtalhoHistorico.Click += AtalhoHistorico_Click;
            // 
            // LabelResultado
            // 
            LabelResultado.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            LabelResultado.Location = new Point(10, 46);
            LabelResultado.Name = "LabelResultado";
            LabelResultado.RightToLeft = RightToLeft.No;
            LabelResultado.Size = new Size(330, 38);
            LabelResultado.TabIndex = 40;
            LabelResultado.Text = "0";
            LabelResultado.TextAlign = ContentAlignment.TopRight;
            // 
            // focoAlternativo
            // 
            focoAlternativo.AutoSize = true;
            focoAlternativo.Location = new Point(116, 53);
            focoAlternativo.Name = "focoAlternativo";
            focoAlternativo.Size = new Size(39, 15);
            focoAlternativo.TabIndex = 42;
            focoAlternativo.Text = "Foco2";
            // 
            // labelHistorico
            // 
            labelHistorico.AutoSize = true;
            labelHistorico.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelHistorico.Location = new Point(382, 9);
            labelHistorico.Name = "labelHistorico";
            labelHistorico.Size = new Size(79, 21);
            labelHistorico.TabIndex = 44;
            labelHistorico.Text = "Histórico";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(724, 384);
            Controls.Add(labelHistorico);
            Controls.Add(LabelResultado);
            Controls.Add(LblMensagemHist);
            Controls.Add(AtalhoHistorico);
            Controls.Add(LimpaHist);
            Controls.Add(panelHistorico);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btn0);
            Controls.Add(TxtTeclado);
            Controls.Add(btnPorcentagem);
            Controls.Add(cancelarRegistro);
            Controls.Add(BtnLimpar);
            Controls.Add(BtnApagar);
            Controls.Add(button14);
            Controls.Add(BtnVírgula);
            Controls.Add(BtnDivide);
            Controls.Add(BtnVezez);
            Controls.Add(BtnMenos);
            Controls.Add(BtnIgual);
            Controls.Add(LblValorCalcular);
            Controls.Add(BtnMais);
            Controls.Add(focoAlternativo);
            DoubleBuffered = true;
            IsMdiContainer = true;
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(740, 427);
            MinimumSize = new Size(368, 423);
            Name = "FormPrincipal";
            Text = "Form1";
            KeyDown += FormPrincipal_KeyDown;
            KeyPress += FormPrincipal_KeyPress;
            KeyUp += FormPrincipal_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LblValorCalcular;
        private Button BtnIgual;
        private Button BtnVírgula;
        private Button btn0;
        private Button button14;
        private Button BtnMais;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button BtnMenos;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button BtnVezez;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button BtnDivide;
        private Button btnPorcentagem;
        private Button BtnApagar;
        private Button BtnLimpar;
        private Button cancelarRegistro;
        private Button TxtTeclado;
        private Panel panelHistorico;
        private Button AtalhoHistorico;
        private Button LimpaHist;
        private Label LblMensagemHist;
        private Label LabelResultado;
        private Label focoAlternativo;
        private Label labelHistorico;
    }
}