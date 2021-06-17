namespace Quiz_100_anos_Unasp
{
    partial class perguntas_Medio
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
            this.button1 = new System.Windows.Forms.Button();
            this.rdbalternativa3 = new System.Windows.Forms.RadioButton();
            this.rdbalternativa2 = new System.Windows.Forms.RadioButton();
            this.rdbalternativa1 = new System.Windows.Forms.RadioButton();
            this.lblpergunta = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(-1, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(999, 55);
            this.button1.TabIndex = 9;
            this.button1.Text = "Proxima pergunta";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdbalternativa3
            // 
            this.rdbalternativa3.AutoSize = true;
            this.rdbalternativa3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbalternativa3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdbalternativa3.Location = new System.Drawing.Point(70, 252);
            this.rdbalternativa3.Name = "rdbalternativa3";
            this.rdbalternativa3.Size = new System.Drawing.Size(192, 22);
            this.rdbalternativa3.TabIndex = 8;
            this.rdbalternativa3.Text = "C - Ciências Contábeis";
            this.rdbalternativa3.UseVisualStyleBackColor = true;
            // 
            // rdbalternativa2
            // 
            this.rdbalternativa2.AutoSize = true;
            this.rdbalternativa2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbalternativa2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdbalternativa2.Location = new System.Drawing.Point(70, 191);
            this.rdbalternativa2.Name = "rdbalternativa2";
            this.rdbalternativa2.Size = new System.Drawing.Size(182, 22);
            this.rdbalternativa2.TabIndex = 7;
            this.rdbalternativa2.Text = "B - Ciências Médicas";
            this.rdbalternativa2.UseVisualStyleBackColor = true;
            // 
            // rdbalternativa1
            // 
            this.rdbalternativa1.AutoSize = true;
            this.rdbalternativa1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbalternativa1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdbalternativa1.Location = new System.Drawing.Point(70, 143);
            this.rdbalternativa1.Name = "rdbalternativa1";
            this.rdbalternativa1.Size = new System.Drawing.Size(204, 22);
            this.rdbalternativa1.TabIndex = 6;
            this.rdbalternativa1.Text = "A - Ciência Aeronautica";
            this.rdbalternativa1.UseVisualStyleBackColor = true;
            // 
            // lblpergunta
            // 
            this.lblpergunta.AutoSize = true;
            this.lblpergunta.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpergunta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblpergunta.Location = new System.Drawing.Point(3, 0);
            this.lblpergunta.Name = "lblpergunta";
            this.lblpergunta.Size = new System.Drawing.Size(739, 42);
            this.lblpergunta.TabIndex = 5;
            this.lblpergunta.Text = "A UNASP-SP possui três cursos que se designam (Ciências): Ciência da Computação,\r" +
    "\n Ciências Biológicas e qual é o outro curso?";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.lblpergunta);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(999, 51);
            this.panel1.TabIndex = 10;
            // 
            // perguntas_Medio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(995, 483);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdbalternativa3);
            this.Controls.Add(this.rdbalternativa2);
            this.Controls.Add(this.rdbalternativa1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "perguntas_Medio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "perguntas_Medio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.perguntas_Medio_FormClosing);
            this.Load += new System.EventHandler(this.perguntas_Medio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdbalternativa3;
        private System.Windows.Forms.RadioButton rdbalternativa2;
        private System.Windows.Forms.RadioButton rdbalternativa1;
        private System.Windows.Forms.Label lblpergunta;
        private System.Windows.Forms.Panel panel1;

    }
}