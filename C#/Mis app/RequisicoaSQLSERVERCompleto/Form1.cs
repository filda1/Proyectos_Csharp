using RequisicaoSServer.Models;
using RequisicaoSServer.Presenters;
using RequisicaoSServer.Views;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Threading;
using System.Globalization;
using System.Speech.AudioFormat;

namespace RequisicaoSServer
{
    public partial class Form1 : Form, IInterfaz
    {
        PrincipalPresenter p;
        Bitmap bmp;
        string valorCategoria;

        // Interface
        public ComboBox ComboBox1Text
        {
            get => comboBox1;
            set => comboBox1= value;
        }
        public String DateText
        {
            get => textBox2.Text;
            set => textBox2.Text = value;
        }
        public string NDocText
        {
            get => textBox1.Text;
            set => textBox1.Text = value;
        }
        public DataGridView DataGridText
        {
            get => dataGridView1;
            set => dataGridView1 = value;
        }
        public Button ButtonNewText
        {
            get => button1;
            set => button1 = value;

        }

        public Button ButtonSendText
        {
            get => button2;
            set => button2 = value;

        }

        public Button ButtonDeleteText
        {
            get => button3;
            set => button3 = value;

        }

        public Button ButtonDeleteAllText
        {
            get => button4;
            set => button4 = value;

        }

        public Button ButtonLineText
        {
            get => button5;
            set => button5 = value;

        }
        public TextBox numDoc
        {
            get => textBox1;
            set => textBox1 = value;
        }
        public Button ButtonPrintText
        {
            get => button6;
            set => button6 = value;
        }

        public Button ButtonFalarText
        {
            get => button7;
            set => button7 = value;

        }
        public ComboBox ComboBox2Text {

            get => comboBox2;
            set => comboBox2 = value;
        }

        public Form1()
        {
            InitializeComponent();

            var tt = new ToolTip();
            tt.SetToolTip(button1, "novo documento");
            tt.SetToolTip(button5, "adicionar linha");
            tt.SetToolTip(button4, "apagar tudo");
            tt.SetToolTip(button3, "apagar linha");
            tt.SetToolTip(button6, "imprimir");
            tt.SetToolTip(button2, "enviar o documento");
            tt.SetToolTip(button8, "pesquisar por categoria");

            tt.SetToolTip(label5, "systema");
            tt.SetToolTip(label6, "documentação");
            tt.SetToolTip(label7, "ajuda");
            tt.SetToolTip(label8, "relatório de problema");

        }

    
        private void button7_Click(object sender, EventArgs e)
        {           
        }

        //  Send database
        private void button2_Click(object sender, EventArgs e)
        {
                   
            //Speech
            Fala Speech = Fala.getInstance(ref button7);
            Speech.Velocidade = 10;
            Speech.Volume = 100;

    

            p = new PrincipalPresenter(this);
            p.Process(Speech);
            // p.CentralProcess(Speech);

            dataGridView1.Refresh();
            this.Refresh();

        }


            private void Form1_Load(object sender, EventArgs e)
        {
            

            //Speech
            Fala Speech = Fala.getInstance(ref button7);
            Speech.Velocidade = 10;
            Speech.Volume = 100;
            dataGridView1.AutoGenerateColumns = false;

            label11.Visible = false;

            try
            {
                textBox2.Text = DateTime.Now.ToString("dd .MM . yyyy");
                //textBox2.Text = DateTime.Now.ToShort;
                ColumnsDataGV10();
                //ColumnsDataGVBegin();
          

                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                textBox1.Enabled = false;
                textBox2.Enabled = false;  

                button1.BackColor = Color.Transparent;

                button6.BackColor = Color.White;

                button8.BackColor = Color.Transparent;
                button8.BackColor = Color.White;

              
                button2.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;

                ActiveContrary();
                //Executar a síntese de voz
                //Speech.Falar("ola Sou Aisha, sou sua asistente virtual ,seja bem vindo a nosso sistema de pedidos");
                Speech.Falar("");

            }
            catch
            {
                //ColumnsDataGVBegin();
               button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button8.Enabled = false;
                textBox1.Enabled = false;
                textBox2.Enabled = false;

                comboBox1.Enabled = false;

               //Speech.Falar("Problemas com a conexão");
                MessageBox.Show("Problemas com a conexão");
                //Application.Exit();
            }
        }

        // Load ComboxDatagridView and Columns
        public void ColumnsDataGV10()
        {
            dataGridView1.AllowUserToAddRows = false;  // Not Visible first Rown

            p = new PrincipalPresenter(this);
            DataGridViewComboBoxColumn combo = p.SearchListId();
            this.dataGridView1.Columns.Insert(0, combo);

            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Design";
            dataGridView1.Columns[1].Name = "Ref";
            dataGridView1.Columns[2].Name = "Qta";

            dataGridView1.Columns[0].Width = 450;
            dataGridView1.Columns[1].Width = 450;
            dataGridView1.Columns[2].Width = 250;
            //dataGridView1.Columns[3].Width = 450;

            DataGridViewColumn dataGridViewColumn = dataGridView1.Columns[0];
            dataGridViewColumn.HeaderCell.Style.BackColor = Color.Beige;

            DataGridViewColumn dataGridViewColumn1 = dataGridView1.Columns[1];
            dataGridViewColumn1.HeaderCell.Style.BackColor = Color.Beige;

            // DataGridViewColumn dataGridViewColumn2 = dataGridView1.Columns[2];
            //dataGridViewColumn2.HeaderCell.Style.BackColor = Color.Beige;


            DataGridViewColumn dataGridViewColumn2 = dataGridView1.Columns[2];
            dataGridViewColumn2.HeaderCell.Style.BackColor = Color.Beige;

            dataGridView1.Columns[2].ValueType = typeof(Decimal);

            this.Refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {          
        }


        // Button new doc
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Por favor, insira os valores na tabela da esquerda para a direita, " +
                            "Pesquisando por Design", "Informação");


            p = new PrincipalPresenter(this);
                p.FillCombox();
                //p.FillComboxCatg();
                p.NumDoc();
          
            //ColumnsDataGV();

                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                // Number Doc, readonly
                textBox1.ReadOnly = true;
                // Date, readonly
                textBox2.ReadOnly = true;

            label11.Visible = true;

            Active();

             ArrayList row = new ArrayList
             {   "", "",  "0" };

               dataGridView1.Rows.Add(row.ToArray());    
        }



        // New row
        private void button5_Click(object sender, EventArgs e)
        {
            ArrayList row = new ArrayList
            {   "", "",  "0" };

            dataGridView1.Rows.Add(row.ToArray());
        }


        // Search for Design from Ref(datagridView)
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
          
            //Speech
            Fala Speech = Fala.getInstance(ref button7);
            Speech.Velocidade = 10;
            Speech.Volume = 100;

            

            try
            {
                label11.Visible = true;
                int indexCell_0 = e.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[indexCell_0];
                var valueSearch = selectedRow.Cells[0].Value.ToString();

                p = new PrincipalPresenter(this);
                p.SearchId(valueSearch, indexCell_0);

                dataGridView1.Refresh();
            }
            catch
            {
                Speech.Falar("Tem que introduzir o valor em Ref");
                MessageBox.Show("Tem que introduzir o valor em Ref");
            }
        }


        // Combox editable y autocomplete in datagridview
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

            if (e.Control.GetType() == typeof(DataGridViewComboBoxEditingControl))
            {
                DataGridViewComboBoxEditingControl combo = e.Control as DataGridViewComboBoxEditingControl;
                combo.DropDownStyle = ComboBoxStyle.DropDown;
                combo.Sorted = true;
                combo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            }
        }


        // Delete row
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.RowCount == 1)
                {
                    dataGridView1.Rows.Clear();
                    label11.Visible = false;
                    button1.Enabled = true;
                    ActiveContrary();
                    textBox1.Text = "";
                    comboBox1.Items.Clear();
                    comboBox2.Items.Clear();
                    comboBox2.Text = "";
                    comboBox1.Text = "";
                    comboBox2.Enabled = false;
                    comboBox1.Enabled = false;

                }

                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
            catch
            {

                button1.Enabled = true;
                label11.Visible = false;
                ActiveContrary();
                textBox1.Text = "";
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                comboBox2.Enabled = false;
                comboBox1.Enabled = false;
                comboBox2.Text = "";
                comboBox1.Text = "";

            }
        }


        // Delete datagridView
        private void button4_Click(object sender, EventArgs e)
        {
            label11.Visible = false;
            comboBox1.Text="";
            comboBox1.Enabled =false;
            comboBox2.Enabled = false;
            comboBox2.Text = "";
            dataGridView1.Rows.Clear();
            button1.Enabled = true;
            ActiveContrary();
            textBox1.Text = "";
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
        }


        // Controls the error in cell 2 by being different from decimal
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //Speech
            Fala Speech = Fala.getInstance(ref button7);
            Speech.Velocidade = 10;
            Speech.Volume = 100;

            if (e.Exception is FormatException)
            {
                Speech.Falar("Tem que inserir um numero valido em Qta. Ej: 2 o 2,0");
                MessageBox.Show("Tem que inserir um numero valido em Qta. Ej: 2 o 2,0");
            }
        }


        // Print Document, necessary printPreviewDialog1 and  printDocument1
        private void button6_Click(object sender, EventArgs e)
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


        // Print Document, necessary printPreviewDialog1 and  printDocument1
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }


        // Load ComboxDatagridView
        public void ColumnsDataREF()
        {
        
        }

        // Load ComboxDatagridView
        public void ColumnsDataGV()
        {
            dataGridView1.AllowUserToAddRows = false;  // Not Visible first Rown

              p = new PrincipalPresenter(this);
             
            dataGridView1.ColumnCount = 3;


            //DataGridViewComboBoxColumn combo = p.SearchListId(valorCategoria);
            DataGridViewComboBoxColumn combo = p.SearchListIdCategoria();
            this.dataGridView1.Columns.Insert(0, combo);

               //dataGridView1.Columns[0].Name = "Categ";
               dataGridView1.Columns[1].Name = "Ref";
               dataGridView1.Columns[1].Name = "Design";
               dataGridView1.Columns[2].Name = "Qta";

               dataGridView1.Columns[0].Width = 250;
               dataGridView1.Columns[1].Width = 250;
               dataGridView1.Columns[2].Width = 450;          

               DataGridViewColumn dataGridViewColumn = dataGridView1.Columns[0];
               dataGridViewColumn.HeaderCell.Style.BackColor = Color.Beige;

               DataGridViewColumn dataGridViewColumn1 = dataGridView1.Columns[1];
               dataGridViewColumn1.HeaderCell.Style.BackColor = Color.Beige;
            
             DataGridViewColumn dataGridViewColumn2 = dataGridView1.Columns[2];
             dataGridViewColumn2.HeaderCell.Style.BackColor = Color.Beige;

            dataGridView1.Columns[2].ValueType = typeof(Decimal);

        }

        private void Active()
        {
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
        }

        private void ActiveContrary()
        {
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }


        private void label7_Click(object sender, EventArgs e)
        {
            //Speech
            Fala Speech = Fala.getInstance(ref button7);
            Speech.Velocidade = 10;
            Speech.Volume = 100;

            //Executar a síntese de voz
            Speech.Falar("");
            MessageBox.Show("*En Novo, os valores devem ser inseridos da esquerda para a direita." +
                "> Começando com a busca por Design (Designação), depois clicando em Ref " +
                "(Referência) e colocando finalmente a quantidade (Qta), tudo antes de enviá-la. * Em Pesquisar, " +
                "Você tem que selecionar todas as caixas que aparecerão na tabela e depois inserir a quantidade (Qta) na mesma tabela." +
                "Depois disso você pode enviar se quiser", "Ajuda?");

        }
        private void hablar(object texto)
        {
            SpeechSynthesizer voz = new SpeechSynthesizer();
            voz.SetOutputToDefaultAudioDevice();
            voz.Speak(texto.ToString());
        }
        private void label5_Click(object sender, EventArgs e)
        {
            Fala Speech = Fala.getInstance(ref button7);
            Speech.Velocidade = 10;
            Speech.Volume = 100;

            //Executar a síntese de voz
            Speech.Falar("S.O Windows, versão: Wormhole v.5");
            MessageBox.Show("S.O Windows, versão: Wormhole v.5");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Fala Speech = Fala.getInstance(ref button7);
            Speech.Velocidade = 10;
            Speech.Volume = 100;

            //Executar a síntese de voz
            Speech.Falar("Não está disponível no momento");
            MessageBox.Show("Não está disponível no momento");
        }


        // Show Category, form3
        private void label8_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.ShowDialog();
        }

    

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

     
      

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_2(object sender, EventArgs e)
        {
        

        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }


        // Select cell Design in datagridview and search Ref y load Cell1 of datagridview
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Refresh();

            try
            {
                int indexCell_0 = e.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[indexCell_0];
                var valueSearch = selectedRow.Cells[0].Value.ToString();



                p = new PrincipalPresenter(this);
                p.SearchId(valueSearch, indexCell_0);

                dataGridView1.Refresh();

            }
            catch
            {
                MessageBox.Show("Valores vazios");
            }
        }

        // Open form3
        private void button8_Click(object sender, EventArgs e)
        {         
            Form3 fr3 = new Form3();
            fr3.ShowDialog();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }


       
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }


        // Read only, Entidad ,form1
        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Refresh();
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }   
}
