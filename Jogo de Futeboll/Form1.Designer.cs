namespace Jogo_de_Futeboll
{
    partial class Form1
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Times = new System.Windows.Forms.Panel();
            this.btnAddTime = new System.Windows.Forms.Button();
            this.lblNumeroTimes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTimes = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.Times.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jogo De Futebol";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(243, 64);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(127, 194);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Times
            // 
            this.Times.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Times.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Times.Controls.Add(this.btnAddTime);
            this.Times.Controls.Add(this.lblNumeroTimes);
            this.Times.Controls.Add(this.label2);
            this.Times.Controls.Add(this.lblTimes);
            this.Times.Location = new System.Drawing.Point(25, 64);
            this.Times.Name = "Times";
            this.Times.Size = new System.Drawing.Size(183, 115);
            this.Times.TabIndex = 3;
            // 
            // btnAddTime
            // 
            this.btnAddTime.Location = new System.Drawing.Point(22, 61);
            this.btnAddTime.Name = "btnAddTime";
            this.btnAddTime.Size = new System.Drawing.Size(136, 40);
            this.btnAddTime.TabIndex = 3;
            this.btnAddTime.Text = "Adcionar Time";
            this.btnAddTime.UseVisualStyleBackColor = true;
            this.btnAddTime.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNumeroTimes
            // 
            this.lblNumeroTimes.AutoSize = true;
            this.lblNumeroTimes.Location = new System.Drawing.Point(142, 32);
            this.lblNumeroTimes.Name = "lblNumeroTimes";
            this.lblNumeroTimes.Size = new System.Drawing.Size(16, 17);
            this.lblNumeroTimes.TabIndex = 2;
            this.lblNumeroTimes.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero De Times:";
            // 
            // lblTimes
            // 
            this.lblTimes.AutoSize = true;
            this.lblTimes.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimes.Location = new System.Drawing.Point(63, 1);
            this.lblTimes.Name = "lblTimes";
            this.lblTimes.Size = new System.Drawing.Size(51, 21);
            this.lblTimes.TabIndex = 0;
            this.lblTimes.Text = "Times";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(83, 314);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(231, 81);
            this.btnIniciar.TabIndex = 4;
            this.btnIniciar.Text = "Iniciar Campeonato";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 407);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Times);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Times.ResumeLayout(false);
            this.Times.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel Times;
        private System.Windows.Forms.Button btnAddTime;
        private System.Windows.Forms.Label lblNumeroTimes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTimes;
        private System.Windows.Forms.Button btnIniciar;
    }
}

