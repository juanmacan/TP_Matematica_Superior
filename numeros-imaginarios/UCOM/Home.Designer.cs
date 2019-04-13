namespace UCOM
{
    partial class Home
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblEDT = new System.Windows.Forms.Label();
            this.lblOB = new System.Windows.Forms.Label();
            this.lblOA = new System.Windows.Forms.Label();
            this.lblSF = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Location = new System.Drawing.Point(53, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 171);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox2.Location = new System.Drawing.Point(266, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(166, 171);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Lime;
            this.pictureBox3.Location = new System.Drawing.Point(53, 241);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(166, 171);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Blue;
            this.pictureBox4.Location = new System.Drawing.Point(266, 241);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(166, 171);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // lblEDT
            // 
            this.lblEDT.BackColor = System.Drawing.Color.Red;
            this.lblEDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEDT.Location = new System.Drawing.Point(66, 67);
            this.lblEDT.Margin = new System.Windows.Forms.Padding(10);
            this.lblEDT.Name = "lblEDT";
            this.lblEDT.Size = new System.Drawing.Size(138, 132);
            this.lblEDT.TabIndex = 4;
            this.lblEDT.Text = "EDT";
            this.lblEDT.Click += new System.EventHandler(this.lblEDT_Click);
            // 
            // lblOB
            // 
            this.lblOB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOB.Location = new System.Drawing.Point(280, 67);
            this.lblOB.Margin = new System.Windows.Forms.Padding(10);
            this.lblOB.Name = "lblOB";
            this.lblOB.Size = new System.Drawing.Size(138, 132);
            this.lblOB.TabIndex = 5;
            this.lblOB.Text = "OB";
            this.lblOB.Click += new System.EventHandler(this.LblOB_Click);
            // 
            // lblOA
            // 
            this.lblOA.BackColor = System.Drawing.Color.Lime;
            this.lblOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOA.Location = new System.Drawing.Point(66, 263);
            this.lblOA.Margin = new System.Windows.Forms.Padding(10);
            this.lblOA.Name = "lblOA";
            this.lblOA.Size = new System.Drawing.Size(138, 132);
            this.lblOA.TabIndex = 6;
            this.lblOA.Text = "OA";
            this.lblOA.Click += new System.EventHandler(this.LblOA_Click);
            // 
            // lblSF
            // 
            this.lblSF.BackColor = System.Drawing.Color.Blue;
            this.lblSF.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSF.Location = new System.Drawing.Point(280, 263);
            this.lblSF.Margin = new System.Windows.Forms.Padding(10);
            this.lblSF.Name = "lblSF";
            this.lblSF.Size = new System.Drawing.Size(138, 132);
            this.lblSF.TabIndex = 7;
            this.lblSF.Text = "SF";
            this.lblSF.Click += new System.EventHandler(this.LblSF_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(503, 478);
            this.Controls.Add(this.lblSF);
            this.Controls.Add(this.lblOA);
            this.Controls.Add(this.lblOB);
            this.Controls.Add(this.lblEDT);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblEDT;
        private System.Windows.Forms.Label lblOB;
        private System.Windows.Forms.Label lblOA;
        private System.Windows.Forms.Label lblSF;
    }
}

