using RequisicaoSServer.Models;
using RequisicaoSServer.Views;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RequisicaoSServer.Presenters
{
    public class PrincipalPresenter
    {

        #region Variables

        private IInterfaz view;
        private IInterfaz2 view2;
        private DbConsultation query;
        private String valorEntidad;
        private String valorComboForm3Ref;

        #endregion

        #region Properties

        public string ValueComboBox { get; set; }

        public string Year = DateTime.Now.Year.ToString();
        public string Date = DateTime.Now.ToShortDateString();
        public DateTime Today = DateTime.Now;
      
        Fala habla;
    
        #endregion

        #region  Constructor

        public PrincipalPresenter(IInterfaz screen)
        {
            view = screen;
        }

        public PrincipalPresenter(IInterfaz2 screen)
        {
            view2 = screen;
        }


        public PrincipalPresenter()
        {
        }

        #endregion

        #region Methods

  
        // Insert to database, table Bi and Bo
        public void Process( Fala fala)
        {
            habla = fala;
            query = new DbConsultation();

            view.DataGridText.Refresh();

            try
            {
                for (int i = 0; i < view.DataGridText.Rows.Count; i++)
                {
                    var xx = view.DataGridText.Rows[i].Cells[0].Value.ToString();

                    if (String.IsNullOrEmpty(xx))
                    {
                        MessageBox.Show("Valores invalidos na tabela");
                    }
                    else
                    {
                        // Count empty in Cells2 of datagridView
                        // int C = 0;

                        //  for (int ii = 0; ii < view.DataGridText.Rows.Count; i++)
                        //  {              
                        //   var xxx = view.DataGridText.Rows[i].Cells[2].Value.ToString();

                        // if (String.IsNullOrEmpty(xxx))
                        //  {
                        //    C = C + 1;
                        // }
                        // }


                        // Check if Cell 2 is empty or full
                        // Main part, Compare with the counter if cell 2 of the DatagridView is empty or full. 
                        // Counter = 0 (full Cell 2 ) and Counter != 0 ( some empty cell 2).  

                        var C = 0;

                        if (C != 0)
                        {
                            fala.Falar("Tem que inserir a Qta (quantidade) em tabela");
                            MessageBox.Show("Tem que inserir a Qta (quantidade) em tabela");
                        }

                        else
                        {

                            // Validate the combox  if it has selected value
                            var entities = view.ComboBox1Text.Text;

                            if (String.IsNullOrEmpty(entities))
                            {
                                fala.Falar("Tem selecionar uma entidade");
                                MessageBox.Show("Tem selecionar uma entidade");
                            }
                            else
                            {


                                try
                                {

                                    // Insert in database, head of form 

                                    //var nDocumento = view.numDoc.Text;

                                    var nDocumento =NumDoc2();

                                    var dates = Year;

                                    var uid = Regex.Replace(Convert.ToBase64String(Guid.NewGuid().ToByteArray()), "[/+=]", "");

                                    decimal voano = Decimal.Parse(Year);
                                    decimal numeroDo = Decimal.Parse(nDocumento);



                                    //  try
                                    /// {
                                    var valorEntidad = view.ComboBox1Text.SelectedItem.ToString();


                                    // Requisição Interna

                                    bo b = new bo
                                    {
                                        bostamp = uid,
                                        nmdos = "Requisição Interna",
                                        obrano = numeroDo,
                                        dataobra = DateTime.Now,
                                        nome = valorEntidad,
                                        tipo = "Interno",
                                        datafinal = DateTime.Now,
                                        boano = voano,
                                        dataopen = DateTime.Now,
                                        datafecho = DateTime.Now,
                                        vendnm = "nn",
                                        obranome = "n",
                                        tecnnm = "n",
                                        maquina = "n",
                                        marca = "n",
                                        serie = "n",
                                        zona = "n",
                                        obs = "n",
                                        trab1 = "n",
                                        trab2 = "n",
                                        trab3 = "n",
                                        trab4 = "n",
                                        trab5 = "n",
                                        ndos = 35,
                                        custo = 0,
                                        moeda = "EURO",
                                        morada = "nnn",
                                        local = "n",
                                        codpost = "n",
                                        ultfact = DateTime.Now,
                                        tabela1 = "n",
                                        ncont = "n",
                                        segmento = "n",
                                        userimpresso = "n",
                                        fref = "n",
                                        ccusto = "n",
                                        ncusto = "n",
                                        cobranca = "n",
                                        memissao = "EURO",
                                        nome2 = "n",
                                        pastamp = "n",
                                        snstamp = "n",
                                        mastamp = "n",
                                        origem = "BO",
                                        site = "n",
                                        pnome = "n",
                                        cxstamp = "n",
                                        cxusername = "n",
                                        ssstamp = "n",
                                        ssusername = "n",
                                        series = "n",
                                        series2 = "n",
                                        quarto = "n",
                                        tabela2 = "n",
                                        obstab2 = "n",
                                        iemail = "n",
                                        inome = "n",
                                        lang = "n",
                                        ean = "n",
                                        iecacodisen = "n",
                                        dtclose = DateTime.Now,
                                        tpstamp = "n",
                                        tpdesc = "n",
                                        statuspda = "n",
                                        ousrinis = "n",
                                        ousrdata = DateTime.Now,
                                        ousrhora = DateTime.Now.ToString("HH:mm:ss"),
                                        usrinis = "n",
                                        usrdata = DateTime.Now,
                                        usrhora = DateTime.Now.ToString("HH:mm:ss"),
                                        //u_gpgasto = "nn",
                                        //u_matricul = "nn",
                                        //u_motorist = "nn",
                                        //u_tpgasto = "nn"
                                    };


                                    query.Add2(b);


                                    // Insert in database , all of datagridView
                                    var count = view.DataGridText.Rows.Count;
                                    bi[] miObj = new bi[count];

                                    for (int y = 0; y < view.DataGridText.Rows.Count; y++)
                                    {
                                        var n = i.ToString();

                                        System.Guid guid = System.Guid.NewGuid();
                                        byte[] guidbytes = guid.ToByteArray();
                                        string uidBi = Convert.ToBase64String(guidbytes).Trim('=');

                                        string cell1 = view.DataGridText.Rows[i].Cells[0].Value.ToString();

                                        var obj = query.GetId(cell1);
                                        //var cell2 = obj._ref;
                                        var cell2 = view.DataGridText.Rows[i].Cells[1].Value.ToString();

                                        var cel3 = view.DataGridText.Rows[i].Cells[2].Value.ToString();
                                        Decimal cell3 = Decimal.Parse(cel3);



                                        miObj[i] = new bi
                                        {
                                            bistamp = uidBi,
                                            nmdos = "Requisição Interna",
                                            obrano = numeroDo,
                                            _ref = cell2,
                                            design = cell1,
                                            qtt = cell3,
                                            serie = "n",
                                            fdata = DateTime.Now,
                                            nmdoc = "n",
                                            forref = "n",
                                            rdata = DateTime.Now,
                                            dedata = DateTime.Now,
                                            atedata = DateTime.Now,
                                            lobs = "n",
                                            obranome = "n",
                                            datafinal = DateTime.Now,
                                            dataobra = DateTime.Now,
                                            dataopen = DateTime.Now,
                                            datafecho = DateTime.Now,
                                            maquina = "n",
                                            marca = "n",
                                            zona = "n",
                                            litem = "n",
                                            lobs2 = "n",
                                            litem2 = "n",
                                            lobs3 = "n",
                                            lrecno = "n",
                                            local = "n",
                                            morada = "n",
                                            codpost = "n",
                                            nome = valorEntidad,
                                            vendnm = "n",
                                            tabela1 = "n",
                                            reff = "n",
                                            lote = "n",
                                            cor = "n",
                                            tam = "n",
                                            segmento = "n",
                                            bofref = "n",
                                            bifref = "n",
                                            biserie = "n",
                                            adoc = "n",
                                            codigo = "n",
                                            obistamp = "n",
                                            oobistamp = "n",
                                            usr1 = "n",
                                            usr2 = "n",
                                            usr3 = "n",
                                            usr4 = "n",
                                            usr5 = "n",
                                            usr6 = "n",
                                            unidade = "n",
                                            unidad2 = "n",
                                            oftstamp = "n",
                                            ofostamp = "n",
                                            familia = "n",
                                            nccod = "n",
                                            ncinteg = "n",
                                            classifc = "n",
                                            posic = "n",
                                            series = "n",
                                            series2 = "n",
                                            ccusto = "n",
                                            ncusto = "n",
                                            oobostamp = "n",
                                            ltab1 = "n",
                                            ltab2 = "n",
                                            ltab3 = "n",
                                            ltab4 = "n",
                                            ltab5 = "n",
                                            fami = "n",
                                            iecacodisen = "n",
                                            codfiscal = "n",
                                            dgeral = "n",
                                            tiposemp = "n",
                                            dtclose = DateTime.Now,
                                            quarto = "n",
                                            efornecedor = "n",
                                            optstamp = "n",
                                            oristamp = "n",
                                            bostamp = uid,
                                            ousrinis = "n",
                                            ousrdata = DateTime.Now,
                                            ousrhora = DateTime.Now.ToString("HH:mm:ss"),
                                            usrinis = "n",
                                            usrdata = DateTime.Now,
                                            usrhora = DateTime.Now.ToString("HH:mm:ss"),
                                            //u_matric = "n"
                                        };

                                        query.Add(miObj[y], n);

                                    }

                                    var assunto = "Requisição Interna" + ":" + " " + DateTime.Now.ToString();
                                    var descripcion = "Requisição Interna:" + " " + numeroDo + " ," + " " + "de" + " " + voano;


                                    try
                                    {
                                        var qw = "";
                                        Email em = new Email();
                                        em.email(assunto, descripcion, qw);

                                        // Clean and Enable , textbox, datagridview and button
                                        view.DataGridText.Rows.Clear();
                                        view.ButtonNewText.Enabled = true;
                                        view.ButtonSendText.Enabled = false;
                                        view.ButtonDeleteText.Enabled = false;
                                        view.ButtonDeleteAllText.Enabled = false;
                                        view.ButtonLineText.Enabled = false;
                                        view.ButtonPrintText.Enabled = false;

                                        view.numDoc.Text = "";
                                        view.ComboBox1Text.Text = "";
                                        view.ComboBox1Text.Items.Clear();
                                    }
                                    catch
                                    {
                                        fala.Falar("Ok enviado com sucesso!!");
                                        MessageBox.Show("Ok enviado com sucesso!!");

                                        // Clean and Enable , textbox, datagridview and button
                                        view.DataGridText.Rows.Clear();
                                        view.ButtonNewText.Enabled = true;
                                        view.ButtonSendText.Enabled = false;
                                        view.ButtonDeleteText.Enabled = false;
                                        view.ButtonDeleteAllText.Enabled = false;
                                        view.ButtonLineText.Enabled = false;
                                        view.ButtonPrintText.Enabled = false;

                                        view.numDoc.Text = "";
                                        view.ComboBox1Text.Text = "";
                                        view.ComboBox1Text.Items.Clear();
                                    }


                                    // }
                                    //   catch
                                    //   {
                                    //      fala.Falar("Valor/s vazio");
                                    //MessageBox.Show("Valor inválido em entidade");
                                    //       MessageBox.Show("Valor/s vazio");
                                    //  }
                                }

                                catch (DbEntityValidationException e)
                                {
                                    foreach (var eve in e.EntityValidationErrors)
                                    {
                                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                                        foreach (var ve in eve.ValidationErrors)
                                        {
                                            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                                ve.PropertyName, ve.ErrorMessage);
                                        }
                                    }
                                    //throw;
                                }
                            }

                        }
                    }
                }

            }
            catch
            {
                MessageBox.Show("Valor inválidos");
            }
           

          
        }



        // Load ComboBox entidad
        public async Task FillCombox()
        {
           
            view.ComboBox1Text.Sorted = true;

            query = new DbConsultation();
            var ListComboBox = query.GetAllComboBox();

            foreach (var item in ListComboBox)
            {
                view.ComboBox1Text.Items.Add(item.nome);

            }
        }


        // Add to textbox num doc (Obrano)
        public async Task NumDoc()
        {
            query = new DbConsultation();
            var max = query.GetMax();

            if (max != "true")
            {
                var num = Int32.Parse(max);
                var num1 = ++num;
                var maxString = num1.ToString();
                view.NDocText = maxString;
               
            }
            else
            {
                view.NDocText = "1";        
            }      
        }
         
        // Direct Obrano of database
        public String NumDoc2()
        {
            string doc;
            query = new DbConsultation();
            var max = query.GetMax();

            if (max != "true")
            {
                var num = Int32.Parse(max);
                var num1 = ++num;
                var maxString = num1.ToString();
                doc = maxString;

                return doc;

            }
            else
            {
                doc = "1";
                return doc;
            }
        }


        // Search id user3 in Database and add  Row of Ref for comboxDatagridview Ref
        public DataGridViewComboBoxColumn SearchListId()
        {
            query = new DbConsultation();
            var ListCD = query.GetComboBoxDataGrid();
            //var ListCD = query.GetIdSt(y);

            DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();
            combo.HeaderText = "Design";        
            combo.Name = "combo";

            foreach (var item in ListCD)
            {
                combo.Items.Add(item.design);

            }

            return combo;

        }


        // Get List of table ST, no repeated items
        public DataGridViewComboBoxColumn SearchListIdCategoria()
        {
            query = new DbConsultation();
            var ListCD = query.GetAllComboBoxSt().GroupBy(o => new { o.usr3 }).
                                                        Select(o => o.FirstOrDefault());

            DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();
            combo.HeaderText = "Cat";
            combo.Name = "combo";

            foreach (var item in ListCD)
            {
                combo.Items.Add(item.usr3);

            }

            return combo;

        }


        // Search usr3 in Table st
        public DataGridViewComboBoxColumn SearchListIdReferencia(String y)
        {
            query = new DbConsultation();
            var ListCD = query.GetIdSt(y);

         
            DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();
            combo.HeaderText = "Ref";
            combo.Name = "combo2";

            foreach (var item in ListCD)
            {
                combo.Items.Add(item._ref);

            }

            return combo;

        }



        // Search Design and Load Ref dataGridView (Cell 1, columns 1)
        public void SearchId(string x, int n)
        {
            var valueSearch = x;
            int index = n;

            try
            {           
                    query = new DbConsultation();
                    var obj = query.GetId(valueSearch);
                    var objName = obj._ref;

                    view.DataGridText[1, index].ReadOnly = true;
                    view.DataGridText[1, index].Value = objName;
             
            }
            catch
            {
                ///habla.Falar("Não existe");
                //MessageBox.Show("Não existe ");
            }
        }

     
        private void Active()
        {
            view.ButtonNewText.Enabled = false;
            view.ButtonSendText.Enabled = true;
            view.ButtonDeleteText.Enabled = true;
            view.ButtonDeleteAllText.Enabled = true;
            view.ButtonLineText.Enabled = true;
            view.ButtonPrintText.Enabled = true;
        }

        #endregion
    }
}
