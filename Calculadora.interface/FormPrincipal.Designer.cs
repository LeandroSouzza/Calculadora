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
            this.TxtValorCalcular = new System.Windows.Forms.TextBox();
            this.BtnMais = new System.Windows.Forms.Button();
            this.LblValorCalcular = new System.Windows.Forms.Label();
            this.BtnIgual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtValorCalcular
            // 
            this.TxtValorCalcular.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtValorCalcular.Location = new System.Drawing.Point(12, 40);
            this.TxtValorCalcular.Name = "TxtValorCalcular";
            this.TxtValorCalcular.Size = new System.Drawing.Size(306, 52);
            this.TxtValorCalcular.TabIndex = 0;
            this.TxtValorCalcular.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnMais
            // 
            this.BtnMais.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnMais.Location = new System.Drawing.Point(12, 98);
            this.BtnMais.Name = "BtnMais";
            this.BtnMais.Size = new System.Drawing.Size(102, 99);
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
            this.LblValorCalcular.Size = new System.Drawing.Size(23, 28);
            this.LblValorCalcular.TabIndex = 2;
            this.LblValorCalcular.Text = "0";
            // 
            // BtnIgual
            // 
            this.BtnIgual.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnIgual.Location = new System.Drawing.Point(216, 393);
            this.BtnIgual.Name = "BtnIgual";
            this.BtnIgual.Size = new System.Drawing.Size(102, 99);
            this.BtnIgual.TabIndex = 3;
            this.BtnIgual.Text = "=";
            this.BtnIgual.UseVisualStyleBackColor = true;
            this.BtnIgual.Click += new System.EventHandler(this.BtnIgual_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 504);
            this.Controls.Add(this.BtnIgual);
            this.Controls.Add(this.LblValorCalcular);
            this.Controls.Add(this.BtnMais);
            this.Controls.Add(this.TxtValorCalcular);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private TextBox TxtValorCalcular;
    private Button BtnMais;
    private Label LblValorCalcular;
    private Button BtnIgual;
}
}