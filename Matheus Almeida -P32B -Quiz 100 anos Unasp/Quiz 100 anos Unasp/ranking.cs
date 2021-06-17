using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Quiz_100_anos_Unasp
{
    public partial class ranking : Form
    {
        public ranking()
        {
            InitializeComponent();
        }

        private void Carregar(string SQLconsultageral)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(Perguntas.strcon);
                 OleDbDataAdapter da = new OleDbDataAdapter(SQLconsultageral, con);
                DataTable responsavel = new DataTable();
                da.Fill(responsavel);
                responsavel.Columns[0].ColumnName = "Nome do Jogador";
                responsavel.Columns[1].ColumnName = "Pontos";
                responsavel.Columns[2].ColumnName = "Segundo Jogador";
                responsavel.Columns[3].ColumnName = "Pontos";

                gvpontos.DataSource = responsavel;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ranking_Load(object sender, EventArgs e)
        {
            string a = "select nome,pontos,nome2,pontos2 from jogador order by pontos desc";
            Carregar(a);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
