﻿namespace Calculadora.Interface
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
            this.LblValorCalcular = new System.Windows.Forms.Label();
            this.BtnIgual = new System.Windows.Forms.Button();
            this.BtnVírgula = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.BtnMais = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.BtnMenos = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.BtnVezez = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.BtnDivide = new System.Windows.Forms.Button();
            this.btnPorcentagem = new System.Windows.Forms.Button();
            this.BtnApagar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.cancelarRegistro = new System.Windows.Forms.Button();
            this.TxtTeclado = new System.Windows.Forms.Button();
            this.panelHistorico = new System.Windows.Forms.Panel();
            this.LblMensagemHist = new System.Windows.Forms.Label();
            this.LimpaHist = new System.Windows.Forms.Button();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.AtalhoHistorico = new System.Windows.Forms.Button();
            this.LabelResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblValorCalcular
            // 
            this.LblValorCalcular.AutoSize = true;
            this.LblValorCalcular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblValorCalcular.Location = new System.Drawing.Point(10, 7);
            this.LblValorCalcular.Name = "LblValorCalcular";
            this.LblValorCalcular.Size = new System.Drawing.Size(0, 21);
            this.LblValorCalcular.TabIndex = 2;
            // 
            // BtnIgual
            // 
            this.BtnIgual.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnIgual.Location = new System.Drawing.Point(262, 325);
            this.BtnIgual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnIgual.Name = "BtnIgual";
            this.BtnIgual.Size = new System.Drawing.Size(79, 44);
            this.BtnIgual.TabIndex = 3;
            this.BtnIgual.Text = "=";
            this.BtnIgual.UseVisualStyleBackColor = true;
            this.BtnIgual.Click += new System.EventHandler(this.BtnIgual_Click);
            // 
            // BtnVírgula
            // 
            this.BtnVírgula.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnVírgula.Location = new System.Drawing.Point(178, 325);
            this.BtnVírgula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnVírgula.Name = "BtnVírgula";
            this.BtnVírgula.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnVírgula.Size = new System.Drawing.Size(79, 44);
            this.BtnVírgula.TabIndex = 8;
            this.BtnVírgula.Text = ",";
            this.BtnVírgula.UseVisualStyleBackColor = true;
            this.BtnVírgula.Click += new System.EventHandler(this.BtnVírgula_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn0.Location = new System.Drawing.Point(94, 323);
            this.btn0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(79, 46);
            this.btn0.TabIndex = 27;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button14.Location = new System.Drawing.Point(10, 325);
            this.button14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(79, 44);
            this.button14.TabIndex = 18;
            this.button14.Text = "+/-";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // BtnMais
            // 
            this.BtnMais.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnMais.Location = new System.Drawing.Point(262, 274);
            this.BtnMais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnMais.Name = "BtnMais";
            this.BtnMais.Size = new System.Drawing.Size(79, 46);
            this.BtnMais.TabIndex = 1;
            this.BtnMais.Text = "+";
            this.BtnMais.UseVisualStyleBackColor = true;
            this.BtnMais.Click += new System.EventHandler(this.clickOperacao);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn3.Location = new System.Drawing.Point(178, 274);
            this.btn3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(79, 46);
            this.btn3.TabIndex = 28;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn2.Location = new System.Drawing.Point(94, 273);
            this.btn2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(79, 46);
            this.btn2.TabIndex = 29;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn1.Location = new System.Drawing.Point(10, 273);
            this.btn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(79, 46);
            this.btn1.TabIndex = 30;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.agregarNumero);
            // 
            // BtnMenos
            // 
            this.BtnMenos.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnMenos.Location = new System.Drawing.Point(262, 223);
            this.BtnMenos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnMenos.Name = "BtnMenos";
            this.BtnMenos.Size = new System.Drawing.Size(79, 46);
            this.BtnMenos.TabIndex = 4;
            this.BtnMenos.Text = "-";
            this.BtnMenos.UseVisualStyleBackColor = true;
            this.BtnMenos.Click += new System.EventHandler(this.clickOperacao);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn6.Location = new System.Drawing.Point(178, 224);
            this.btn6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(79, 46);
            this.btn6.TabIndex = 31;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn5.Location = new System.Drawing.Point(94, 224);
            this.btn5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(79, 46);
            this.btn5.TabIndex = 32;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn4.Location = new System.Drawing.Point(10, 223);
            this.btn4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(79, 46);
            this.btn4.TabIndex = 33;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.agregarNumero);
            // 
            // BtnVezez
            // 
            this.BtnVezez.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnVezez.Location = new System.Drawing.Point(262, 174);
            this.BtnVezez.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnVezez.Name = "BtnVezez";
            this.BtnVezez.Size = new System.Drawing.Size(79, 44);
            this.BtnVezez.TabIndex = 5;
            this.BtnVezez.Text = "x";
            this.BtnVezez.UseVisualStyleBackColor = true;
            this.BtnVezez.Click += new System.EventHandler(this.clickOperacao);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn9.Location = new System.Drawing.Point(178, 172);
            this.btn9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(79, 46);
            this.btn9.TabIndex = 34;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn8.Location = new System.Drawing.Point(94, 174);
            this.btn8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(79, 46);
            this.btn8.TabIndex = 35;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn7.Location = new System.Drawing.Point(10, 174);
            this.btn7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(79, 46);
            this.btn7.TabIndex = 36;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.agregarNumero);
            // 
            // BtnDivide
            // 
            this.BtnDivide.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnDivide.Location = new System.Drawing.Point(262, 124);
            this.BtnDivide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDivide.Name = "BtnDivide";
            this.BtnDivide.Size = new System.Drawing.Size(79, 46);
            this.BtnDivide.TabIndex = 6;
            this.BtnDivide.Text = "/";
            this.BtnDivide.UseVisualStyleBackColor = true;
            this.BtnDivide.Click += new System.EventHandler(this.clickOperacao);
            // 
            // btnPorcentagem
            // 
            this.btnPorcentagem.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPorcentagem.Location = new System.Drawing.Point(262, 74);
            this.btnPorcentagem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPorcentagem.Name = "btnPorcentagem";
            this.btnPorcentagem.Size = new System.Drawing.Size(79, 46);
            this.btnPorcentagem.TabIndex = 25;
            this.btnPorcentagem.Text = "%";
            this.btnPorcentagem.UseVisualStyleBackColor = true;
            this.btnPorcentagem.Click += new System.EventHandler(this.btnPorcentagem_Click);
            // 
            // BtnApagar
            // 
            this.BtnApagar.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnApagar.Location = new System.Drawing.Point(178, 73);
            this.BtnApagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnApagar.Name = "BtnApagar";
            this.BtnApagar.Size = new System.Drawing.Size(79, 97);
            this.BtnApagar.TabIndex = 22;
            this.BtnApagar.Text = "←";
            this.BtnApagar.UseVisualStyleBackColor = true;
            this.BtnApagar.Click += new System.EventHandler(this.BtnApagar_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnLimpar.Location = new System.Drawing.Point(94, 74);
            this.BtnLimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(79, 96);
            this.BtnLimpar.TabIndex = 23;
            this.BtnLimpar.Text = "C";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // cancelarRegistro
            // 
            this.cancelarRegistro.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelarRegistro.Location = new System.Drawing.Point(10, 74);
            this.cancelarRegistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelarRegistro.Name = "cancelarRegistro";
            this.cancelarRegistro.Size = new System.Drawing.Size(79, 96);
            this.cancelarRegistro.TabIndex = 24;
            this.cancelarRegistro.Text = "CE";
            this.cancelarRegistro.UseVisualStyleBackColor = true;
            this.cancelarRegistro.Click += new System.EventHandler(this.button2_Click);
            // 
            // TxtTeclado
            // 
            this.TxtTeclado.Location = new System.Drawing.Point(10, 6);
            this.TxtTeclado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtTeclado.Name = "TxtTeclado";
            this.TxtTeclado.Size = new System.Drawing.Size(82, 22);
            this.TxtTeclado.TabIndex = 26;
            this.TxtTeclado.UseVisualStyleBackColor = true;
            this.TxtTeclado.Visible = false;
            // 
            // panelHistorico
            // 
            this.panelHistorico.Location = new System.Drawing.Point(356, 62);
            this.panelHistorico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHistorico.Name = "panelHistorico";
            this.panelHistorico.Size = new System.Drawing.Size(328, 307);
            this.panelHistorico.TabIndex = 37;
            // 
            // LblMensagemHist
            // 
            this.LblMensagemHist.AutoSize = true;
            this.LblMensagemHist.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblMensagemHist.Location = new System.Drawing.Point(382, 39);
            this.LblMensagemHist.Name = "LblMensagemHist";
            this.LblMensagemHist.Size = new System.Drawing.Size(0, 21);
            this.LblMensagemHist.TabIndex = 1;
            // 
            // LimpaHist
            // 
            this.LimpaHist.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.LimpaHist.Location = new System.Drawing.Point(690, 342);
            this.LimpaHist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LimpaHist.Name = "LimpaHist";
            this.LimpaHist.Size = new System.Drawing.Size(22, 27);
            this.LimpaHist.TabIndex = 0;
            this.LimpaHist.Text = "🗑";
            this.LimpaHist.UseVisualStyleBackColor = false;
            this.LimpaHist.Click += new System.EventHandler(this.LimpaHist_Click);
            // 
            // btnHistorico
            // 
            this.btnHistorico.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnHistorico.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHistorico.Location = new System.Drawing.Point(382, 6);
            this.btnHistorico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(124, 27);
            this.btnHistorico.TabIndex = 38;
            this.btnHistorico.Text = "Histórico";
            this.btnHistorico.UseVisualStyleBackColor = false;
            // 
            // AtalhoHistorico
            // 
            this.AtalhoHistorico.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.AtalhoHistorico.Location = new System.Drawing.Point(318, 7);
            this.AtalhoHistorico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AtalhoHistorico.Name = "AtalhoHistorico";
            this.AtalhoHistorico.Size = new System.Drawing.Size(22, 22);
            this.AtalhoHistorico.TabIndex = 39;
            this.AtalhoHistorico.Text = "🕗";
            this.AtalhoHistorico.UseVisualStyleBackColor = false;
            this.AtalhoHistorico.Click += new System.EventHandler(this.AtalhoHistorico_Click);
            // 
            // LabelResultado
            // 
            this.LabelResultado.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelResultado.Location = new System.Drawing.Point(10, 34);
            this.LabelResultado.Name = "LabelResultado";
            this.LabelResultado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelResultado.Size = new System.Drawing.Size(330, 38);
            this.LabelResultado.TabIndex = 40;
            this.LabelResultado.Text = "0";
            this.LabelResultado.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(352, 386);
            this.Controls.Add(this.LabelResultado);
            this.Controls.Add(this.LblMensagemHist);
            this.Controls.Add(this.AtalhoHistorico);
            this.Controls.Add(this.LimpaHist);
            this.Controls.Add(this.btnHistorico);
            this.Controls.Add(this.panelHistorico);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.TxtTeclado);
            this.Controls.Add(this.btnPorcentagem);
            this.Controls.Add(this.cancelarRegistro);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnApagar);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.BtnVírgula);
            this.Controls.Add(this.BtnDivide);
            this.Controls.Add(this.BtnVezez);
            this.Controls.Add(this.BtnMenos);
            this.Controls.Add(this.BtnIgual);
            this.Controls.Add(this.LblValorCalcular);
            this.Controls.Add(this.BtnMais);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(740, 429);
            this.MinimumSize = new System.Drawing.Size(368, 425);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPrincipal_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Button btnHistorico;
        private Button AtalhoHistorico;
        private Button LimpaHist;
        private Label LblMensagemHist;
        private Label LabelResultado;
    }
}