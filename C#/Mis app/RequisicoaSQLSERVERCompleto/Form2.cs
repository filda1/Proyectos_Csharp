using RequisicaoSServer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RequisicaoSServer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            var tt = new ToolTip();
            tt.SetToolTip(button2, "Limpar tudo");
            tt.SetToolTip(button1, "Enviar email");
        }

        // Clear
        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            textBox1.Clear();
        }

        // Send E-mail
        private void button1_Click(object sender, EventArgs e)
        {
            var assunto = textBox1.Text;
            var descripcion = richTextBox1.Text;
            Fala Speech = Fala.getInstance(ref button3);
            Speech.Velocidade = 10;
            Speech.Volume = 100;

            if ( (String.IsNullOrEmpty(assunto)) || (String.IsNullOrEmpty(descripcion)))
            {
                //Speech
             

                //Executar a síntese de voz
                Speech.Falar("Falta de valor em Assunto o/y Descrição");
                MessageBox.Show("Falta de valor em Assunto o/y Descrição");
               
            }
            else
            {
                Email em = new Email();
                em.email("Relatório: "+ " "+ assunto, descripcion, "");
                this.Close();
            }

         
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
