namespace UCOM.Operaciones_Avanzadas
{
    partial class OAForm
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
            this.PotenciaBtn = new System.Windows.Forms.Button();
            this.RadBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operaciones Avanzadas";
            // 
            // PotenciaBtn
            // 
            this.PotenciaBtn.Location = new System.Drawing.Point(17, 63);
            this.PotenciaBtn.Name = "PotenciaBtn";
            this.PotenciaBtn.Size = new System.Drawing.Size(223, 23);
            this.PotenciaBtn.TabIndex = 1;
            this.PotenciaBtn.Text = "Potenciacion";
            this.PotenciaBtn.UseVisualStyleBackColor = true;
            this.PotenciaBtn.Click += new System.EventHandler(this.PotenciaBtn_Click);
            // 
            // RadBtn
            // 
            this.RadBtn.Location = new System.Drawing.Point(17, 92);
            this.RadBtn.Name = "RadBtn";
            this.RadBtn.Size = new System.Drawing.Size(223, 23);
            this.RadBtn.TabIndex = 1;
            this.RadBtn.Text = "Radicacion";
            this.RadBtn.UseVisualStyleBackColor = true;
            this.RadBtn.Click += new System.EventHandler(this.RadBtn_Click);
            // 
            // OAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 148);
            this.Controls.Add(this.RadBtn);
            this.Controls.Add(this.PotenciaBtn);
            this.Controls.Add(this.label1);
            this.Name = "OAForm";
            this.Text = "OAForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PotenciaBtn;
        private System.Windows.Forms.Button RadBtn;
    }
}