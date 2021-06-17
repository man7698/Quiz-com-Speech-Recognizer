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
    public partial class Perguntas_Dificil : Form
    {
        public Perguntas_Dificil()
        {
            InitializeComponent();
        }


        #region dificil

        string[] perguntadificil = 
        {
            "Qual dessas músicas foram compostas no UNASP?",
            "Qual desses casais se conheceram no UNASP?",   
            "Qual coral conquistou o primeiro lugar no festival nacional de corais no rio grande do sul em 1970?",
            "Em que ano foi o lançamento do CD: 'Nossa Gente, Nossa Música' no UNASP?",
            "Em 1915 houve quantas matrículas de alunos?",
            "Quantos alunos aproximadamente o UNASP possui?",
            "Qual era o nome do diretor em 1980?",
            "Antigamente o território do UNASP era maior, era tão grande que chegava em qual bairro?",
            "O UNASP é um colégio enorme dentro dele há muitos tipos de plantas e vegetações." +Environment.NewLine+
            "Qual dos tipos abaixo encontramos lá?",
            "No ensino médio, há dois tipos de curso: TI e Exatas. Um deles sofre defasagem em algumas" + Environment.NewLine +
            "materias no 3º ano. Com qual curso isso ocorre? E quais matérias eles perdem?"
        
        };


        string[] dificilalternativaa =
       {
           "A - Barquinhos",
           "A - Rodrigo Ferreira e Luciana Guimarães",
           "A - Coral Tempo jovem",
           "A - 1990",
           "A - 17",
           "A - 20 mil",
           "A - Ellis Maas",
           "A - Santo Amaro",
           "A - Pinheiro do Paraná",
           "A- TI, perdem História, Espanhol, Geografia, Biologia, Física e Química"
         

       };

        string[] dificilalternativab =
       {
           "B - Faz Chover",
           "B - Adolfo Soares e Janete Soares",
           "B - Coral Carlos gomes",
           "B - 2005",
           "B - 40",
           "B - 30 mil",
           "B - John Lipke",
           "B - Vila das Belezas",
           "B - Pé de Manga",
           "B- TI, perdem Química, Física, História, Geografia e Biologia"
           
       };
        string[] dificilalternativac =
       {
           "C - Aquarela",
           "C - Jorge Sousa e Juliana Sousa",
           "C - Coral de Ouro",
           "C - 2000",
           "C - 100",
           "C - 5 mil",
           "C - Walter Boger",
           "C - Campo Limpo",
           "C - Laranjeira",
           "C- Exatas, perdem Química,Física,História,Geografia e Biologia"
          
       };


        string[] dificilrepostas = { "A - Barquinhos", "B - Adolfo Soares e Janete Soares", "B - Coral Carlos gomes", "C - 2000", "A - 17", "A - 20 mil", "C - Walter Boger", "B - Vila das Belezas", "A - Pinheiro do Paraná", "B" };
        #endregion

        int total = 0, total2=0;
        string resp;
        int i;
        

        private void Perguntas_Dificil_Load(object sender, EventArgs e)
        {
            for (i = 0; i < 1; i++)
            {
                resp = dificilrepostas[i];

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

                    resp = dificilrepostas[i];
                    lblpergunta.Text = perguntadificil[i];
                    rdbalternativa1.Text = dificilalternativaa[i];
                    rdbalternativa2.Text = dificilalternativab[i];
                    rdbalternativa3.Text = dificilalternativac[i];
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

                    if (total > total2)
                    {
                        MessageBox.Show("O vencedor é o jogador 1 :" + opc.nome + " !!!!");

                    }
                    else if (total2 > total)
                    {
                        MessageBox.Show(" O vencedor é o jogador 2 :" + opc.nome2 + " !!!!");
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

                    resp = dificilrepostas[i];
                    lblpergunta.Text = perguntadificil[i];
                    rdbalternativa1.Text = dificilalternativaa[i];
                    rdbalternativa2.Text = dificilalternativab[i];
                    rdbalternativa3.Text = dificilalternativac[i];
                }

                aux = jogador2;
                jogador2 = jogador1;
                jogador1 = aux;
                i++;
            }


            
        }


        private void Perguntas_Dificil_FormClosing(object sender, FormClosingEventArgs e)
        {
            Perguntas p = new Perguntas();
            p.salvar();
           
        }
    }
}
