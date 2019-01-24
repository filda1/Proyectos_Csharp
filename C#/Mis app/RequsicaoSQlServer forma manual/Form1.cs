using Prueba.Controllers;
using Prueba.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
      
            textBox2.Text = DateTime.Now.ToString("dd .MM . yyyy");

            PrincipalController p = new PrincipalController();
            //p.llenar(dataGridView1);

            p.LoadEntidades(comboBox1);
            p.LoadCategorias(comboBox2);
            //p.LoadRefDesign(comboBox3);

            textBox1.Text= p.GetMaxObrano();
         
        }
         

        // Enviar
        private void button1_Click(object sender, EventArgs e)
        {
            //Decimal year = DateTime.Now.Year;
            // MessageBox.Show(year.ToString());

            PrincipalController p = new PrincipalController();
            p.Process();
        }


        // Combox Categoria
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Refresh();
            comboBox3.Text = "";
            comboBox3.Items.Clear();

            var valorCategoria = comboBox2.SelectedItem.ToString();

            PrincipalController p = new PrincipalController();
            p.LoadRefDesign(comboBox3, valorCategoria);

       
        }

        // Combox Ref + Design
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            var valorCategoria = comboBox3.SelectedItem.ToString();

            string[] corteRef = valorCategoria.Split(' ');
            var stringRef = corteRef[0];
         
            var corteRef2 = stringRef.Trim(' ');
            var stringRef2 = corteRef[0];


            PrincipalController p = new PrincipalController();
            p.LoadRefDesignDatagrid(dataGridView1, stringRef2);

            //MessageBox.Show(stringRef2);

        }


    }
}
