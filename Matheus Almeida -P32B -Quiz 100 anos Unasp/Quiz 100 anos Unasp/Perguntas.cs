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
    public partial class Perguntas : Form
    {
        public Perguntas()
        {
            InitializeComponent();

        }
        public static string strcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\bdquiz.accdb";
        string resp = "";
        int total = 0, total2=0;






        #region facil

        string[] perguntafacil = 
        {
            "Quantas catracas existem na entrada da UNASP- SP?",
            "Qual era o antigo prédio do Ensino Médio?",
            "Qual o ano que a UNASP foi fundada?",
            "Em qual ano o curso de Enfermagem foi implantado na UNASP?",
            "Em qual ano o UNASP passou a se chamar IAE (Instituto Adventista de Ensino)?",
            "Na Sexta-feira, o ensino médio do TI entra em qual horário?",
            "Em 2010 O UNASP possuia quantos anos?",
            "Em 1930 quem era o diretor dessa instiuição?",
            "Quantos campus a UNASP possui no total?",
            "No ensino médio existem dois tipos de cursos, quais são?"
        };

        string[] facilalternativaa =
       {
           "A - 10",
           "A - Atual prédio da Faculdade",
           "A - 1922",
           "A - 1925",
           "A - 1960",
           "A - 13h - 45 minutos",
           "A - 95",
           "A - Ellis R.Maas",
           "A - 4",
           "A - Técnico em Contabilidade e Técnico em Informática"

       };

        string[] facilalternativab =
       {
           "B - 12",
           "B - Atual prédio do Fundamental II",
           "B - 1815",
           "B - 1960",
           "B - 1930",
           "B - 12h15 - 30 minutos",
           "B - 90",
           "B - John Lipke",
           "B - 3",
           "B - Técnino em Informática e Técnico em Enfermagem"
       };
        string[] facilalternativac =
       {
           "C - 14",
           "C - Atual prédio da escola Modelo",
           "C - 1915",
           "C - 2000",
           "C - 1990",
           "C - 12h15 - 35 minutos",
           "C - 97",
           "C - Domingos P.da Silva",
           "C - 2",
           "C - Exatas e Técnico em Informática"
          
       };
        string[] facilrepostas = { "A - 10", "B - Atual prédio do Fundamental II", "C - 1915", "B - 1960", "A - 1960", "C - 12h15 - 35 minutos", "A - 95", "A - Ellis R.Maas", "B - 3", "C - Exatas e Técnico em Informática" };

        #endregion




  
        int i;

       private void Perguntas_Load(object sender, EventArgs e)
       {
           for (i = 0; i < 1; i++)
           {
               resp = facilrepostas[i];
           }
       }

                 bool jogador1 = true;
                 bool jogador2 = false;
                 bool aux = false;

       private void button1_Click(object sender, EventArgs e)
       {
            opc o = new opc();

            if(opc.escolha1 == 1)
            {
                if (rdbalternativa1.Text == resp && rdbalternativa1.Checked == true)
                {
                    total += 1;
                }
                else if (rdbalternativa2.Text == resp && rdbalternativa2.Checked == true)
                {
                    total += 1;
                }
                else if (rdbalternativa3.Text == resp && rdbalternativa3.Checked == true)
                {
                    total += 1;
                }

                if (i == 10)
                {

                    MessageBox.Show("seus pontos são :" + total);
                    this.Close();

                   
                    o.Visible = true;
                }
                else
                {
                    rdbalternativa1.Checked = false;
                    rdbalternativa2.Checked = false;
                    rdbalternativa3.Checked = false;

                    resp = facilrepostas[i];
                    lblpergunta.Text = perguntafacil[i];
                    rdbalternativa1.Text = facilalternativaa[i];
                    rdbalternativa2.Text = facilalternativab[i];
                    rdbalternativa3.Text = facilalternativac[i];
                }

                i++;
            }

            else if(opc.escolha2 == 1)
            {
                


                if (rdbalternativa1.Text == resp && rdbalternativa1.Checked == true && jogador1 == true)
                {
                    total += 1;
                }
                else if (rdbalternativa1.Text == resp && rdbalternativa1.Checked == true && jogador2 == true)
                {
                    total2 += 1;
                }
                else if (rdbalternativa2.Text == resp && rdbalternativa2.Checked == true && jogador1 == true)
                {
                    total += 1;
                }
                else if (rdbalternativa2.Text == resp && rdbalternativa2.Checked == true && jogador2 == true)
                {
                    total2 += 1;
                }
                else if (rdbalternativa3.Text == resp && rdbalternativa3.Checked == true && jogador1 == true)
                {
                    total += 1;
                }
                else if (rdbalternativa3.Text == resp && rdbalternativa3.Checked == true && jogador2 == true)
                {
                    total2 += 1;
                }

                if (i == 10)
                {

                    if( total > total2)
                    {
                        MessageBox.Show("O vencedor é o jogador 1 :" + opc.nome+" !!!!");

                    }
                    else if (total2 > total)
                    {
                        MessageBox.Show(" O vencedor é o jogador 2 :" + opc.nome2+" !!!!");
                    }
                    else
                    {
                        MessageBox.Show("Empatou !!!");
                    }

                    this.Close();

                    
                    o.Visible = true;
                }
                else
                {
                    rdbalternativa1.Checked = false;
                    rdbalternativa2.Checked = false;
                    rdbalternativa3.Checked = false;

                    resp = facilrepostas[i];
                    lblpergunta.Text = perguntafacil[i];
                    rdbalternativa1.Text = facilalternativaa[i];
                    rdbalternativa2.Text = facilalternativab[i];
                    rdbalternativa3.Text = facilalternativac[i];
                }

                aux = jogador2;
                jogador2 = jogador1;
                jogador1 = aux;
                i++;

            }

                
           

            
   
        }


       public void salvar()
       {
           string query = "INSERT INTO jogador(nome,pontos,nome2,pontos2)values(@nome,@pontos,@nome2,@pontos2)";

           OleDbConnection olecon = new OleDbConnection(strcon);

           OleDbCommand comando = new OleDbCommand(query, olecon);

           comando.Parameters.Add("@nome", OleDbType.VarChar).Value = opc.nome;
           comando.Parameters.Add("@pontos", OleDbType.Integer).Value = total;
           comando.Parameters.Add("@nome2", OleDbType.VarChar).Value = opc.nome2;
           comando.Parameters.Add("@pontos2", OleDbType.Integer).Value = total2;


           try
           {
               olecon.Open();
               comando.ExecuteNonQuery();
               MessageBox.Show("Pontos salvos !!!");

           }
           catch (Exception EX)
           {
               MessageBox.Show(EX.Message);
           }
           finally
           {
               olecon.Close();

           }



       }
       private void Perguntas_FormClosing(object sender, FormClosingEventArgs e)
       {
           salvar();
           
       }      
    }
}
