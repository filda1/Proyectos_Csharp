using RequisicaoSServer.Models;
using RequisicaoSServer.Presenters;
using RequisicaoSServer.Views;
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
    public partial class Form3 : Form,IInterfaz2
    {
        PrincipalPresenter p;
        CategoryPresenters cp;
        Bitmap bmp;

        public ComboBox ComboBox3Form3 {
            get => comboBox3;
            set => comboBox3 = value;
        }
        public ComboBox ComboBox2Form3 {

            get => comboBox2;
            set => comboBox2 = value;
        }
        public ComboBox ComboBox1Form3 {
            get => comboBox1;
            set => comboBox1= value;
        }
        public TextBox numDocForm3 {

            get => textBox2;
            set => textBox2= value;
        }
        public DataGridView DataGridForm3 {

            get => dataGridView1;
            set => dataGridView1 = value;
        }
     
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {          
            var tt = new ToolTip();
            tt.SetToolTip(button2, "apagar tudo");
            tt.SetToolTip(button3, "apagar linha");
            tt.SetToolTip(button4, "imprimir");
            tt.SetToolTip(button1, "enviar documento");

            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;  

            textBox1.Text = DateTime.Now.ToString("dd .MM . yyyy");

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            label6.Visible = false;
        
            cp = new CategoryPresenters(this);

            cp.FillComboxPesquisa();
            //cp.FillComboxCatg();
            cp.NumDocPesquisa();

            ColumnsDataGV();

            //MessageBox.Show("Faça sua escolha nas caixas e insira a quantidade na tabela. E finalmente, envie", "Informação");


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            comboBox2.Items.Clear();

            var valorCategoria = comboBox1.SelectedItem.ToString();
            cp = new CategoryPresenters(this);
            cp.SearchIdRefPesquisa(valorCategoria);
        }

        public void ColumnsDataGV()
        {
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 200;
           
            DataGridViewColumn dataGridViewColumn = dataGridView1.Columns[0];
            dataGridViewColumn.HeaderCell.Style.BackColor = Color.Beige;

            DataGridViewColumn dataGridViewColumn1 = dataGridView1.Columns[1];
            dataGridViewColumn1.HeaderCell.Style.BackColor = Color.Beige;

            DataGridViewColumn dataGridViewColumn2 = dataGridView1.Columns[2];
            dataGridViewColumn2.HeaderCell.Style.BackColor = Color.Beige;

            dataGridView1.Columns[2].ValueType = typeof(Decimal);
        }


        // Button Send database
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem==null)
            {
                errorProvider1.SetError(comboBox3, "Valor da entidade não valida");
                MessageBox.Show("Valor da entidade não valida");
            }
            else
            {
                errorProvider1.Clear();
            }

          
            CategoryPresenters cp = new CategoryPresenters(this);
            cp.Central();

            this.Close();
        }


        // Select value Ref/Design
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            label6.Visible= true;

            var valorCategoria = comboBox2.SelectedItem.ToString();


            string[] corteRef = valorCategoria.Split(' ');
            var stringRef = corteRef[0];

            var cero = stringRef.PadRight(15);

            var corteRef2 = stringRef.TrimStart(' ');
            var stringRef2 = corteRef[0];
         

            CategoryPresenters cp = new CategoryPresenters(this);
            cp.InsertSearchDatagridForm3(stringRef2);       
        }


        // Delete row datagridview
        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                if (dataGridView1.RowCount == 1)
                {
                    dataGridView1.Rows.Clear();
                    comboBox1.Text = "";
                    comboBox2.Text = "";
                    comboBox3.Text = "";

                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;

                    label6.Visible = false;
                    comboBox2.Items.Clear();
                }

                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
            catch
            {
          
            }
        }

        // Delete all datagridview
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            label6.Visible = false;

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            comboBox2.Items.Clear();
        }


        // Print document datagrid form3
        private void button4_Click(object sender, EventArgs e)
        {
            this.Refresh();

            int height = dataGridView1.Height;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
            bmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(bmp, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            dataGridView1.Height = height;

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        //Print document datagrid form3
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }


        // Read only, Entidad ,form3
        private void comboBox3_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        // Read only, Categoria ,form3
        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        // Read only, Ref/Design ,form3
        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
    }
}
