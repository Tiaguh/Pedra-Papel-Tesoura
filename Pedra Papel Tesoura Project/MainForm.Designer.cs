/*
 * Created by SharpDevelop.
 * User: Tiago
 * Date: 20/04/2022
 * Time: 11:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Pedra_Papel_Tesoura_Project
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Label label10;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panel2 = new System.Windows.Forms.Panel();
			this.button7 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button9 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.button6 = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button8 = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.button7);
			this.panel2.Controls.Add(this.button5);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.pictureBox3);
			this.panel2.Location = new System.Drawing.Point(15, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(506, 438);
			this.panel2.TabIndex = 11;
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(221, 152);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(75, 23);
			this.button7.TabIndex = 3;
			this.button7.Text = "Como jogar?";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(221, 122);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 2;
			this.button5.Text = "Jogar";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(127, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(259, 69);
			this.label1.TabIndex = 1;
			this.label1.Text = "Jokenpô";
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(127, 214);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(259, 216);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 0;
			this.pictureBox3.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.button9);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.textBox4);
			this.panel1.Controls.Add(this.textBox3);
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Location = new System.Drawing.Point(12, 9);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(506, 433);
			this.panel1.TabIndex = 10;
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(376, 10);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(127, 23);
			this.button9.TabIndex = 13;
			this.button9.Text = "Jogar novamente";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.Button9Click);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(336, 268);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 23);
			this.label3.TabIndex = 12;
			this.label3.Text = "Pontos:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(336, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 23);
			this.label2.TabIndex = 11;
			this.label2.Text = "Pontos:";
			// 
			// textBox4
			// 
			this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox4.Location = new System.Drawing.Point(345, 82);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(29, 20);
			this.textBox4.TabIndex = 10;
			// 
			// textBox3
			// 
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox3.Location = new System.Drawing.Point(345, 294);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(29, 20);
			this.textBox3.TabIndex = 9;
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(3, 8);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(75, 23);
			this.button6.TabIndex = 8;
			this.button6.Text = "Lobby";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(193, 46);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(113, 122);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 4;
			this.pictureBox2.TabStop = false;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(3, 69);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(38, 20);
			this.textBox2.TabIndex = 7;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(193, 256);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(113, 122);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(3, 45);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(38, 20);
			this.textBox1.TabIndex = 6;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(193, 392);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(113, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Papel";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(193, 185);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(113, 23);
			this.button4.TabIndex = 5;
			this.button4.Text = "Jogar";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(74, 392);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(113, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "Pedra";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(312, 392);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(113, 23);
			this.button3.TabIndex = 3;
			this.button3.Text = "Tesoura";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.label10);
			this.panel3.Controls.Add(this.label9);
			this.panel3.Controls.Add(this.label8);
			this.panel3.Controls.Add(this.label7);
			this.panel3.Controls.Add(this.label6);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.button8);
			this.panel3.Location = new System.Drawing.Point(24, 15);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(497, 441);
			this.panel3.TabIndex = 12;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(71, 292);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(246, 23);
			this.label10.TabIndex = 7;
			this.label10.Text = "5 - Vence aquele que fizer 5 pontos primeiro";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(71, 241);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(326, 51);
			this.label9.TabIndex = 6;
			this.label9.Text = "– Pedra ganha da tesoura (amassando-a ou quebrando-a).\r\n– Tesoura ganha do papel " +
	"(cortando-o).\r\n– Papel ganha da pedra (embrulhando-a).";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(71, 198);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(326, 36);
			this.label8.TabIndex = 5;
			this.label8.Text = "4 - Por fim o jogo verá quem ganhou o jogo por meio das seguintes comparações:";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(71, 172);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(260, 26);
			this.label7.TabIndex = 4;
			this.label7.Text = "3 - O computador também irá fazer a escolha.";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(71, 133);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(326, 39);
			this.label6.TabIndex = 3;
			this.label6.Text = "2 - Assim que a imagem da figura selecionada carregar clique no botão de jogar.";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(200, 60);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(75, 26);
			this.label5.TabIndex = 2;
			this.label5.Text = "Como jogar?";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(71, 106);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(326, 23);
			this.label4.TabIndex = 1;
			this.label4.Text = "1- Selecione a figura que você deseja jogar por meio dos botões. ";
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(171, 349);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(122, 23);
			this.button8.TabIndex = 0;
			this.button8.Text = "Voltar para o lobby";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.Button8Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(543, 524);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel3);
			this.DoubleBuffered = true;
			this.Name = "MainForm";
			this.Text = "Pedra Papel Tesoura Project";
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
