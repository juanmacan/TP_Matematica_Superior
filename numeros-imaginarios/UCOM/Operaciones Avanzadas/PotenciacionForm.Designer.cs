﻿namespace UCOM.Operaciones_Avanzadas
{
    partial class PotenciacionForm
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
            this.NumTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PotTxt = new System.Windows.Forms.TextBox();
            this.CalcBtn = new System.Windows.Forms.Button();
            this.RsltTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btmIngresarPINroComplejo = new System.Windows.Forms.Button();
            this.btmIngresarPIPotencia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumTxt
            // 
            this.NumTxt.Location = new System.Drawing.Point(13, 35);
            this.NumTxt.Name = "NumTxt";
            this.NumTxt.Size = new System.Drawing.Size(284, 20);
            this.NumTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero Complejo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Potencia";
            // 
            // PotTxt
            // 
            this.PotTxt.Location = new System.Drawing.Point(12, 74);
            this.PotTxt.Name = "PotTxt";
            this.PotTxt.Size = new System.Drawing.Size(285, 20);
            this.PotTxt.TabIndex = 0;
            // 
            // CalcBtn
            // 
            this.CalcBtn.Location = new System.Drawing.Point(222, 100);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(75, 23);
            this.CalcBtn.TabIndex = 3;
            this.CalcBtn.Text = "Calcular";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // RsltTxt
            // 
            this.RsltTxt.Location = new System.Drawing.Point(15, 189);
            this.RsltTxt.Name = "RsltTxt";
            this.RsltTxt.Size = new System.Drawing.Size(240, 20);
            this.RsltTxt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(15, 226);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btmIngresarPINroComplejo
            // 
            this.btmIngresarPINroComplejo.Location = new System.Drawing.Point(15, 100);
            this.btmIngresarPINroComplejo.Name = "btmIngresarPINroComplejo";
            this.btmIngresarPINroComplejo.Size = new System.Drawing.Size(201, 23);
            this.btmIngresarPINroComplejo.TabIndex = 12;
            this.btmIngresarPINroComplejo.Text = "Ingresar π (Pi) en Nro Complejo";
            this.btmIngresarPINroComplejo.UseVisualStyleBackColor = true;
            this.btmIngresarPINroComplejo.Click += new System.EventHandler(this.btmIngresarPINroComplejo_Click);
            // 
            // btmIngresarPIPotencia
            // 
            this.btmIngresarPIPotencia.Location = new System.Drawing.Point(15, 129);
            this.btmIngresarPIPotencia.Name = "btmIngresarPIPotencia";
            this.btmIngresarPIPotencia.Size = new System.Drawing.Size(201, 23);
            this.btmIngresarPIPotencia.TabIndex = 13;
            this.btmIngresarPIPotencia.Text = "Ingresar π (Pi) en potencia";
            this.btmIngresarPIPotencia.UseVisualStyleBackColor = true;
            this.btmIngresarPIPotencia.Click += new System.EventHandler(this.btmIngresarPIPotencia_Click);
            // 
            // PotenciacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 259);
            this.Controls.Add(this.btmIngresarPIPotencia);
            this.Controls.Add(this.btmIngresarPINroComplejo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.RsltTxt);
            this.Controls.Add(this.CalcBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PotTxt);
            this.Controls.Add(this.NumTxt);
            this.Name = "PotenciacionForm";
            this.Text = "Potenciacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PotTxt;
        private System.Windows.Forms.Button CalcBtn;
        private System.Windows.Forms.TextBox RsltTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btmIngresarPINroComplejo;
        private System.Windows.Forms.Button btmIngresarPIPotencia;
    }
}