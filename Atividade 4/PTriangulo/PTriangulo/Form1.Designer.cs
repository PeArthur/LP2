namespace PTriangulo
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
            this.lblLd1 = new System.Windows.Forms.Label();
            this.lblLd2 = new System.Windows.Forms.Label();
            this.lblLd3 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnCleam = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtLd1 = new System.Windows.Forms.TextBox();
            this.txtLd2 = new System.Windows.Forms.TextBox();
            this.txtLd3 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLd1
            // 
            this.lblLd1.AutoSize = true;
            this.lblLd1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLd1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLd1.Location = new System.Drawing.Point(46, 59);
            this.lblLd1.Name = "lblLd1";
            this.lblLd1.Size = new System.Drawing.Size(65, 23);
            this.lblLd1.TabIndex = 0;
            this.lblLd1.Text = "Lado:";
            // 
            // lblLd2
            // 
            this.lblLd2.AutoSize = true;
            this.lblLd2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLd2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLd2.Location = new System.Drawing.Point(46, 100);
            this.lblLd2.Name = "lblLd2";
            this.lblLd2.Size = new System.Drawing.Size(65, 23);
            this.lblLd2.TabIndex = 1;
            this.lblLd2.Text = "Lado:";
            // 
            // lblLd3
            // 
            this.lblLd3.AutoSize = true;
            this.lblLd3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLd3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLd3.Location = new System.Drawing.Point(46, 138);
            this.lblLd3.Name = "lblLd3";
            this.lblLd3.Size = new System.Drawing.Size(65, 23);
            this.lblLd3.TabIndex = 2;
            this.lblLd3.Text = "Lado:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResult.Location = new System.Drawing.Point(-2, 183);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(113, 23);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Resultado:";
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnCalc.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalc.Location = new System.Drawing.Point(8, 257);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(112, 76);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnCleam
            // 
            this.btnCleam.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnCleam.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCleam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCleam.Location = new System.Drawing.Point(170, 257);
            this.btnCleam.Name = "btnCleam";
            this.btnCleam.Size = new System.Drawing.Size(112, 76);
            this.btnCleam.TabIndex = 5;
            this.btnCleam.Text = "Limpar";
            this.btnCleam.UseVisualStyleBackColor = false;
            this.btnCleam.Click += new System.EventHandler(this.btnCleam_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnExit.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(329, 257);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 76);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtLd1
            // 
            this.txtLd1.Location = new System.Drawing.Point(117, 62);
            this.txtLd1.Name = "txtLd1";
            this.txtLd1.Size = new System.Drawing.Size(324, 20);
            this.txtLd1.TabIndex = 7;
            this.txtLd1.Validated += new System.EventHandler(this.txtLd1_Validated);
            // 
            // txtLd2
            // 
            this.txtLd2.Location = new System.Drawing.Point(117, 101);
            this.txtLd2.Name = "txtLd2";
            this.txtLd2.Size = new System.Drawing.Size(324, 20);
            this.txtLd2.TabIndex = 8;
            this.txtLd2.Validated += new System.EventHandler(this.txtLd2_Validated);
            // 
            // txtLd3
            // 
            this.txtLd3.Location = new System.Drawing.Point(117, 141);
            this.txtLd3.Name = "txtLd3";
            this.txtLd3.Size = new System.Drawing.Size(324, 20);
            this.txtLd3.TabIndex = 9;
            this.txtLd3.Validated += new System.EventHandler(this.txtLd3_Validated);
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(117, 186);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(324, 20);
            this.txtResult.TabIndex = 10;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(172, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(179, 38);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "É Triângulo?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 390);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtLd3);
            this.Controls.Add(this.txtLd2);
            this.Controls.Add(this.txtLd1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCleam);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblLd3);
            this.Controls.Add(this.lblLd2);
            this.Controls.Add(this.lblLd1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLd1;
        private System.Windows.Forms.Label lblLd2;
        private System.Windows.Forms.Label lblLd3;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnCleam;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtLd1;
        private System.Windows.Forms.TextBox txtLd2;
        private System.Windows.Forms.TextBox txtLd3;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblTitle;
    }
}

