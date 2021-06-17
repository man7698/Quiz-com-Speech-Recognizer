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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        

        private void iniciarJogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            opc o = new opc();
            o.ShowDialog();
           
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rankingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ranking r = new ranking();
            r.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {


            string caminho = Application.StartupPath;
            string pastaFlash = (caminho);
            axShockwaveFlash1.Stop();
            axShockwaveFlash1.Movie = pastaFlash + @"\unasp-100 anos.swf";
            axShockwaveFlash1.Play();



        }


        //public string getCaminhoFlash(string caminho)
        //{
        //    //return caminho.Replace("\bin",@"\Flash");
        //}


    }
}
