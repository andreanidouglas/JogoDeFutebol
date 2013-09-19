namespace Jogo_de_Futeboll
{
    partial class frmAddTime
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tdbtNome = new System.Windows.Forms.TextBox();
            this.tdbtDefesa = new System.Windows.Forms.TextBox();
            this.tdbtAtaque = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Do Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Força de Ataque:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Força de Defesa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Adcionar Time";
            // 
            // tdbtNome
            // 
            this.tdbtNome.Location = new System.Drawing.Point(135, 53);
            this.tdbtNome.Name = "tdbtNome";
            this.tdbtNome.Size = new System.Drawing.Size(145, 22);
            this.tdbtNome.TabIndex = 0;
            // 
            // tdbtDefesa
            // 
            this.tdbtDefesa.Location = new System.Drawing.Point(135, 103);
            this.tdbtDefesa.Name = "tdbtDefesa";
            this.tdbtDefesa.Size = new System.Drawing.Size(145, 22);
            this.tdbtDefesa.TabIndex = 2;
            // 
            // tdbtAtaque
            // 
            this.tdbtAtaque.Location = new System.Drawing.Point(135, 78);
            this.tdbtAtaque.Name = "tdbtAtaque";
            this.tdbtAtaque.Size = new System.Drawing.Size(145, 22);
            this.tdbtAtaque.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(109, 157);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 28);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Adcionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmAddTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 203);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tdbtAtaque);
            this.Controls.Add(this.tdbtDefesa);
            this.Controls.Add(this.tdbtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAddTime";
            this.Text = "Adcionar Time";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tdbtNome;
        private System.Windows.Forms.TextBox tdbtDefesa;
        private System.Windows.Forms.TextBox tdbtAtaque;
        private System.Windows.Forms.Button btnAdd;
    }
}