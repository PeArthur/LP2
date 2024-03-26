namespace PImc
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.mskbxNum1 = new System.Windows.Forms.MaskedTextBox();
            this.mskbxNum2 = new System.Windows.Forms.MaskedTextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbl3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(83, 75);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(58, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Peso Atual";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(83, 121);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(34, 13);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Altura";
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(244, 168);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(225, 20);
            this.txtResult.TabIndex = 4;
            // 
            // mskbxNum1
            // 
            this.mskbxNum1.Location = new System.Drawing.Point(244, 68);
            this.mskbxNum1.Mask = "900.00";
            this.mskbxNum1.Name = "mskbxNum1";
            this.mskbxNum1.Size = new System.Drawing.Size(225, 20);
            this.mskbxNum1.TabIndex = 5;
            this.mskbxNum1.Validated += new System.EventHandler(this.mskbx1_Validated);
            // 
            // mskbxNum2
            // 
            this.mskbxNum2.Location = new System.Drawing.Point(244, 114);
            this.mskbxNum2.Mask = "0.00";
            this.mskbxNum2.Name = "mskbxNum2";
            this.mskbxNum2.Size = new System.Drawing.Size(225, 20);
            this.mskbxNum2.TabIndex = 6;
            this.mskbxNum2.Validated += new System.EventHandler(this.mskbx2_Validated);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(83, 319);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(126, 61);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(244, 319);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(126, 61);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(394, 319);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(126, 61);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(83, 174);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(26, 13);
            this.lbl3.TabIndex = 10;
            this.lbl3.Text = "IMC";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 450);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.mskbxNum2);
            this.Controls.Add(this.mskbxNum1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.MaskedTextBox mskbxNum1;
        private System.Windows.Forms.MaskedTextBox mskbxNum2;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbl3;
    }
}

