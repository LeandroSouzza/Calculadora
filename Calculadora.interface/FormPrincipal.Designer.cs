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
            this.TxtValorCalcular = new System.Windows.Forms.TextBox();
            this.BtnMais = new System.Windows.Forms.Button();
            this.LblValorCalcular = new System.Windows.Forms.Label();
            this.BtnIgual = new System.Windows.Forms.Button();
            this.BtnMenos = new System.Windows.Forms.Button();
            this.BtnVezez = new System.Windows.Forms.Button();
            this.BtnDivide = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.BtnVírgula = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.btnPorcentagem = new System.Windows.Forms.Button();
            this.cancelarRegistro = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnApagar = new System.Windows.Forms.Button();
            this.BtnPercentual = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnRaizQuadrada = new System.Windows.Forms.Button();
            this.TxtTeclado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtValorCalcular
            // 
            this.TxtValorCalcular.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TxtValorCalcular.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtValorCalcular.Location = new System.Drawing.Point(12, 40);
            this.TxtValorCalcular.Name = "TxtValorCalcular";
            this.TxtValorCalcular.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtValorCalcular.Size = new System.Drawing.Size(378, 52);
            this.TxtValorCalcular.TabIndex = 0;
            this.TxtValorCalcular.Text = "0";
            this.TxtValorCalcular.TextChanged += new System.EventHandler(this.TxtValorCalcular_TextChanged);
            this.TxtValorCalcular.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtValorCalcular_KeyDown);
            this.TxtValorCalcular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValorCalcular_KeyPress);
            // 
            // BtnMais
            // 
            this.BtnMais.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnMais.Location = new System.Drawing.Point(299, 365);
            this.BtnMais.Name = "BtnMais";
            this.BtnMais.Size = new System.Drawing.Size(90, 62);
            this.BtnMais.TabIndex = 1;
            this.BtnMais.Text = "+";
            this.BtnMais.UseVisualStyleBackColor = true;
            this.BtnMais.Click += new System.EventHandler(this.BtnMais_Click);
            // 
            // LblValorCalcular
            // 
            this.LblValorCalcular.AutoSize = true;
            this.LblValorCalcular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblValorCalcular.Location = new System.Drawing.Point(12, 9);
            this.LblValorCalcular.Name = "LblValorCalcular";
            this.LblValorCalcular.Size = new System.Drawing.Size(0, 28);
            this.LblValorCalcular.TabIndex = 2;
            this.LblValorCalcular.Click += new System.EventHandler(this.LblValorCalcular_Click);
            // 
            // BtnIgual
            // 
            this.BtnIgual.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnIgual.Location = new System.Drawing.Point(299, 433);
            this.BtnIgual.Name = "BtnIgual";
            this.BtnIgual.Size = new System.Drawing.Size(90, 59);
            this.BtnIgual.TabIndex = 3;
            this.BtnIgual.Text = "=";
            this.BtnIgual.UseVisualStyleBackColor = true;
            this.BtnIgual.Click += new System.EventHandler(this.BtnIgual_Click);
            // 
            // BtnMenos
            // 
            this.BtnMenos.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnMenos.Location = new System.Drawing.Point(299, 297);
            this.BtnMenos.Name = "BtnMenos";
            this.BtnMenos.Size = new System.Drawing.Size(90, 62);
            this.BtnMenos.TabIndex = 4;
            this.BtnMenos.Text = "-";
            this.BtnMenos.UseVisualStyleBackColor = true;
            this.BtnMenos.Click += new System.EventHandler(this.BtnMenos_Click);
            // 
            // BtnVezez
            // 
            this.BtnVezez.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnVezez.Location = new System.Drawing.Point(299, 232);
            this.BtnVezez.Name = "BtnVezez";
            this.BtnVezez.Size = new System.Drawing.Size(90, 59);
            this.BtnVezez.TabIndex = 5;
            this.BtnVezez.Text = "x";
            this.BtnVezez.UseVisualStyleBackColor = true;
            this.BtnVezez.Click += new System.EventHandler(this.BtnVezez_Click);
            // 
            // BtnDivide
            // 
            this.BtnDivide.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnDivide.Location = new System.Drawing.Point(299, 165);
            this.BtnDivide.Name = "BtnDivide";
            this.BtnDivide.Size = new System.Drawing.Size(90, 61);
            this.BtnDivide.TabIndex = 6;
            this.BtnDivide.Text = "/";
            this.BtnDivide.UseVisualStyleBackColor = true;
            this.BtnDivide.Click += new System.EventHandler(this.BtnDivide_Click);
            // 
            // Btn9
            // 
            this.Btn9.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn9.Location = new System.Drawing.Point(203, 232);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(90, 59);
            this.Btn9.TabIndex = 10;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = true;
            this.Btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // Btn6
            // 
            this.Btn6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn6.Location = new System.Drawing.Point(203, 297);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(90, 62);
            this.Btn6.TabIndex = 9;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = true;
            this.Btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // BtnVírgula
            // 
            this.BtnVírgula.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnVírgula.Location = new System.Drawing.Point(203, 433);
            this.BtnVírgula.Name = "BtnVírgula";
            this.BtnVírgula.Size = new System.Drawing.Size(90, 59);
            this.BtnVírgula.TabIndex = 8;
            this.BtnVírgula.Text = ",";
            this.BtnVírgula.UseVisualStyleBackColor = true;
            this.BtnVírgula.Click += new System.EventHandler(this.BtnVírgula_Click);
            // 
            // Btn3
            // 
            this.Btn3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn3.Location = new System.Drawing.Point(203, 365);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(90, 62);
            this.Btn3.TabIndex = 7;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // Btn8
            // 
            this.Btn8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn8.Location = new System.Drawing.Point(107, 232);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(90, 59);
            this.Btn8.TabIndex = 15;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = true;
            this.Btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // Btn5
            // 
            this.Btn5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn5.Location = new System.Drawing.Point(107, 297);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(90, 62);
            this.Btn5.TabIndex = 14;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = true;
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // Btn0
            // 
            this.Btn0.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn0.Location = new System.Drawing.Point(107, 433);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(90, 59);
            this.Btn0.TabIndex = 13;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = true;
            this.Btn0.Click += new System.EventHandler(this.Btn0_Click);
            // 
            // Btn2
            // 
            this.Btn2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn2.Location = new System.Drawing.Point(107, 365);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(90, 62);
            this.Btn2.TabIndex = 12;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn7
            // 
            this.Btn7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn7.Location = new System.Drawing.Point(11, 232);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(90, 59);
            this.Btn7.TabIndex = 20;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = true;
            this.Btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // Btn4
            // 
            this.Btn4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn4.Location = new System.Drawing.Point(11, 297);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(90, 62);
            this.Btn4.TabIndex = 19;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button14.Location = new System.Drawing.Point(11, 433);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(90, 59);
            this.button14.TabIndex = 18;
            this.button14.Text = "+/-";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // Btn1
            // 
            this.Btn1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn1.Location = new System.Drawing.Point(11, 365);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(90, 62);
            this.Btn1.TabIndex = 17;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // btnPorcentagem
            // 
            this.btnPorcentagem.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPorcentagem.Location = new System.Drawing.Point(12, 165);
            this.btnPorcentagem.Name = "btnPorcentagem";
            this.btnPorcentagem.Size = new System.Drawing.Size(90, 61);
            this.btnPorcentagem.TabIndex = 25;
            this.btnPorcentagem.Text = "%";
            this.btnPorcentagem.UseVisualStyleBackColor = true;
            this.btnPorcentagem.Click += new System.EventHandler(this.btnPorcentagem_Click);
            // 
            // cancelarRegistro
            // 
            this.cancelarRegistro.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelarRegistro.Location = new System.Drawing.Point(107, 165);
            this.cancelarRegistro.Name = "cancelarRegistro";
            this.cancelarRegistro.Size = new System.Drawing.Size(90, 61);
            this.cancelarRegistro.TabIndex = 24;
            this.cancelarRegistro.Text = "CE";
            this.cancelarRegistro.UseVisualStyleBackColor = true;
            this.cancelarRegistro.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnLimpar.Location = new System.Drawing.Point(203, 165);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(90, 61);
            this.BtnLimpar.TabIndex = 23;
            this.BtnLimpar.Text = "C";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnApagar
            // 
            this.BtnApagar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnApagar.Location = new System.Drawing.Point(299, 98);
            this.BtnApagar.Name = "BtnApagar";
            this.BtnApagar.Size = new System.Drawing.Size(90, 61);
            this.BtnApagar.TabIndex = 22;
            this.BtnApagar.Text = "(x)";
            this.BtnApagar.UseVisualStyleBackColor = true;
            this.BtnApagar.Click += new System.EventHandler(this.BtnApagar_Click);
            // 
            // BtnPercentual
            // 
            this.BtnPercentual.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnPercentual.Location = new System.Drawing.Point(11, 98);
            this.BtnPercentual.Name = "BtnPercentual";
            this.BtnPercentual.Size = new System.Drawing.Size(90, 61);
            this.BtnPercentual.TabIndex = 21;
            this.BtnPercentual.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCancelar.Location = new System.Drawing.Point(107, 98);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(90, 61);
            this.BtnCancelar.TabIndex = 16;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnRaizQuadrada
            // 
            this.BtnRaizQuadrada.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnRaizQuadrada.Location = new System.Drawing.Point(203, 98);
            this.BtnRaizQuadrada.Name = "BtnRaizQuadrada";
            this.BtnRaizQuadrada.Size = new System.Drawing.Size(90, 61);
            this.BtnRaizQuadrada.TabIndex = 11;
            this.BtnRaizQuadrada.UseVisualStyleBackColor = true;
            // 
            // TxtTeclado
            // 
            this.TxtTeclado.Location = new System.Drawing.Point(83, 5);
            this.TxtTeclado.Name = "TxtTeclado";
            this.TxtTeclado.Size = new System.Drawing.Size(94, 29);
            this.TxtTeclado.TabIndex = 26;
            this.TxtTeclado.UseVisualStyleBackColor = true;
            this.TxtTeclado.Visible = false;
            this.TxtTeclado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtTeclado_KeyDown);
            this.TxtTeclado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTeclado_KeyPress);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 495);
            this.Controls.Add(this.TxtTeclado);
            this.Controls.Add(this.btnPorcentagem);
            this.Controls.Add(this.cancelarRegistro);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnApagar);
            this.Controls.Add(this.BtnPercentual);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.BtnRaizQuadrada);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.BtnVírgula);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.BtnDivide);
            this.Controls.Add(this.BtnVezez);
            this.Controls.Add(this.BtnMenos);
            this.Controls.Add(this.BtnIgual);
            this.Controls.Add(this.LblValorCalcular);
            this.Controls.Add(this.BtnMais);
            this.Controls.Add(this.TxtValorCalcular);
            this.KeyPreview = true;
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPrincipal_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormPrincipal_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private TextBox TxtValorCalcular;
    private Button BtnMais;
    private Label LblValorCalcular;
    private Button BtnIgual;
        private Button BtnMenos;
        private Button BtnVezez;
        private Button BtnDivide;
        private Button Btn9;
        private Button Btn6;
        private Button BtnVírgula;
        private Button Btn3;
        private Button Btn8;
        private Button Btn5;
        private Button Btn0;
        private Button Btn2;
        private Button Btn7;
        private Button Btn4;
        private Button button14;
        private Button Btn1;
        private Button btnPorcentagem;
        private Button cancelarRegistro;
        private Button BtnLimpar;
        private Button BtnApagar;
        private Button BtnPercentual;
        private Button BtnCancelar;
        private Button BtnRaizQuadrada;
        private Button TxtTeclado;
    }
}