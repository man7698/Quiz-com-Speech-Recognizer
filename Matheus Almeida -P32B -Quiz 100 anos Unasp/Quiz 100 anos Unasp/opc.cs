using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quiz_100_anos_Unasp
{
    public partial class opc : Form
    {
        public opc()
        {
            InitializeComponent();
            
        }

        

        public static string nome,nome2 = "";
        public static int escolha1 = 1, escolha2 = 0;



        private void button1_Click(object sender, EventArgs e)
        {
           
            this.Visible = false;
            Perguntas pf = new Perguntas();
            pf.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            perguntas_Medio pm = new perguntas_Medio();
            pm.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Perguntas_Dificil pd = new Perguntas_Dificil();
            pd.ShowDialog();
        }


        private void txtnome_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtnome.Text == "")
            {

            }
            else
            {
                label1.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;

                nome = txtnome.Text;
                
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu m = new Menu();
            m.Visible = true;
        }

        private void opc_Load(object sender, EventArgs e)
        {
            
        }

        private void rdbjogador2_CheckedChanged(object sender, EventArgs e)
        {

            panel2.Visible = true;
            escolha2 = 1;
            escolha1 = 0;
        }

        private void rdbjogador1_CheckedChanged(object sender, EventArgs e)
        {
            panel2.Visible = false;
            escolha1 = 1;
            escolha2 = 0;

        }

        private void txtnome2_KeyUp(object sender, KeyEventArgs e)
        {
            nome2 = txtnome2.Text;
        }
    }
}
