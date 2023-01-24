/*
 * Created by SharpDevelop.
 * User: Tiago
 * Date: 20/04/2022
 * Time: 11:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Pedra_Papel_Tesoura_Project
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			
			textBox1.Visible=false;
			textBox2.Visible=false;
			panel1.Visible = false;
			button4.Enabled = false;	
			button9.Enabled = false;
		}
		
		int pnt1 = 0; //jogador
		int pnt2 = 0; //computador
		
		int computer, user;
		
		
		void Button5Click(object sender, EventArgs e)
		{
			//BOTÃO DE INICIAR O JOGO
			
			panel2.Visible=false;
			panel1.Visible=true;
			
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			//BOTÃO DE SAIR DO JOGO E VOLTAR PARA O LOBBY
			
			panel1.Visible=false;
			panel2.Visible=true;
			
		}
		
		void Button7Click(object sender, EventArgs e)
		{
			//BOTÃO SAIR DO LOBBY E IR PARA REGRAS DO JOGO
			
			panel2.Visible=false;
			panel3.Visible=true;
			
		}	
		
		void Button8Click(object sender, EventArgs e)
		{
			//SAIR DAS REGRAS DO JOGO E VOLTAR PARA O LOBBY
			
			panel3.Visible=false;
			panel2.Visible=true;
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			//JOGADOR SELECIONAR PEDRA
			
			pictureBox1.Visible = true;
			
			user = +1;
			textBox2.Text = user.ToString();
			
			pictureBox1.Load("pedra.png");
			
			button4.Enabled = true;
			
		}	

		void Button1Click(object sender, EventArgs e)
		{
			//JOGADOR SELECIONAR PAPEL
			
			pictureBox1.Visible = true;
			
			user = +2;
			textBox2.Text = user.ToString();
			
			pictureBox1.Load("papel.png");
			
			button4.Enabled = true;
			
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			//JOGADOR SELECIONAR TESOURA
			
			pictureBox1.Visible = true;
			
			user = +3;
			textBox2.Text = user.ToString();
			
			pictureBox1.Load("tesoura.png");

			button4.Enabled = true;
			
		}

//------------------------------------------------------------------------------------------------------
		void Button4Click(object sender, EventArgs e)
		{			
				
			// ESTE TRECHO DE CÓDIGO SORTEIA A OPÇÃO QUE SERÁ JOGADA PELO COMPUTADOR.
				
			pictureBox2.Visible = true;
			
			Random rnd = new Random();
			
			computer = rnd.Next(1,4);
			textBox1.Text = computer.ToString();
			
			if (computer==1){
				
				//COMPUTADOR SELECIONA PEDRA
				pictureBox2.Load("pedra.png");
				
			}
			else if (computer==2) {
				
				//COMPUTADOR SELECIONA PAPEL
				pictureBox2.Load("papel.png");
				
			}
			
			else {
				
				//COMPUTADOR SELECIONA TESOURA
				pictureBox2.Load("tesoura.png");
				
			}
			
//------------------------------------------------------------------------------------------------------	

			//ESTE TRECHO DE CÓDIGO EXECUTA AS CONDIÇÕES DE VITÓRIA, EMPATE OU DERROTA DO JOGO.


			//Situações em que o computador ganha a rodada:
			
			if (computer == 1 &&  user == 3 || computer == 2 && user == 1 || computer == 3 && user == 2 ) {               
			//          PEDRA E TESOURA                PAPEL E PEDRA               TESOURA E PAPEL

				MessageBox.Show("Computador venceu");
				
				pictureBox1.Visible = false;
				pictureBox2.Visible = false;
				button4.Enabled = false;
				
				pnt2 ++;
				textBox4.Text = pnt2.ToString();
				
			}
			
            //Situações em que o jogador ganha a rodada:

			else if(user == 1 && computer == 3 || user == 2 && computer == 1 || user == 3 && computer == 2) {
			//         PEDRA E TESOURA                   PAPEL E PEDRA                   TESOURA E PAPEL
				
				MessageBox.Show("Você venceu");
				
				pictureBox1.Visible = false;
				pictureBox2.Visible = false;
				
				button4.Enabled = false;
				
				pnt1 ++;
				textBox3.Text = pnt1.ToString();
			}
			
            //Situações em que a rodada empata
            
			else {
				
				MessageBox.Show("Essa rodada empatou");
				
				pictureBox1.Visible = false;
				pictureBox2.Visible = false;
				
				button4.Enabled = false;
			}
			
//------------------------------------------------------------------------------------------------------	

			//Finalizar o jogo
			
			if (pnt1 == 5){
				
				MessageBox.Show("Parabéns, você venceu o jogo!!!");
				
				button1.Enabled = false;
				button2.Enabled = false;
				button3.Enabled = false;
				button4.Enabled = false;
				button5.Enabled = true;
				button6.Enabled = false;
				button9.Enabled = true;
				button9.Visible = true;
			}
			
			else if(pnt2 == 5)
			{
				MessageBox.Show("Você perdeu!");
				
				button1.Enabled = false;
				button2.Enabled = false;
				button3.Enabled = false;
				button4.Enabled = false;
				button5.Enabled = true;
				button6.Enabled = false;
				button9.Enabled = true;
				button9.Visible = true;
				
			}
		}
		void Button9Click(object sender, EventArgs e)
		{
			button1.Enabled = true;
			button2.Enabled = true;
			button3.Enabled = true;
			button4.Enabled = false;
			button5.Enabled = true;
			button6.Enabled = true;
			button9.Enabled = false;
			
			pnt1 = 0;
			pnt2 = 0;
			
			textBox3.Text = 0.ToString();
			textBox4.Text = 0.ToString();
			
            }
		}
	}
