﻿namespace UCOM.Suma_Fasores
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
            this.btnCos = new System.Windows.Forms.Button();
            this.btnSen = new System.Windows.Forms.Button();
            this.btnPi = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
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
            this.label1.Text = "Función 1";
            // 
            // Fun1Txt
            // 
            this.Fun1Txt.Location = new System.Drawing.Point(18, 42);
            this.Fun1Txt.Name = "Fun1Txt";
            this.Fun1Txt.Size = new System.Drawing.Size(204, 20);
            this.Fun1Txt.TabIndex = 1;
            this.Fun1Txt.TabStop = false;
            this.Fun1Txt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Fun1Txt_MouseClick);
            this.Fun1Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Fun1Txt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Función 2";
            // 
            // Fun2Txt
            // 
            this.Fun2Txt.Location = new System.Drawing.Point(237, 42);
            this.Fun2Txt.Name = "Fun2Txt";
            this.Fun2Txt.Size = new System.Drawing.Size(204, 20);
            this.Fun2Txt.TabIndex = 2;
            this.Fun2Txt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Fun2Txt_MouseClick);
            this.Fun2Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Fun2Txt_KeyPress);
            // 
            // SumarBtn
            // 
            this.SumarBtn.Location = new System.Drawing.Point(336, 174);
            this.SumarBtn.Name = "SumarBtn";
            this.SumarBtn.Size = new System.Drawing.Size(75, 23);
            this.SumarBtn.TabIndex = 2;
            this.SumarBtn.Text = "Sumar";
            this.SumarBtn.UseVisualStyleBackColor = true;
            this.SumarBtn.Click += new System.EventHandler(this.SumarBtn_Click);
            // 
            // RsltTxt
            // 
            this.RsltTxt.Location = new System.Drawing.Point(18, 148);
            this.RsltTxt.Name = "RsltTxt";
            this.RsltTxt.Size = new System.Drawing.Size(393, 20);
            this.RsltTxt.TabIndex = 3;
            this.RsltTxt.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Resultado";
            // 
            // btnCos
            // 
            this.btnCos.Location = new System.Drawing.Point(18, 85);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(75, 23);
            this.btnCos.TabIndex = 3;
            this.btnCos.Text = "COS ( )";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.BtnCos_Click);
            // 
            // btnSen
            // 
            this.btnSen.Location = new System.Drawing.Point(99, 85);
            this.btnSen.Name = "btnSen";
            this.btnSen.Size = new System.Drawing.Size(75, 23);
            this.btnSen.TabIndex = 4;
            this.btnSen.Text = "SEN ( )";
            this.btnSen.UseVisualStyleBackColor = true;
            this.btnSen.Click += new System.EventHandler(this.BtnSen_Click);
            // 
            // btnPi
            // 
            this.btnPi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPi.Location = new System.Drawing.Point(180, 85);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(75, 23);
            this.btnPi.TabIndex = 5;
            this.btnPi.Text = "π";
            this.btnPi.UseVisualStyleBackColor = true;
            this.btnPi.Click += new System.EventHandler(this.BtnPi_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(261, 85);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(95, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(18, 174);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // SumaFasoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 220);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnPi);
            this.Controls.Add(this.btnSen);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.SumarBtn);
            this.Controls.Add(this.RsltTxt);
            this.Controls.Add(this.Fun2Txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Fun1Txt);
            this.Controls.Add(this.label1);
            this.Name = "SumaFasoresForm";
            this.Text = "Fasores";
            this.Load += new System.EventHandler(this.SumaFasoresForm_Load);
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
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnSen;
        private System.Windows.Forms.Button btnPi;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
    }
}