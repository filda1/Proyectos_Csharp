using RequisicaoSServer.Models;
using RequisicaoSServer.Views;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RequisicaoSServer.Presenters
{
    public class CategoryPresenters
    {
        #region Variables

        DbConsultation query;
        private IInterfaz2 view2;

        public string Year = DateTime.Now.Year.ToString();
        public string Date = DateTime.Now.ToShortDateString();
        public DateTime Today = DateTime.Now;

        #endregion

        #region Constructor

        public CategoryPresenters()
        {
        }

        public CategoryPresenters(IInterfaz2 screen)
        {
            view2 = screen;
        }

        #endregion


        #region Methods

        // Send Database 
          //save value combobox Entidad,  value combobox Categoria, value combobox Ref/Design in -------------------------------> table bo
          // and save value Ref of datagridview, Design of datagridview, Qta of datagridview in --------------------------------> table bi
 
        public void Central()
        {

            try
            {
               var valorEntid = view2.ComboBox3Form3.SelectedItem.ToString();
               var valorCate = view2.ComboBox1Form3.SelectedItem.ToString();
               var valorRef = view2.ComboBox2Form3.SelectedItem.ToString();

                if ( valorEntid != null && valorCate != null && valorRef !=null)
                 {
                    string base64Guid = Convert.ToBase64String(Guid.NewGuid().ToByteArray());
                   // Insert in database, head of form 

                   //var nDocumento = view2.numDocForm3.Text;

                    var nDocumento = NumDoc2();
                    var dates = Year;

        
                    decimal voano = Decimal.Parse(Year);
                    decimal numeroDo = Decimal.Parse(nDocumento);

                    var valorEntidad = view2.ComboBox3Form3.SelectedItem.ToString();

                
                    try
                    {
                         bo b = new bo
                            {
                              bostamp = base64Guid , nmdos = "Requisição Interna", obrano = numeroDo, dataobra = DateTime.Now,  nome = valorEntidad, tipo = "Interno", datafinal = DateTime.Now, boano =voano, dataopen =DateTime.Now, datafecho = DateTime.Now,
                              vendnm = "nn", obranome = "n", tecnnm = "n", maquina = "n", marca = "n", serie = "n", zona = "n", obs = "n", trab1 = "n", trab2 = "n", trab3 = "n", trab4 = "n",trab5 = "n",
                              ndos = 35, custo = 0, moeda = "EURO", morada = "nnn", local = "n", codpost = "n", ultfact = DateTime.Now, tabela1 = "n", ncont = "n", segmento = "n", userimpresso = "n", fref = "n",
                              ccusto = "n", ncusto = "n", cobranca = "n", memissao = "EURO", nome2 = "n", pastamp = "n", snstamp = "n", mastamp = "n", origem = "BO", site = "n", pnome = "n", cxstamp = "n",
                              cxusername = "n", ssstamp = "n", ssusername = "n", series = "n", series2 = "n", quarto = "n", tabela2 = "n", obstab2 = "n", iemail = "n", inome = "n", lang = "n", ean = "n",
                              iecacodisen = "n", dtclose = DateTime.Now, tpstamp = "n", tpdesc = "n", statuspda = "n", ousrinis = "n", ousrdata = DateTime.Now, ousrhora = DateTime.Now.ToString("HH:mm:ss"), usrinis = "n",usrdata = DateTime.Now,
                              usrhora = DateTime.Now.ToString("HH:mm:ss"), /*u_gpgasto = "nn",*/ u_matricul = "nn", /*u_motorist = "nn",*//*u_tpgasto = "nn"*/
                            };

                    

                          DbConsultation query = new DbConsultation();
                          query.Add2(b);


                          // Insert in database , all of datagridView
                          var count = view2.DataGridForm3.Rows.Count;
                          bi[] miObj = new bi[count];

                             for (int i = 0; i < view2.DataGridForm3.Rows.Count; i++)
                             {
                   
                    
                                 var n = i.ToString();

                                 System.Guid guid = System.Guid.NewGuid();
                                 byte[] guidbytes = guid.ToByteArray();
                                 string uidBi = Convert.ToBase64String(guidbytes).Trim('=');

                                 string cell1 = view2.DataGridForm3.Rows[i].Cells[0].Value.ToString();

                      
                                 var cell2 = view2.DataGridForm3.Rows[i].Cells[1].Value.ToString();

                                 var cel3 = view2.DataGridForm3.Rows[i].Cells[2].Value.ToString();
                                Decimal cell3 = Decimal.Parse(cel3);


                                using (DBConnect db = new DBConnect())
                                {

                                  miObj[i] = new bi
                                 {
                                  bistamp = uidBi, nmdos = "Requisição Interna", obrano = numeroDo, _ref = cell1, design = cell2, qtt = cell3, serie = "n", fdata = DateTime.Now, nmdoc = "n", forref = "n", rdata = DateTime.Now, dedata = DateTime.Now,
                                  atedata = DateTime.Now, lobs = "n", obranome = "n", datafinal = DateTime.Now, dataobra = DateTime.Now, dataopen = DateTime.Now, datafecho = DateTime.Now, maquina = "n",
                                  marca = "n", zona = "n", litem = "n", lobs2 = "n", litem2 = "n", lobs3 = "n", lrecno = "n", local = "n", morada = "n", codpost = "n", nome = valorEntidad, vendnm = "n", tabela1 = "n",
                                  reff = "n", lote = "n", cor = "n", tam = "n", segmento = "n", bofref = "n", bifref = "n", biserie = "n", adoc = "n", codigo = "n", obistamp = "n", oobistamp = "n", usr1 = "n",
                                  usr2 = "n", usr3 = "n", usr4 = "n", usr5 = "n", usr6 = "n", unidade = "n", unidad2 = "n", oftstamp = "n", ofostamp = "n", familia = "n", nccod = "n", ncinteg = "n", classifc = "n",
                                  posic = "n", series = "n", series2 = "n", ccusto = "n", ncusto = "n", oobostamp = "n", ltab1 = "n", ltab2 = "n", ltab3 = "n", ltab4 = "n", ltab5 = "n", fami = "n", iecacodisen = "n",
                                  codfiscal = "n", dgeral = "n", tiposemp = "n", dtclose = DateTime.Now, quarto = "n", efornecedor = "n", optstamp = "n", oristamp = "n", bostamp = base64Guid, ousrinis = "n",
                                  ousrdata = DateTime.Now, ousrhora = DateTime.Now.ToString("HH:mm:ss"), usrinis = "n", usrdata = DateTime.Now, usrhora = DateTime.Now.ToString("HH:mm:ss"), //u_matric = "n"
                                };



                                 db.bi.Add(miObj[i]);
                                 db.SaveChanges();
                        

                             } 
                    }


                         // Email 
                         var assunto = "Requisição Interna" + ":" + " " + DateTime.Now.ToString();
                         var descripcion = "Requisição Interna:" + " " + numeroDo + " ," + " " + "de" + " " + voano;

                         try
                         {
                              var qw = "";
                              Email em = new Email();
                              em.email(assunto, descripcion, qw);
                         }

                        catch
                         {

                             MessageBox.Show("Ok enviado com sucesso!!");

                         }
            
                    }

                  catch
                    {
                         MessageBox.Show("Erro no envio");
                    }
                }
                else
                {
                 MessageBox.Show("Valor vazio em Entidad/Categoria/Ref ***");
                }
            }
           catch
            {

             MessageBox.Show("Valor vazio em Entidad/Categoria/Ref");
            }                    
           
        }


        // Load ComboBox entidad en Form3, table Ag in database
        public async Task FillComboxPesquisa()
        {

            view2.ComboBox3Form3.Sorted = true;

            DbConsultation query = new DbConsultation();
            var ListComboBox = query.GetAllComboBox();

            foreach (var item in ListComboBox)
            {
                view2.ComboBox3Form3.Items.Add(item.nome);

            }
        }


        // Load ComboBox Category in Form3
        public async Task FillComboxCatg()
        {

            view2.ComboBox1Form3.Sorted = true;

            query = new DbConsultation();
            var ListComboBox = query.GetAllComboBoxSt().GroupBy(o => new { o.usr3 }).
                                                        Select(o => o.FirstOrDefault());

            foreach (var item in ListComboBox)
            {
                view2.ComboBox1Form3.Items.Add(item.usr3);

            }
        }


        // Add to textbox num doc(Obrano) in Form3
        public async Task NumDocPesquisa()
        {
            query = new DbConsultation();
            var max = query.GetMax();

            if (max != "true")
            {
                var num = Int32.Parse(max);
                var num1 = ++num;
                var maxString = num1.ToString();
                view2.numDocForm3.Text = maxString;

            }
            else
            {
                view2.numDocForm3.Text = "1";
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


        // Insert datagridview Form3, Ref, Design
        public void InsertSearchDatagridForm3(string x)
        {
            try
            {
                query = new DbConsultation();
                var obj = query.GetIdRef(x);
                var refer = obj._ref;
                var designt = obj.design;


                ArrayList row = new ArrayList
               {   refer, designt,  "0" };

                view2.DataGridForm3.Rows.Add(row.ToArray());
            }
            catch
            {

                //MessageBox.Show("Valor inválido em Design");

            }

        }


        // Search Ref from combox category
        public void SearchIdRefPesquisa(string x)
        {
            var valueSearch = x;
            //int index = n;

            try
            {

                if (string.IsNullOrEmpty(valueSearch))
                {
                    // habla.Falar("Ref esta vazia");
                    MessageBox.Show("Categoria vazia");
                }


                query = new DbConsultation();
                var ListComboBox = query.GetIdSt(valueSearch);

                foreach (var item in ListComboBox)
                {
                    view2.ComboBox2Form3.Items.Add(item._ref + item.design);
                
                }

            }
            catch
            {
                ///habla.Falar("Não existe");
                MessageBox.Show("Valor não válido");
            }
        }

        #endregion
    }
}
