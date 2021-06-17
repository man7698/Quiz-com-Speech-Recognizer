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
    public partial class perguntas_Medio : Form
    {
        public perguntas_Medio()
        {
            InitializeComponent();
        }

        string resp = "";
        int total = 0, total2 = 0;

        #region medio

        string[] perguntamedio = 
        {
            "A UNASP-SP possui três cursos que se designam (Ciências): Ciência da Computação,"+Environment.NewLine+
            "Ciências Biológicas e qual é o outro curso?",
            "Qual o nome do fundador da UNASP?",
            "Qual dia da semana os alunos da faculdade não tem aula?",
            "Em qual ano o IAE passou a se chamar UNASP?",
            "Qual foi o primeiro nome do colégio UNASP?",
            "Quantos cursos de graduação os três campus da UNASP possuem juntos?",
            "Quase todo ano é organizado para o ensino médio da tarde, um campeonato que envolve" + Environment.NewLine +
            "alunos e professores, qual é o nome?",
            "O UNASP oferecerá novos cursos de graduação, quais são?",
            "Quantos cursos da área técnologica existirá depois que incluirem Engenharia de Computação no UNASP?",
            "Antigamente o Curso de TI (Técnico em Informática) era conhecido como?"
        
        };

        string[] medioalternativaa =
       {
           "A - Ciência Aeronautica",
           "A - John Lipke",
           "A - Quarta-feira",
           "A - 1960",
           "A - Instituto Adventista de Ensino",
           "A - 10",
           "A - Jogos da Amizade",
           "A - Engenharia da computação e Engenharia Ambiental e Sanitaria",
           "A - 5",
           "A - PD-Processamento de Dados"
         

       };

        string[] medioalternativab =
       {
           "B - Ciências Médicas",
           "B - Gaspar Alto",
           "B - Segunda-feira",
           "B - 1930",
           "B - Colegio da União Conferência Brasileira dos Adventistas do Sétimo dia",
           "B - 30",
           "B - Liga dos Campeões",
           "B - Engenharia Ambiental e Engenharia Sanitária ",
           "B - 6",
           "B - BC-Bacharelado em Ciência"
           
       };
        string[] medioalternativac =
       {
           "C - Ciências Contábeis",
           "C - Augusta Boehm",
           "C - Sexta-feira",
           "C - 1990",
           "C - IAE",
           "C - 25",
           "C - Campeonato do TI",
           "C - Engenharia Mecânica e Direito",
           "C - 4",
           "C - TI-Técnicas da Informação"
           
          
       };

        string[] mediorepostas = { "C - Ciências Contábeis", "A - John Lipke", "C - Sexta-feira", "C - 1990", "B - Colegio da União Conferência Brasileira dos Adventistas do Sétimo dia", "B - 30", "C - Campeonato do TI", "A - Engenharia da computação e Engenharia Ambiental e Sanitaria", "B - 6", "A - PD-Processamento de Dados" };

        #endregion

      

        int i = 0;

        private void perguntas_Medio_Load(object sender, EventArgs e)
        {
            for (i = 0; i < 1; i++)
            {
                resp = mediorepostas[i];
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

                    resp = mediorepostas[i];
                    lblpergunta.Text = perguntamedio[i];
                    rdbalternativa1.Text = medioalternativaa[i];
                    rdbalternativa2.Text = medioalternativab[i];
                    rdbalternativa3.Text = medioalternativac[i];
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

                    MessageBox.Show(" Os pontos do jogador 1 são :" + total + "e os pontos do jogador 2 são:" + total2);
                    this.Close();


                    o.Visible = true;
                }
                else
                {
                    rdbalternativa1.Checked = false;
                    rdbalternativa2.Checked = false;
                    rdbalternativa3.Checked = false;

                    resp = mediorepostas[i];
                    lblpergunta.Text = perguntamedio[i];
                    rdbalternativa1.Text = medioalternativaa[i];
                    rdbalternativa2.Text = medioalternativab[i];
                    rdbalternativa3.Text = medioalternativac[i];
                }

                aux = jogador2;
                jogador2 = jogador1;
                jogador1 = aux;
                i++;

            }

            
   
        }

        private void perguntas_Medio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Perguntas p = new Perguntas();
            p.salvar();

        }

    }
}
