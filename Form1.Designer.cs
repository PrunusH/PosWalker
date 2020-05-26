namespace PosWalker {
    partial class Form1 {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.txtLeftPos = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtRightPos = new System.Windows.Forms.TextBox();
            this.chkbTopMost = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.upDownPacketsToSent = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.upDownPacketsToSent)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLeftPos
            // 
            this.txtLeftPos.Enabled = false;
            this.txtLeftPos.Location = new System.Drawing.Point(32, 23);
            this.txtLeftPos.Name = "txtLeftPos";
            this.txtLeftPos.Size = new System.Drawing.Size(133, 22);
            this.txtLeftPos.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salvar posição    ← esquerda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnSetLeftPos_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(185, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 47);
            this.button2.TabIndex = 3;
            this.button2.Text = "Salvar posição direita →";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnSetRightPos_Click);
            // 
            // txtRightPos
            // 
            this.txtRightPos.Enabled = false;
            this.txtRightPos.Location = new System.Drawing.Point(185, 23);
            this.txtRightPos.Name = "txtRightPos";
            this.txtRightPos.Size = new System.Drawing.Size(133, 22);
            this.txtRightPos.TabIndex = 2;
            // 
            // chkbTopMost
            // 
            this.chkbTopMost.AutoSize = true;
            this.chkbTopMost.Checked = true;
            this.chkbTopMost.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbTopMost.Location = new System.Drawing.Point(224, 147);
            this.chkbTopMost.Name = "chkbTopMost";
            this.chkbTopMost.Size = new System.Drawing.Size(80, 21);
            this.chkbTopMost.TabIndex = 4;
            this.chkbTopMost.Text = "topMost";
            this.chkbTopMost.UseVisualStyleBackColor = true;
            this.chkbTopMost.CheckStateChanged += new System.EventHandler(this.ChkbTopMost_CheckStateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Número de pacotes";
            // 
            // upDownPacketsToSent
            // 
            this.upDownPacketsToSent.Location = new System.Drawing.Point(35, 147);
            this.upDownPacketsToSent.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.upDownPacketsToSent.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upDownPacketsToSent.Name = "upDownPacketsToSent";
            this.upDownPacketsToSent.Size = new System.Drawing.Size(130, 22);
            this.upDownPacketsToSent.TabIndex = 6;
            this.upDownPacketsToSent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.upDownPacketsToSent.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(35, 176);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 29);
            this.button3.TabIndex = 7;
            this.button3.Text = "Alterar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BtnSetNoPacketsToSent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 226);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.upDownPacketsToSent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkbTopMost);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtRightPos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtLeftPos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PosWalker";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.upDownPacketsToSent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLeftPos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtRightPos;
        private System.Windows.Forms.CheckBox chkbTopMost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown upDownPacketsToSent;
        private System.Windows.Forms.Button button3;
    }
}

