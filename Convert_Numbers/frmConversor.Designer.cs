namespace Convert_Numbers
{
    partial class frmConversor
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
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblDec = new System.Windows.Forms.Label();
            this.lblHex = new System.Windows.Forms.Label();
            this.lblOct = new System.Windows.Forms.Label();
            this.lblBinary = new System.Windows.Forms.Label();
            this.txtBin = new System.Windows.Forms.TextBox();
            this.txtOct = new System.Windows.Forms.TextBox();
            this.txtDec = new System.Windows.Forms.TextBox();
            this.txtHex = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(110, 12);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 1;
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "Binário",
            "Octal",
            "Decimal",
            "Hexadecimal"});
            this.cboType.Location = new System.Drawing.Point(12, 12);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(89, 21);
            this.cboType.TabIndex = 0;
            // 
            // btnCalc
            // 
            this.btnCalc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalc.Location = new System.Drawing.Point(216, 10);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblDec
            // 
            this.lblDec.AutoSize = true;
            this.lblDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDec.Location = new System.Drawing.Point(19, 94);
            this.lblDec.Name = "lblDec";
            this.lblDec.Size = new System.Drawing.Size(74, 20);
            this.lblDec.TabIndex = 3;
            this.lblDec.Text = "Decimal: ";
            // 
            // lblHex
            // 
            this.lblHex.AutoSize = true;
            this.lblHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHex.Location = new System.Drawing.Point(19, 119);
            this.lblHex.Name = "lblHex";
            this.lblHex.Size = new System.Drawing.Size(104, 20);
            this.lblHex.TabIndex = 4;
            this.lblHex.Text = "Hexadecimal:";
            // 
            // lblOct
            // 
            this.lblOct.AutoSize = true;
            this.lblOct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOct.Location = new System.Drawing.Point(19, 69);
            this.lblOct.Name = "lblOct";
            this.lblOct.Size = new System.Drawing.Size(54, 20);
            this.lblOct.TabIndex = 5;
            this.lblOct.Text = "Octal: ";
            // 
            // lblBinary
            // 
            this.lblBinary.AutoSize = true;
            this.lblBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBinary.Location = new System.Drawing.Point(19, 44);
            this.lblBinary.Name = "lblBinary";
            this.lblBinary.Size = new System.Drawing.Size(58, 20);
            this.lblBinary.TabIndex = 6;
            this.lblBinary.Text = "Binário";
            // 
            // txtBin
            // 
            this.txtBin.Location = new System.Drawing.Point(129, 46);
            this.txtBin.Name = "txtBin";
            this.txtBin.ReadOnly = true;
            this.txtBin.Size = new System.Drawing.Size(162, 20);
            this.txtBin.TabIndex = 7;
            // 
            // txtOct
            // 
            this.txtOct.Location = new System.Drawing.Point(129, 71);
            this.txtOct.Name = "txtOct";
            this.txtOct.ReadOnly = true;
            this.txtOct.Size = new System.Drawing.Size(162, 20);
            this.txtOct.TabIndex = 8;
            // 
            // txtDec
            // 
            this.txtDec.Location = new System.Drawing.Point(129, 96);
            this.txtDec.Name = "txtDec";
            this.txtDec.ReadOnly = true;
            this.txtDec.Size = new System.Drawing.Size(162, 20);
            this.txtDec.TabIndex = 9;
            // 
            // txtHex
            // 
            this.txtHex.Location = new System.Drawing.Point(129, 121);
            this.txtHex.Name = "txtHex";
            this.txtHex.ReadOnly = true;
            this.txtHex.Size = new System.Drawing.Size(162, 20);
            this.txtHex.TabIndex = 10;
            // 
            // frmConversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 147);
            this.Controls.Add(this.txtHex);
            this.Controls.Add(this.txtDec);
            this.Controls.Add(this.txtOct);
            this.Controls.Add(this.txtBin);
            this.Controls.Add(this.lblBinary);
            this.Controls.Add(this.lblOct);
            this.Controls.Add(this.lblHex);
            this.Controls.Add(this.lblDec);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.txtNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmConversor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Converter Números";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblDec;
        private System.Windows.Forms.Label lblHex;
        private System.Windows.Forms.Label lblOct;
        private System.Windows.Forms.Label lblBinary;
        private System.Windows.Forms.TextBox txtBin;
        private System.Windows.Forms.TextBox txtOct;
        private System.Windows.Forms.TextBox txtDec;
        private System.Windows.Forms.TextBox txtHex;
    }
}

