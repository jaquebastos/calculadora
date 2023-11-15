/*
 * Created by SharpDevelop.
 * User: rm20222930057
 * Date: 19/04/2023
 * Time: 13:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace POOatividade
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
		
		}
		
		TextBox n1 = new TextBox();
		TextBox n2 = new TextBox(); 
		TextBox n3 = new TextBox(); 
		
		void MainFormLoad(object sender, EventArgs e)
		{
			BackColor = Color.RosyBrown;
			
			n1.Parent = this;
			n1.Left = 80;
			n1.Top = 30;
			
			n2.Parent = this;
			n2.Left = 80;
			n2.Top = 60;
			
			n3.Parent = this;
			n3.Left = 80;
			n3.Top = 90;
			
			Button soma = new Button(); 
			soma.Parent = this; 
			soma.Left = 50; 
			soma.Top = 150; 
			soma.Text = "+";
			soma.BackColor = Color.Pink; 
			soma.Click += somarClick; 
			
			Button sub = new Button();
			sub.Parent = this;
			sub.Left = 50;
			sub.Top = 180;
			sub.Text = "-";
			sub.BackColor = Color.Pink;
			sub.Click += subtrairClick;
			
			Button mult = new Button();
			mult.Parent = this;
			mult.Left = 130;
			mult.Top = 150;
			mult.Text = "x";
			mult.BackColor = Color.Pink;
			mult.Click += multiplicarClick; 
			
			Button div = new Button();
			div.Parent = this;
			div.Left = 130;
			div.Top = 180;
			div.Text = "÷";
			div.BackColor = Color.Pink;
			div.Click += divisãoClick; 
			
			Button limpar = new Button(); 
			limpar.Parent = this;
			limpar.Left = 90; 
			limpar.Top = 210; 
			limpar.Text = "Limpar";
			limpar.BackColor = Color.Pink;
			limpar.Click += limparClick; 
			
		}
		
		void somarClick (object sender, EventArgs e)
		{
			if (n1.Text != "" && n2.Text != "") 
			{
				int v1 = int.Parse(n1.Text);
				int v2 = int.Parse(n2.Text);
				int total = v1 + v2; 
				n3.Text = total.ToString();
			}
			else 
				MessageBox.Show("Insira os números, animal!");
		}
		
		void subtrairClick (object sender, EventArgs e)
		{
			if (n1.Text != "" && n2.Text != "")
			{
				int v1 = int.Parse(n1.Text);
				int v2 = int.Parse(n2.Text);
				int total = v1 - v2;
				n3.Text = total.ToString();
			}
			else 
				MessageBox.Show("Insira os números, animal!");
		}
		
		void multiplicarClick (object sender, EventArgs e)
		{
			if (n1.Text != "" && n2.Text != "")
			{
				int v1 = int.Parse(n1.Text);
				int v2 = int.Parse(n2.Text);
				int total = v1 * v2;
				n3.Text = total.ToString();
				
			}
			else
				MessageBox.Show("Insira os números, animal!");
		}
		
		void divisãoClick (Object sender, EventArgs e)
		{
			if (n1.Text != "" && n2.Text != "")
			{
				int v1 = int.Parse(n1.Text);
				int v2 = int.Parse(n2.Text);
				int total = v1 / v2; 
				n3.Text = total.ToString(); 
			}
		}
		void limparClick (Object sender, EventArgs e)
		{
			if (n1.Text !="" && n2.Text != "")
			{
				n1.Text = "";
				n2.Text = ""; 
				n3.Text = "";
			}
			else MessageBox.Show("Adicione ou termine de adicionar os valores!");
		}
	}
}
