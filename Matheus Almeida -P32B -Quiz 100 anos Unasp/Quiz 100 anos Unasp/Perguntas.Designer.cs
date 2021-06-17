namespace Quiz_100_anos_Unasp
{
    partial class Perguntas
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
            this.lblpergunta = new System.Windows.Forms.Label();
            this.rdbalternativa1 = new System.Windows.Forms.RadioButton();
            this.rdbalternativa2 = new System.Windows.Forms.RadioButton();
            this.rdbalternativa3 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblpergunta
            // 
            this.lblpergunta.AutoSize = true;
            this.lblpergunta.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpergunta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblpergunta.Location = new System.Drawing.Point(13, 14);
            this.lblpergunta.Name = "lblpergunta";
            this.lblpergunta.Size = new System.Drawing.Size(503, 24);
            this.lblpergunta.TabIndex = 0;
            this.lblpergunta.Text = "Quantas catracas existem na entrada da UNASP- SP\r\n";
            // 
            // rdbalternativa1
            // 
            this.rdbalternativa1.AutoSize = true;
            this.rdbalternativa1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbalternativa1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdbalternativa1.Location = new System.Drawing.Point(80, 128);
            this.rdbalternativa1.Name = "rdbalternativa1";
            this.rdbalternativa1.Size = new System.Drawing.Size(72, 22);
            this.rdbalternativa1.TabIndex = 1;
            this.rdbalternativa1.Text = "A - 10";
            this.rdbalternativa1.UseVisualStyleBackColor = true;
            // 
            // rdbalternativa2
            // 
            this.rdbalternativa2.AutoSize = true;
            this.rdbalternativa2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbalternativa2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdbalternativa2.Location = new System.Drawing.Point(80, 176);
            this.rdbalternativa2.Name = "rdbalternativa2";
            this.rdbalternativa2.Size = new System.Drawing.Size(72, 22);
            this.rdbalternativa2.TabIndex = 2;
            this.rdbalternativa2.Text = "B - 12";
            this.rdbalternativa2.UseVisualStyleBackColor = true;
            // 
            // rdbalternativa3
            // 
            this.rdbalternativa3.AutoSize = true;
            this.rdbalternativa3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbalternativa3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdbalternativa3.Location = new System.Drawing.Point(80, 237);
            this.rdbalternativa3.Name = "rdbalternativa3";
            this.rdbalternativa3.Size = new System.Drawing.Size(70, 22);
            this.rdbalternativa3.TabIndex = 3;
            this.rdbalternativa3.Text = "C - 14";
            this.rdbalternativa3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(-1, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(947, 55);
            this.button1.TabIndex = 4;
            this.button1.Text = "Proxima pergunta";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.lblpergunta);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 65);
            this.panel1.TabIndex = 5;
            // 
            // Perguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(946, 455);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdbalternativa3);
            this.Controls.Add(this.rdbalternativa2);
            this.Controls.Add(this.rdbalternativa1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Perguntas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perguntas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Perguntas_FormClosing);
            this.Load += new System.EventHandler(this.Perguntas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpergunta;
        private System.Windows.Forms.RadioButton rdbalternativa1;
        private System.Windows.Forms.RadioButton rdbalternativa2;
        private System.Windows.Forms.RadioButton rdbalternativa3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}