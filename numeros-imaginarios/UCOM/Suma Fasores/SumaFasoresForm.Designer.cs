namespace UCOM.Suma_Fasores
{
    partial class SumaFasoresForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Fun1Txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Fun2Txt = new System.Windows.Forms.TextBox();
            this.SumarBtn = new System.Windows.Forms.Button();
            this.RsltTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Funcion 1";
            // 
            // Fun1Txt
            // 
            this.Fun1Txt.Location = new System.Drawing.Point(18, 42);
            this.Fun1Txt.Name = "Fun1Txt";
            this.Fun1Txt.Size = new System.Drawing.Size(393, 20);
            this.Fun1Txt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Funcion 2";
            // 
            // Fun2Txt
            // 
            this.Fun2Txt.Location = new System.Drawing.Point(18, 111);
            this.Fun2Txt.Name = "Fun2Txt";
            this.Fun2Txt.Size = new System.Drawing.Size(393, 20);
            this.Fun2Txt.TabIndex = 1;
            // 
            // SumarBtn
            // 
            this.SumarBtn.Location = new System.Drawing.Point(336, 216);
            this.SumarBtn.Name = "SumarBtn";
            this.SumarBtn.Size = new System.Drawing.Size(75, 23);
            this.SumarBtn.TabIndex = 2;
            this.SumarBtn.Text = "Sumar";
            this.SumarBtn.UseVisualStyleBackColor = true;
            this.SumarBtn.Click += new System.EventHandler(this.SumarBtn_Click);
            // 
            // RsltTxt
            // 
            this.RsltTxt.Location = new System.Drawing.Point(18, 190);
            this.RsltTxt.Name = "RsltTxt";
            this.RsltTxt.Size = new System.Drawing.Size(393, 20);
            this.RsltTxt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Resultado";
            // 
            // SumaFasoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 263);
            this.Controls.Add(this.SumarBtn);
            this.Controls.Add(this.RsltTxt);
            this.Controls.Add(this.Fun2Txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Fun1Txt);
            this.Controls.Add(this.label1);
            this.Name = "SumaFasoresForm";
            this.Text = "SumaFasoresForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Fun1Txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Fun2Txt;
        private System.Windows.Forms.Button SumarBtn;
        private System.Windows.Forms.TextBox RsltTxt;
        private System.Windows.Forms.Label label3;
    }
}