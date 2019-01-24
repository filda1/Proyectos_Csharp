using Newtonsoft.Json;
using Requisicao.Models;
using Requisicao.Presenters;
using Requisicao.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Requisicao.Views;
using System.Collections;
using System.IO;
using System.Xml;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Threading;

namespace Requisicao
{
    public partial class Form1 : Form, IPedido
    {
        DataGridViewComboBoxColumn dc;
        public Form1()
        {
            InitializeComponent();
        }

        //Interface
        public ComboBox ComboBoxEntidades
        {

            get => comboBox1;
            set => comboBox1 = value;
        }


        public DataGridView DataGridText
        {

            get => dataGridView1;
            set => dataGridView1 = value;
        }


        // Load the entidades combobox and columns datagridview
        private void Form1_Load(object sender, EventArgs e)
        {
            RequisicaoPresenter rp = new RequisicaoPresenter(this);
            rp.Requisicao();
            Colummns_DataGridView();
            GetAllProdutos();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RequisicaoPresenter rp = new RequisicaoPresenter(this);
            rp.Requisicao();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProduto();

        }



        private void button2_ClickAsync(object sender, EventArgs e)
        {
            GetAllProdutos3();


        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // Columns  DataGridView
        public void Colummns_DataGridView()
        {

            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Ref";

            dataGridView1.Columns[1].Name = "Design";
            dataGridView1.Columns[2].Name = "Qtd";

            dataGridView1.Columns[0].Width = 400;
            dataGridView1.Columns[1].Width = 400;
            dataGridView1.Columns[2].Width = 400;

            // COLOR CAMPO,  Note===> DataGridView has to be EnableHeadersVisualStyles==FALSE
            DataGridViewColumn dataGridViewColumn = dataGridView1.Columns[0];
            dataGridViewColumn.HeaderCell.Style.BackColor = Color.Beige;
            dataGridViewColumn.HeaderCell.Style.ForeColor = Color.Black;
        }



       // DataGridView, tabla st (Articulos)
        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {

            // Datagridview
            if (e.KeyCode == Keys.Enter)
            {

                try
                {
                    for (int i = 0; i < 1000; i++)
                    {


                        var valueFila = dataGridView1.Rows[i].Cells[0].Value;


                        String uri = "http://localhost:49668/api/sts/" + valueFila;


                        var cliente = new WebClient();
                        var text = cliente.DownloadString(uri);

                        St result = JsonConvert.DeserializeObject<St>(text);

                        dataGridView1[1, i].Value = result.design;
               

                    }
                }
              
                catch
                {

                }



                    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    ///
                    //   RequisicaoPresenter rc = new RequisicaoPresenter(this);
                    //  rc.ValueRowns();

                    /*/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                                    /*     for (int i =0; i < 1000; i++)
                                         {
                                             // VALOR DE ENTRADA


                                           //  if (dataGridView1.Rows.Count > 0 && i>= 0 && 0 >= 0)
                                             {
                                                 // DataGridViewCell cell = MainGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                                               //  DataGridViewCell 
                                             }



                                             try
                                             {
                                                 var valueFila = dataGridView1.Rows[i].Cells[0].Value.ToString();
                                                 var x = Json(valueFila);
                                                 dataGridView1[1, i].Value = x.userId;
                                                 dataGridView1[2, i].Value = x.title;
                                             }

                                             catch (Exception)
                                             {

                                             }


                                         }
                             */

                }
            }

        public async void AddProduto()
        {
            var uid = Regex.Replace(Convert.ToBase64String(Guid.NewGuid().ToByteArray()), "[/+=]", "");

            Bi prod = new Bi();
           // prod.bistamp = uid; prod.nmdos = "RI"; prod.obrano =12; prod.reff = "V008"; prod.design = "XXXX"; prod.qtt = 1; prod.qtt2 = 0; prod.iva = 23; prod.tabiva = 2;prod.armazem = 1;prod.pu = 0;
            prod.debito = 0;  prod.prorc = 0; prod.stipo = 0; prod.no = 1; prod.pcusto = 0; prod.serie = "Null"; prod.nomquina = 0; prod.nopat = 0; prod.fno = 0;// prod.fdata = DateTime.Now;
            prod.nmdoc = "Null"; prod.ndoc = 0; prod.ndos = 35; prod.forref = "Null"; prod.txiva = 23;// prod.rdata = DateTime.Now; prod.dedata = DateTime.Now; prod.atedata = DateTime.Now; prod.lobs = "Null"; prod.ldossier = 0;
            prod.obranome = "Null"; prod.fechada = false; //prod.datafinal = DateTime.Now; prod.dataobra = DateTime.Now; prod.dataopen = DateTime.Now; prod.datafecho = DateTime.Now; prod.tecnico = 0; prod.maquina = "Null"; prod.marca = "Null"; prod.zona = "Local";
            prod.litem = "Null"; prod.vumoeda = 0; prod.resfor = false; prod.rescli = true; prod.resrec = false; prod.iprint = false; prod.lobs2 = "Null"; prod.litem2 = "Null"; prod.lobs3 = "Null"; prod.estab = 0;
            prod.resusr = false; prod.ar2mazem = 0; prod.composto = false; prod.compostoori = false; prod.lrecno = "X"; prod.lordem = 0; prod.fmarcada = false; prod.producao = false; prod.local = "XXXXX"; prod.morada = "XXXX";
            prod.codpost = "XXXXXX"; prod.nome = "XXXX"; prod.vendedor = 0; prod.vendnm = ""; prod.tabfor = false; prod.tabela1 = "Null"; prod.descli = false; prod.reff = "Null"; prod.lote = "Null"; prod.ivaincl = false;
            prod.cor = "Null"; prod.tam = "Null"; prod.segmento = "Null"; prod.bofref = "Null"; prod.bifref = "Null"; prod.grau = 0; prod.partes = 0; prod.partes2 = 0; prod.altura = 0; prod.largura = 0;
            prod.espessura = 0; prod.biserie = "Null"; prod.infref = false; prod.lifref = false; prod.uni2qtt = 0; prod.epu = 0; prod.edebito = 0; prod.eprorc = 0; prod.epcusto = 0; prod.ttdeb = 0;
            prod.ettdeb = 0; prod.ttmoeda = 0; prod.adoc = "Null"; prod.binum1 = 0; prod.binum2 = 0; prod.codigo = "Null"; prod.cpoc = 0; prod.stns = false; prod.obistamp = "Null"; prod.oobistamp = "Null";
            prod.usr1 = "Null"; prod.usr2 = "Null"; prod.usr3 = "Null"; prod.usr4 = "Null"; prod.usr5 = "Null"; prod.usr6 = "Null"; prod.usalote = false; prod.texteis = false; prod.unidade = "Null"; prod.unidad2 = "Null";
            prod.oftstamp = "Null"; prod.ofostamp = "Null"; prod.promo = false; prod.epromo = false; prod.familia = "Null"; prod.sattotal = false; prod.noserie = false; prod.slvu = 0; prod.eslvu = 0; prod.sltt = 0;
            prod.esltt = 0; prod.slvumoeda = 0; prod.slttmoeda = 0; prod.ncmassa = 1; prod.ncunsup = 1; prod.ncvest = 0; prod.encvest = 0; prod.nccod = "0"; prod.ncinteg = "Null"; prod.classif = 0;
            prod.classifc = "Null"; prod.posic = "Null"; prod.desconto = 0; prod.desc2 = 0; prod.desc3 = 0; prod.desc4 = 0; prod.desc5 = 0; prod.desc6 = 0; prod.series = "Null"; prod.series2 = "Null";
            prod.ccusto = "Null"; prod.ncusto = "Null"; prod.num1 = 0; prod.fechabo = false; prod.oobostamp = "Null"; prod.ltab1 = "Null"; prod.ltab2 = "Null"; prod.ltab3 = "Null"; prod.ltab4 = "Null"; prod.ltab5 = "Null";
            prod.fami = "Null"; prod.pctfami = 0; prod.adjudicada = false; prod.tieca = 0; prod.etieca = 0; prod.mtieca = 0; prod.volume = 0; prod.iecasug = false; prod.iecagrad = 0; prod.iecacodisen = "Null";
            prod.peso = 0; prod.pbruto = 0; prod.codfiscal = "Null"; prod.dgeral = "Null"; prod.temoci = false; prod.temomi = false; prod.temsubemp = false; prod.encargo = 0; prod.eencargo = 0; prod.custoind = 0; prod.ecustoind = 0;
            prod.tiposemp = "Null"; prod.pvok = false; prod.boclose = false;// prod.dtclose = DateTime.Now; prod.quarto = "Null"; prod.emconf = false; prod.efornecedor = "Null"; prod.efornec = 0; prod.efornestab = 0; prod.cativo = false;
            prod.optstamp = "Null"; prod.oristamp = "Null"; prod.temeco = false; prod.ecoval = 0; prod.eecoval = 0; prod.tecoval = 0; prod.etecoval = 0; prod.ecoval2 = 0; prod.eecoval2 = 0; prod.tecoval2 = 0;
            prod.etecoval2 = 0; prod.econotcalc = false; prod.bostamp = "Null"; prod.ousrinis = "Null";// prod.ousrdata = DateTime.Now; prod.ousrhora = DateTime.Now.ToString("HH:mm:ss"); prod.usrinis = "Null"; prod.usrdata = DateTime.Now;  prod.usrhora = DateTime.Now.ToString("HH:mm:ss");
            prod.marcada = false; prod.mntencargos = false; prod.debitoori = 0; prod.edebitoori = 0; prod.trocaequi = false; prod.tpromo = 0; prod.valdesc = 0; prod.evaldesc = 0; prod.u_matric = "Null";


             /* Bo bo = new Bo();
               bo.bostamp = uid; bo.nmdos = "YYY"; bo.obrano = 17;  bo.nome = "n";   bo.tipo = "n";
               bo.boano = 2018;
               bo.vendnm = "nn";bo.obranome = "n"; bo.tecnnm = "n";  bo.maquina = "n"; bo.marca = "n"; bo.serie = "n"; bo.zona = "n";
               bo.obs = "n"; bo.trab1 = "n"; bo.trab2 = "n"; bo.trab3 = "n"; bo.trab4 = "n"; bo.trab5 = "n"; bo.ndos = 35; bo.custo = 0; bo.moeda = "n";
               bo.morada = "nnn"; bo.local = "n";
               bo.codpost = "n"; bo.tabela1 = "n"; bo.ncont = "n";bo.segmento = "n";   bo.userimpresso = "n";  bo.fref = "n";
               bo.ccusto = "n";  bo.ncusto = "n"; bo.cobranca = "n";
               bo.memissao = "n"; bo.nome2 = "n"; bo.pastamp = "n";
               bo.snstamp = "n"; bo.mastamp = "n"; bo.origem = "n";  
               bo.site = "n";
               bo.pnome = "n";
               bo.cxstamp = "n";
               bo.cxusername = "n";
               bo.ssstamp = "n";
               bo.ssusername = "n";
               bo.series = "n";bo.series2 = "n";
               bo.quarto = "n";  bo.tabela2 = "n";
               bo.obstab2 = "n"; bo.iemail = "n";
               bo.inome = "n";bo.lang = "n"; bo.ean = "n";
               bo.iecacodisen = "n";
               bo.tpstamp = "n";
               bo.tpdesc = "n";
               bo.statuspda = "n";
               bo.ousrinis = "n";
               bo.ousrhora = "n";
               bo.usrinis = "n";
               bo.usrhora = "nnn";
               bo.u_gpgasto = "nn";
               bo.u_matricul = "nn";
               bo.u_motorist = "nn";
               bo.u_tpgasto = "nn"; */


           Bo bo = new Bo();
            bo.bostamp = uid; bo.nmdos = "Proposta C"; bo.obrano =1; bo.dataobra = DateTime.Now; bo.nome = "nh"; bo.totaldeb = 33; bo.etotaldeb = 0; bo.tipo = "n"; bo.datafinal = DateTime.Now; bo.smoe4 = 0;
            bo.smoe3 = 0; bo.smoe2 = 0; bo.smoe1 = 0; bo.moetotal = 0; bo.sdeb2 = 0; bo.sdeb1 = 0; bo.sdeb4 = 0; bo.sdeb3 = 0; bo.sqtt14 = 0; bo.sqtt13 = 0;
            bo.sqtt12 = 0; bo.sqtt11 = 0; bo.sqtt24 = 0; bo.sqtt23 = 0; bo.sqtt22 = 0; bo.sqtt21 = 0; bo.vqtt24 = 0; bo.vqtt23 = 0; bo.vqtt22 = 0; bo.vqtt21 = 0;
            bo.vendedor = 0; bo.vendnm = "n"; bo.stot1 = 0; bo.stot2 = 0; bo.stot3 = 0; bo.stot4 = 0; bo.no = 0; bo.obranome = "n"; bo.boano = 2019; bo.dataopen = DateTime.Now;
            bo.datafecho = DateTime.Now; bo.fechada = false; bo.nopat = 0; bo.total = 0; bo.tecnico = 0; bo.tecnnm = "n"; bo.nomquina = 0; bo.maquina = "n"; bo.marca = "n"; bo.serie = "n";
            bo.zona = "n"; bo.obs = "n"; bo.trab1 = "n"; bo.trab2 = "n"; bo.trab3 = "n"; bo.trab4 = "n"; bo.trab5 = "n"; bo.ndos = 2; bo.custo = 0; bo.moeda = "n";
            bo.estab = 0; bo.morada = "n"; bo.local = "n"; bo.codpost = "n"; bo.ultfact = DateTime.Now; bo.period = 0; bo.tabela1 = "n"; bo.ncont = "n"; bo.logi1 = false; bo.logi2 = false;
            bo.logi3 = false; bo.logi4 = false; bo.logi5 = false; bo.logi6 = false; bo.logi7 = false; bo.logi8 = false; bo.segmento = "n"; bo.impresso = false; bo.userimpresso = "n"; bo.fref = "n";
            bo.ccusto = "n"; bo.ncusto = "n"; bo.cobranca = "n"; bo.infref = false; bo.lifref = false; bo.esdeb1 = 0; bo.esdeb2 = 0; bo.esdeb3 = 0; bo.esdeb4 = 0; bo.evqtt21 = 0;
            bo.evqtt22 = 0; bo.evqtt23 = 0; bo.evqtt24 = 0; bo.estot1 = 0; bo.estot2 = 0; bo.estot3 = 0; bo.estot4 = 0; bo.etotal = 0; bo.ecusto = 0; bo.bo_2tdesc1 = 0;
            bo.bo_2tdesc2 = 0; bo.ebo_2tdes1 = 0; bo.ebo_2tdes2 = 0; bo.descc = 0; bo.edescc = 0; bo.bo_1tvall = 0; bo.bo_2tvall = 0; bo.ebo_1tvall = 0; bo.ebo_2tvall = 0; bo.bo11_bins = 0;
            bo.bo11_iva = 0; bo.ebo11_bins = 0; bo.ebo11_iva = 0; bo.bo21_bins = 0; bo.bo21_iva = 0; bo.ebo21_bins = 0; bo.ebo21_iva = 0; bo.bo31_bins = 0; bo.bo31_iva = 0; bo.ebo31_bins = 0;
            bo.ebo31_iva = 0; bo.bo41_bins = 0; bo.bo41_iva = 0; bo.ebo41_bins = 0; bo.ebo41_iva = 0; bo.bo51_bins = 0; bo.bo51_iva = 0; bo.ebo51_bins = 0; bo.ebo51_iva = 0; bo.bo61_bins = 0;
            bo.bo61_iva = 0; bo.ebo61_bins = 0; bo.ebo61_iva = 0; bo.bo12_bins = 0; bo.bo12_iva = 0; bo.ebo12_bins = 0; bo.ebo12_iva = 0; bo.bo22_bins = 0; bo.bo22_iva = 0; bo.ebo22_bins = 0;
            bo.ebo22_iva = 0; bo.bo32_bins = 0; bo.bo32_iva = 0; bo.ebo32_bins = 0; bo.ebo32_iva = 0; bo.bo42_bins = 0; bo.bo42_iva = 0; bo.ebo42_bins = 0; bo.ebo42_iva = 0; bo.bo52_bins = 0;
            bo.bo52_iva = 0; bo.ebo52_bins = 0; bo.ebo52_iva = 0; bo.bo62_bins = 0; bo.bo62_iva = 0; bo.ebo62_bins = 0; bo.ebo62_iva = 0; bo.bo_totp1 = 0; bo.bo_totp2 = 0; bo.ebo_totp1 = 0;
            bo.ebo_totp2 = 0; bo.edi = false; bo.memissao = "n"; bo.nome2 = "n"; bo.pastamp = "n"; bo.snstamp = "n"; bo.mastamp = "n"; bo.origem = "n"; bo.orinopat = 0; bo.iiva = false;
            bo.iunit = false; bo.itotais = false; bo.iunitiva = false; bo.itotaisiva = false; bo.site = "n"; bo.pnome = "n"; bo.pno = 4; bo.cxstamp = "n"; bo.cxusername = "n"; bo.ssstamp = "n";
            bo.ssusername = "n"; bo.alldescli = false; bo.alldesfor = false; bo.series = "n"; bo.series2 = "n"; bo.quarto = "n"; bo.ocupacao = 4; bo.tabela2 = "n"; bo.obstab2 = "n"; bo.iemail = "n";
            bo.inome = "n"; bo.situacao = 0; bo.lang = "n"; bo.ean = "n"; bo.iecacodisen = "n"; bo.boclose = false; bo.dtclose = DateTime.Now; bo.tpstamp = "n"; bo.tpdesc = "n"; bo.emconf = false;
            bo.statuspda = "0"; bo.aprovado = false; bo.boid = 0; bo.ousrinis = "n"; bo.ousrdata = DateTime.Now; bo.ousrhora = DateTime.Now.ToString("HH:mm:ss"); bo.usrinis = "n"; bo.usrdata = DateTime.Now; bo.usrhora = DateTime.Now.ToString("HH:mm:ss");
            bo.marcada = false; bo.u_gpgasto = "n"; bo.u_hrs = 0; bo.u_kms = 0; bo.u_matricul = "n"; bo.u_motorist = "n"; bo.u_tpgasto = "n"; bo.u_totaldoc = 0;




          var URI = "http://localhost:49668/api/boes";


            
                        string responseMessage = string.Empty;

                         string baseAddress = " http://localhost:49668";
                         string apiPath = "/api/boes";
                       // string apiPath = "api/bis";
                         var request = (HttpWebRequest)WebRequest.Create(baseAddress + apiPath);

                         request.Method = "POST";
                        // request.ContentType = "application/x-www-form-urlencoded";
                         request.ContentType = "application/json";
    
                         string jsonOrder = JsonConvert.SerializeObject(bo);
                        // string jsonOrder = JsonConvert.SerializeObject(prod);
                         var data = Encoding.UTF8.GetBytes(jsonOrder);
                         request.ContentLength = data.Length;
                         string message = request.Method + baseAddress + apiPath + request.ContentType;


                         //post data
                         using (var stream = request.GetRequestStream())
                         {
                             stream.Write(data, 0, data.Length);
                         }
                         //get response
                         WebResponse response = request.GetResponse();
                         // Get the stream containing content returned by the server.
                         Stream dataStream = response.GetResponseStream();
                         // Read the content.
                         if (((HttpWebResponse)response).StatusDescription == "OK")
                         {
                             using (var stream = response.GetResponseStream())
                             {
                                 StreamReader reader = new StreamReader(stream);
                                 responseMessage = reader.ReadToEnd();

                             }
                         }
                         

            /*
            using (var client = new HttpClient())
            {

                var serializedProduto = JsonConvert.SerializeObject(bo);
                var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(URI, content);
                var responseString = await result.Content.ReadAsStringAsync();



                if (result.IsSuccessStatusCode)
                {
                    Uri x = result.Headers.Location;
                    MessageBox.Show(responseString);
                }

            }*/





            /* using (var client = new HttpClient())
              {

                  client.BaseAddress = new Uri("http://localhost:49668/");
                  var response = client.PostAsJsonAsync("api/boes", bo).Result;
                  if (response.IsSuccessStatusCode)
                  {
                      MessageBox.Show("Success");
                  }
                  else
                      MessageBox.Show("Error");
              }*/


            /*
               using (var client = new HttpClient())
               {

                   client.BaseAddress = new Uri("http://localhost:49668/");
                   var response = client.PostAsJsonAsync("api/boes", bo).Result;

                   var responseString = await response.Content.ReadAsStringAsync();
                   if (response.IsSuccessStatusCode)
                   {
                       MessageBox.Show("Exito");
                   }
                   else

                         MessageBox.Show(responseString);
               }
               */

            /*/  using (var client = new HttpClient())       
               {

                       var serializedProduto = JsonConvert.SerializeObject(bo);
                       var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
                       var result = await client.PostAsync(URI, content);
                       var responseString = await result.Content.ReadAsStringAsync();

                    

                   if (result.IsSuccessStatusCode)
                 {
                     Uri x = result.Headers.Location;
                    MessageBox.Show(responseString);
                }

               }*/



            //  GetAllProdutos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetProdutoById();

            /* var cliente = new WebClient();
              String uri = "http://localhost:49668/api/boes/GetMaxObrano";

              try
              {
                  var text = cliente.DownloadString(uri);

                  var result = JsonConvert.DeserializeObject<MyRequisicao>(text);

                  textBox1.Text = result.nome;
              }
              catch
              {

              }
              **/
        }

        private async void GetProdutoById()
        {
            using (var client = new HttpClient())
            {

                String uri = "http://localhost:49668/api/boes/GetMaxObrano";
                HttpResponseMessage response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                    var x = JsonConvert.DeserializeObject<MyRequisicao>(ProdutoJsonString);

                    textBox1.Text = x.title; 
                }
                else
                {
                    MessageBox.Show("Falha ao obter o produto : " + response.StatusCode);
                }
            }
        }


        /// Num Maximo Obrano in TextBox1
        private void button4_Click(object sender, EventArgs e)
        {
          
            try
            {
                var cliente = new WebClient();
                //  cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                String uri = "http://localhost:49668/api/boes/GetMaxObrano";

                var text = cliente.DownloadString(uri);
      
                textBox1.Text = text;
             
            }
            catch(Exception)
            {
                textBox1.Text = "0";
            }

        }


        // Entidades de ComBox
        private async void GetAllProdutos()
        {
            String URI = "http://localhost:49668/api/ags";
            //var URI = "http://localhost:50241/api/ags";

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URI))
                {
                    //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    if (response.IsSuccessStatusCode)
                    {
                        var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                        var Lista = JsonConvert.DeserializeObject<Ag[]>(ProdutoJsonString).ToList();

                        foreach (var item in Lista)
                        {

                            comboBox1.Items.Add(item.nome);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível as entidades : " + response.StatusCode);
                    }
                }

            }
        }




        private async void GetAllProdutos2()
        {
            String URI = "http://localhost:49668/api/bis";
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URI))
                {
                    //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    if (response.IsSuccessStatusCode)
                    {
                        var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                        var Lista = JsonConvert.DeserializeObject<Bi[]>(ProdutoJsonString).ToList();

                        foreach (var item in Lista)
                        {

                            comboBox1.Items.Add(item.@ref);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível as entidades : " + response.StatusCode);
                    }
                }

            }
        }


        private async void GetAllProdutos3()
        {
            String URI = "http://localhost:49668/api/boes";
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URI))
                {
                    //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    if (response.IsSuccessStatusCode)
                    {
                        var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                        var Lista = JsonConvert.DeserializeObject<Bo[]>(ProdutoJsonString).ToList();

                        foreach (var item in Lista)
                        {

                            comboBox1.Items.Add(item.nome);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível as entidades : " + response.StatusCode);
                    }
                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GetAllProdutos();
            // RunAsync();
        }

        private void button6_Click(object sender, EventArgs e)
        {

             GetAllProdutos2();

    
        }


        //Fecha
        private void button7_Click(object sender, EventArgs e)
        {
          //var x = DateTime.Now.ToShortDateString();
            //var c = x.ToString();
           var x= DateTime.Now.ToShortTimeString();

            var uid = Regex.Replace(Convert.ToBase64String(Guid.NewGuid().ToByteArray()), "[/+=]", "");
            MessageBox.Show(uid);

           DateTime w= DateTime.Now; 

            MessageBox.Show(w.ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {


            // "1900-01-01T00:00:00"

            var d = "2018-04-12 00:00:00";
            DateTime fecha = DateTime.Parse(d);


            var f = "1900-01-01 00:00:00";
            DateTime fecho = DateTime.Parse(f);



            var uid = Regex.Replace(Convert.ToBase64String(Guid.NewGuid().ToByteArray()), "[/+=]", "");

            Bo bo = new Bo();
            bo.bostamp = uid;        //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            bo.nmdos = "Requisição Abajo";
            bo.obrano = 127;          //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            //bo.dataobra = fecha;
            bo.nome = "n";
            //bo.totaldeb = 23;
            // bo.etotaldeb = 0;
            bo.tipo = "n";
            //bo.datafinal = fecho;
            //bo.smoe4 = 0;
            //bo.smoe3 = 0;
            //bo.smoe2 = 0;
            //bo.smoe1 = 0;
            //bo.moetotal = 0;
            //bo.sdeb2 = 0;
            //bo.sdeb1 = 0;
            //bo.sdeb4 = 0;
            //bo.sdeb3 = 0;
            //bo.sqtt14 = 0;
            //bo.sqtt13 = 0;
            //bo.sqtt12 = 0;
            //bo.sqtt11 = 0;
            //bo.sqtt24 = 0;
            //bo.sqtt23 = 0;
            //bo.sqtt22 = 0;
            //bo.sqtt21 = 0;
            //bo.vqtt24 = 0;
            //bo.vqtt23 = 0;
            //bo.vqtt22 = 0;
            //bo.vqtt21 = 0;
            ///bo.vendedor = 0;
            bo.vendnm = "n";
            //bo.stot1 = 0;
            //bo.stot2 = 0;
            //bo.stot3 = 0;
            //bo.stot4 = 0;
            //bo.no = 10;
            bo.obranome = "n";
            bo.boano = 2018;       //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
           //bo.dataopen = fecha;
           //bo.datafecho = fecho;
           //bo.fechada = false;
           //bo.nopat = 0;
           //bo.total = 0;
           //bo.tecnico = 0;
            bo.tecnnm = "n";
            //bo.nomquina = 0;
            bo.maquina = "n";
            bo.marca = "n";
            bo.serie = "n";
            bo.zona = "n";
            bo.obs = "n";
            bo.trab1 = "n";
            bo.trab2 = "n";
            bo.trab3 = "n";
            bo.trab4 = "n";
            bo.trab5 = "n";
            bo.ndos = 35;        //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
           //bo.custo = 0;
            bo.moeda = "EURO";
            //bo.estab = 0;
            bo.morada = "n";
            bo.local = "n";
            bo.codpost = "n";
            //bo.ultfact = fecho;
            //bo.period = 0;
            bo.tabela1 = "n";
            bo.ncont = "n";
            //bo.logi1 = false;
            //bo.logi2 = false;
            //bo.logi3 = false;
            //bo.logi4 = false;
            //bo.logi5 = false;
            //bo.logi6 = false;
            //bo.logi7 = false;
            //bo.logi8 = false;
            bo.segmento = "n";
            //bo.impresso = false;
            bo.userimpresso = "n";
            bo.fref = "n";
            bo.ccusto = "n";
            bo.ncusto = "n";
            bo.cobranca = "n";
            //bo.infref = false;
            //bo.lifref = false;
            //bo.esdeb1 = 0;
            //bo.esdeb2 = 0;
            //bo.esdeb3 = 0;
            //bo.esdeb4 = 0;
            //bo.evqtt21 = 0;
            //bo.evqtt22 = 0;
            //bo.evqtt23 = 0;
            //bo.evqtt24 = 0;
            //bo.estot1 = 0;
            //bo.estot2 = 0;
            //bo.estot3 = 0;
            //bo.estot4 = 0;
            //bo.etotal = 0;
            //bo.ecusto = 0;
            //bo.bo_2tdesc1 = 0;
            //bo.bo_2tdesc2 = 0;
            //bo.ebo_2tdes1 = 0;
            //bo.ebo_2tdes2 = 0;
            //bo.descc = 0;
            //bo.edescc = 0;
            //bo.bo_1tvall = 0;
            //bo.bo_2tvall = 0;
            //bo.ebo_1tvall = 0;
            //bo.ebo_2tvall = 0;
            //bo.bo11_bins = 0;
            //bo.bo11_iva = 0;
            //bo.ebo11_bins = 0;
            //bo.ebo11_iva = 0;
            //bo.bo21_bins = 0;
            //bo.bo21_iva = 0;
            //bo.ebo21_bins = 0;
            //bo.ebo21_iva = 0;
            //bo.bo31_bins = 0;
            //bo.bo31_iva = 0;
            //bo.ebo31_bins = 0;
            //bo.ebo31_iva = 0;
            //bo.bo41_bins = 0;
            //bo.bo41_iva = 0;
            //bo.ebo41_bins = 0;
            //bo.ebo41_iva = 0;
            //bo.bo51_bins = 0;
            //bo.bo51_iva = 0;
            //bo.ebo51_bins = 0;
            //bo.ebo51_iva = 0;
            //bo.bo61_bins = 0;
            //bo.bo61_iva = 0;
            //bo.ebo61_bins = 0;
            //bo.ebo61_iva = 0;
            //bo.bo12_bins = 0;
            //bo.bo12_iva = 0;
            //bo.ebo12_bins = 0;
            //bo.ebo12_iva = 0;
            //bo.bo22_bins = 0;
            //bo.bo22_iva = 0;
            //bo.ebo22_bins = 0;
            //bo.ebo22_iva = 0;
            //bo.bo32_bins = 0;
            //bo.bo32_iva = 0;
            //bo.ebo32_bins = 0;
            //bo.ebo32_iva = 0;
            //bo.bo42_bins = 0;
            //bo.bo42_iva = 0;
            //bo.ebo42_bins = 0;
            //bo.ebo42_iva = 0;
            //bo.bo52_bins = 0;
            //bo.bo52_iva = 0;
            //bo.ebo52_bins = 0;
            //bo.ebo52_iva = 0;
            //bo.bo62_bins = 0;
            //bo.bo62_iva = 0;
            //bo.ebo62_bins = 0;
            //bo.ebo62_iva = 0;
            //bo.bo_totp1 = 0;
            //bo.bo_totp2 = 0;
            //bo.ebo_totp1 = 0;
            //bo.ebo_totp2 = 0;
            //bo.edi = false;
            bo.memissao = "EURO";
            bo.nome2 = "n";
            bo.pastamp = "n";
            bo.snstamp = "n";
            bo.mastamp = "n";
            bo.origem = "BO";
            //bo.orinopat = 0;
            //bo.iiva = false;
            //bo.iunit = false;
            //bo.itotais = false;
            //bo.iunitiva = false;
            //bo.itotaisiva = false;
            bo.site = "n";
            bo.pnome = "n";
            //bo.pno = 4;
            bo.cxstamp = "n";
            bo.cxusername = "n";
            bo.ssstamp = "n";
            bo.ssusername = "n";
            //bo.alldescli = false;
            //bo.alldesfor = false;
            bo.series = "n";
            bo.series2 = "n";
            bo.quarto = "n";
            //bo.ocupacao = 4;
            bo.tabela2 = "n";
            bo.obstab2 = "n";
            bo.iemail = "n";
            bo.inome = "n";
            //bo.situacao = 0;
            bo.lang = "n";
            bo.ean = "n";
            bo.iecacodisen = "n";
            //bo.boclose = false;
            //bo.dtclose = fecho;
            bo.tpstamp = "n";
            bo.tpdesc = "n";
            //bo.emconf = false;
            bo.statuspda = "0";
            //bo.aprovado = false;
            bo.boid = 000;
            bo.ousrinis = "n";
            //bo.ousrdata = fecha;
            bo.ousrhora = DateTime.Now.ToString("HH:mm:ss");
            bo.usrinis = "n";
            //bo.usrdata = fecha;
            bo.usrhora = DateTime.Now.ToString("HH:mm:ss");
            //bo.marcada = false;
            bo.u_gpgasto = "n";
            //bo.u_hrs = 0;
            //bo.u_kms = 0;
            bo.u_matricul = "n";
            bo.u_motorist = "n";
            bo.u_tpgasto = "n";
            //bo.u_totaldoc = 0;


/*
            var URI = "http://localhost:49668/api/boes";


            string responseMessage = string.Empty;

            string baseAddress = " http://localhost:49668/";
            string apiPath = "api/boes";
            // string apiPath = "api/bis";
            var request = (HttpWebRequest)WebRequest.Create(baseAddress + apiPath);

            request.Method = "POST";
            // request.ContentType = "application/x-www-form-urlencoded";
            request.ContentType = "application/json";
            request.ProtocolVersion = HttpVersion.Version10;

            string jsonOrder = JsonConvert.SerializeObject(bo);
            // string jsonOrder = JsonConvert.SerializeObject(prod);
            var data = Encoding.UTF8.GetBytes(jsonOrder);
            request.ContentLength = data.Length;
            string message = request.Method + baseAddress + apiPath + request.ContentType;


            //post data
            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }
            //get response
            WebResponse response = request.GetResponse();
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Read the content.
            if (((HttpWebResponse)response).StatusDescription == "OK")
            {
                using (var stream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(stream);
                    responseMessage = reader.ReadToEnd();

                }
            }

            */

            var parametros = new Dictionary<string, string>();
            parametros.Add("username", "");
            parametros.Add("password", "");
            parametros.Add("client_id", "");
            parametros.Add("grant_type", "");

            using (var cliente = new HttpClient())
            {
                cliente.BaseAddress = new Uri("http://localhost:49668/api/boes");
                var content = new FormUrlEncodedContent(parametros);
                var request =  cliente.PostAsync("/auth", content);
                //  request.Content.ReadAsStringAsync();
            }

        }
      

        private void button9_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime(2008, 3, 9, 16, 5, 7, 123);
            // DateTime d = DateTime.s

            //DateTime myDate = DateTime.ParseExact("1900-01-01 14:40:52", "yyyy-MM-dd HH:mm:ss",

            //  "1900-01-01T00:00:00"

            // System.Globalization.CultureInfo.InvariantCulture);
            //  MessageBox.Show(myDate.ToString());

            // var d = "1900-01-01T00:00:00";

            // var o = Convert.ToDateTime("1900-01-01T00:00:00");

            var myStr = "2018-01-01";

            //  var x=  DateTime.ParseExact(myStr, "yy/MM/dd h:mm:ss tt", CultureInfo.InvariantCulture);


            //  CultureInfo.CreateSpecificCulture("en-US");



            /* CultureInfo cu = new CultureInfo("en-US");
             Thread.CurrentThread.CurrentCulture = cu;*/

            /*     System.Globalization.CultureInfo cultureinfo =
             new System.Globalization.CultureInfo("en-US");
                 DateTime dtss = DateTime.ParseExact(myStr, "yyyy-MM-dd-HH_mm.ss", cultureinfo);*/



            // FormatException: String was not recognized as a valid DateTime.
            //var parse = DateTime.Parse(dateTime, format);

            // DateTime dtff = DateTime.Parse(myStr);

            DateTimeFormatInfo dtfi = CultureInfo.GetCultureInfo("en-US").DateTimeFormat;



            // DateTime dia = DateTime.Now;
            ///   DateTime dia = new DateTime(2008, 3, 9, 16, 5, 7, 123);
            //CultureInfo idioma = new CultureInfo("nl-NL");


            //var x=dia.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss", idioma);

            // var z = dia.ToShortTimeString();
            //DateTime cc = DateTime.Parse(x);

            // DateTime t = DateTime.Parse(z);

            /////////////////////////////////////////////////////////////////////////////


               DateTime dat = new DateTime(2009, 6, 15, 13, 45, 30,
               DateTimeKind.Unspecified);



            string test = "2014-01-02T23:00:00.000Z";
            DateTime das = DateTime.Parse(test);

            DateTime.UtcNow.ToString();

                        var yy = "1900-01-01 00:00:00.0000";

            string StartDate = "07/01/2015";


          var f=  DateTime.ParseExact(StartDate, "M/d/yyyy", null);




            CultureInfo enUS = new CultureInfo("en-US");
            string dateString;
            DateTime dateValue;
            dateString = " 5/01/2009 8:30 AM";
            var a=DateTime.TryParseExact(dateString, "g", enUS, DateTimeStyles.None, out dateValue);

//////////////////////////////////////////////////////////////////////////////////////////////////
            var x = JsonConvert.SerializeObject(DateTime.Now);

            var settings = new JsonSerializerSettings
            {
                DateFormatString = "yyyy-MM-ddTH:mm:ss",
                DateTimeZoneHandling = DateTimeZoneHandling.Unspecified
            };
            var json = JsonConvert.SerializeObject(DateTime.Now, settings);
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///
            DateTime nm = DateTime.Now;
            CultureInfo iv = CultureInfo.InvariantCulture;

            double value = 0.10000;
            DateTime date = DateTime.Now.Date;

            MessageBox.Show(date.ToString());
        }

        private void button10_Click(object sender, EventArgs e)
        {

            var uid = Regex.Replace(Convert.ToBase64String(Guid.NewGuid().ToByteArray()), "[/+=]", "");

            Bo bo = new Bo();
            bo.bostamp = uid;
            bo.nmdos = "Requisição Interna";
            bo.obrano = 128;
            bo.dataobra = DateTime.Now.Date;
            bo.nome = "n";
            bo.totaldeb = 23;
            bo.etotaldeb = 0;
            bo.tipo = "n";
            bo.datafinal = DateTime.Now.Date;
            bo.smoe4 = 0;
            bo.smoe3 = 0;
            bo.smoe2 = 0;
            bo.smoe1 = 0;
            bo.moetotal = 0;
            bo.sdeb2 = 0;
            bo.sdeb1 = 0;
            bo.sdeb4 = 0;
            bo.sdeb3 = 0;
            bo.sqtt14 = 0;
            bo.sqtt13 = 0;
            bo.sqtt12 = 0;
            bo.sqtt11 = 0;
            bo.sqtt24 = 0;
            bo.sqtt23 = 0;
            bo.sqtt22 = 0;
            bo.sqtt21 = 0;
            bo.vqtt24 = 0;
            bo.vqtt23 = 0;
            bo.vqtt22 = 0;
            bo.vqtt21 = 0;
            bo.vendedor = 0;
            bo.vendnm = "n";
            bo.stot1 = 0;
            bo.stot2 = 0;
            bo.stot3 = 0;
            bo.stot4 = 0;
            bo.no = 10;
            bo.obranome = "n";
            bo.boano = 2018;
            bo.dataopen = DateTime.Now.Date;
            bo.datafecho = DateTime.Now.Date;
            bo.fechada = false;
            bo.nopat = 0;
            bo.total = 0;
            bo.tecnico = 0;
            bo.tecnnm = "n";
            bo.nomquina = 0;
            bo.maquina = "n";
            bo.marca = "n";
            bo.serie = "n";
            bo.zona = "n";
            bo.obs = "n";
            bo.trab1 = "n";
            bo.trab2 = "n";
            bo.trab3 = "n";
            bo.trab4 = "n";
            bo.trab5 = "n";
            bo.ndos = 35;
            bo.custo = 0;
            bo.moeda = "EURO";
            bo.estab = 0;
            bo.morada = "n";
            bo.local = "n";
            bo.codpost = "n";
            bo.ultfact = DateTime.Now;
            bo.period = 0;
            bo.tabela1 = "n";
            bo.ncont = "n";
            bo.logi1 = false;
            bo.logi2 = false;
            bo.logi3 = false;
            bo.logi4 = false;
            bo.logi5 = false;
            bo.logi6 = false;
            bo.logi7 = false;
            bo.logi8 = false;
            bo.segmento = "n";
            bo.impresso = false;
            bo.userimpresso = "n";
            bo.fref = "n";
            bo.ccusto = "n";
            bo.ncusto = "n";
            bo.cobranca = "n";
            bo.infref = false;
            bo.lifref = false;
            bo.esdeb1 = 0;
            bo.esdeb2 = 0;
            bo.esdeb3 = 0;
            bo.esdeb4 = 0;
            bo.evqtt21 = 0;
            bo.evqtt22 = 0;
            bo.evqtt23 = 0;
            bo.evqtt24 = 0;
            bo.estot1 = 0;
            bo.estot2 = 0;
            bo.estot3 = 0;
            bo.estot4 = 0;
            bo.etotal = 0;
            bo.ecusto = 0;
            bo.bo_2tdesc1 = 0;
            bo.bo_2tdesc2 = 0;
            bo.ebo_2tdes1 = 0;
            bo.ebo_2tdes2 = 0;
            bo.descc = 0;
            bo.edescc = 0;
            bo.bo_1tvall = 0;
            bo.bo_2tvall = 0;
            bo.ebo_1tvall = 0;
            bo.ebo_2tvall = 0;
            bo.bo11_bins = 0;
            bo.bo11_iva = 0;
            bo.ebo11_bins = 0;
            bo.ebo11_iva = 0;
            bo.bo21_bins = 0;
            bo.bo21_iva = 0;
            bo.ebo21_bins = 0;
            bo.ebo21_iva = 0;
            bo.bo31_bins = 0;
            bo.bo31_iva = 0;
            bo.ebo31_bins = 0;
            bo.ebo31_iva = 0;
            bo.bo41_bins = 0;
            bo.bo41_iva = 0;
            bo.ebo41_bins = 0;
            bo.ebo41_iva = 0;
            bo.bo51_bins = 0;
            bo.bo51_iva = 0;
            bo.ebo51_bins = 0;
            bo.ebo51_iva = 0;
            bo.bo61_bins = 0;
            bo.bo61_iva = 0;
            bo.ebo61_bins = 0;
            bo.ebo61_iva = 0;
            bo.bo12_bins = 0;
            bo.bo12_iva = 0;
            bo.ebo12_bins = 0;
            bo.ebo12_iva = 0;
            bo.bo22_bins = 0;
            bo.bo22_iva = 0;
            bo.ebo22_bins = 0;
            bo.ebo22_iva = 0;
            bo.bo32_bins = 0;
            bo.bo32_iva = 0;
            bo.ebo32_bins = 0;
            bo.ebo32_iva = 0;
            bo.bo42_bins = 0;
            bo.bo42_iva = 0;
            bo.ebo42_bins = 0;
            bo.ebo42_iva = 0;
            bo.bo52_bins = 0;
            bo.bo52_iva = 0;
            bo.ebo52_bins = 0;
            bo.ebo52_iva = 0;
            bo.bo62_bins = 0;
            bo.bo62_iva = 0;
            bo.ebo62_bins = 0;
            bo.ebo62_iva = 0;
            bo.bo_totp1 = 0;
            bo.bo_totp2 = 0;
            bo.ebo_totp1 = 0;
            bo.ebo_totp2 = 0;
            bo.edi = false;
            bo.memissao = "EURO";
            bo.nome2 = "n";
            bo.pastamp = "n";
            bo.snstamp = "n";
            bo.mastamp = "n";
            bo.origem = "BO";
            bo.orinopat = 0;
            bo.iiva = false;
            bo.iunit = false;
            bo.itotais = false;
            bo.iunitiva = false;
            bo.itotaisiva = false;
            bo.site = "n";
            bo.pnome = "n";
            bo.pno = 4;
            bo.cxstamp = "n";
            bo.cxusername = "n";
            bo.ssstamp = "n";
            bo.ssusername = "n";
            bo.alldescli = false;
            bo.alldesfor = false;
            bo.series = "n";
            bo.series2 = "n";
            bo.quarto = "n";
            bo.ocupacao = 4;
            bo.tabela2 = "n";
            bo.obstab2 = "n";
            bo.iemail = "n";
            bo.inome = "n";
            bo.situacao = 0;
            bo.lang = "n";
            bo.ean = "n";
            bo.iecacodisen = "n";
            bo.boclose = false;
            bo.dtclose = DateTime.Now;
            bo.tpstamp = "n";
            bo.tpdesc = "n";
            bo.emconf = false;
            bo.statuspda = "0";
            bo.aprovado = false;
            bo.boid = 0000;
            bo.ousrinis = "n";
            bo.ousrdata = DateTime.Now;
            bo.ousrhora = DateTime.Now.ToString("HH:mm:ss");
            bo.usrinis = "n";
            bo.usrdata = DateTime.Now;
            bo.usrhora = DateTime.Now.ToString("HH:mm:ss");
            bo.marcada = false;
            bo.u_gpgasto = "n";
            bo.u_hrs = 0;
            bo.u_kms = 0;
            bo.u_matricul = "n";
            bo.u_motorist = "n";
            bo.u_tpgasto = "n";
            bo.u_totaldoc = 0;



            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("http://localhost:49668/");
                    client.DefaultRequestHeaders.AcceptCharset.Clear();
              
                    var response = client.PostAsJsonAsync("api/boes", bo).Result;
     
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Success");
                    }
                 
                      
                }
                catch(Exception)
                {
                    MessageBox.Show("Error");
                }
            }
        }






        /*  public async Task<string> RunAsync()
          {
              using (var client = new HttpClient())
              {
                  client.BaseAddress = new System.Uri("http://localhost:49668/");
                  client.DefaultRequestHeaders.Accept.Clear();
                  client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                  HttpResponseMessage response = await client.GetAsync("api/boes/GetMaxObrano");
                  if (response.IsSuccessStatusCode)
                  {  //GET
                      MyRequisicao produto = await response.Content.ReadAsAsync<MyRequisicao>();
                      var x = produto.nome;

                      return x;
                  }


              }*/

        private async void InsertBO()
        {
            var URI = "http://localhost:49668/api/boes";

            var uid = Regex.Replace(Convert.ToBase64String(Guid.NewGuid().ToByteArray()), "[/+=]", "");

            Bo bo = new Bo
            {
                bostamp = uid,
                nmdos = "ABAJO",
                obrano = 126,
                dataobra = DateTime.Now,
                nome = "n",
                totaldeb = 23,
                etotaldeb = 0,
                tipo = "n",
                datafinal = DateTime.Now,
                smoe4 = 0,
                smoe3 = 0,
                smoe2 = 0,
                smoe1 = 0,
                moetotal = 0,
                sdeb2 = 0,
                sdeb1 = 0,
                sdeb4 = 0,
                sdeb3 = 0,
                sqtt14 = 0,
                sqtt13 = 0,
                sqtt12 = 0,
                sqtt11 = 0,
                sqtt24 = 0,
                sqtt23 = 0,
                sqtt22 = 0,
                sqtt21 = 0,
                vqtt24 = 0,
                vqtt23 = 0,
                vqtt22 = 0,
                vqtt21 = 0,
                vendedor = 0,
                vendnm = "n",
                stot1 = 0,
                stot2 = 0,
                stot3 = 0,
                stot4 = 0,
                no = 10,
                obranome = "n",
                boano = 2018,
                dataopen = DateTime.Now,
                datafecho = DateTime.Now,
                fechada = false,
                nopat = 0,
                total = 0,
                tecnico = 0,
                tecnnm = "n",
                nomquina = 0,
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
                ndos = 2,
                custo = 0,
                moeda = "n",
                estab = 0,
                morada = "n",
                local = "n",
                codpost = "n",
                ultfact = DateTime.Now,
                period = 0,
                tabela1 = "n",
                ncont = "n",
                logi1 = false,
                logi2 = false,
                logi3 = false,
                logi4 = false,
                logi5 = false,
                logi6 = false,
                logi7 = false,
                logi8 = false,
                segmento = "n",
                impresso = false,
                userimpresso = "n",
                fref = "n",
                ccusto = "n",
                ncusto = "n",
                cobranca = "n",
                infref = false,
                lifref = false,
                esdeb1 = 0,
                esdeb2 = 0,
                esdeb3 = 0,
                esdeb4 = 0,
                evqtt21 = 0,
                evqtt22 = 0,
                evqtt23 = 0,
                evqtt24 = 0,
                estot1 = 0,
                estot2 = 0,
                estot3 = 0,
                estot4 = 0,
                etotal = 0,
                ecusto = 0,
                bo_2tdesc1 = 0,
                bo_2tdesc2 = 0,
                ebo_2tdes1 = 0,
                ebo_2tdes2 = 0,
                descc = 0,
                edescc = 0,
                bo_1tvall = 0,
                bo_2tvall = 0,
                ebo_1tvall = 0,
                ebo_2tvall = 0,
                bo11_bins = 0,
                bo11_iva = 0,
                ebo11_bins = 0,
                ebo11_iva = 0,
                bo21_bins = 0,
                bo21_iva = 0,
                ebo21_bins = 0,
                ebo21_iva = 0,
                bo31_bins = 0,
                bo31_iva = 0,
                ebo31_bins = 0,
                ebo31_iva = 0,
                bo41_bins = 0,
                bo41_iva = 0,
                ebo41_bins = 0,
                ebo41_iva = 0,
                bo51_bins = 0,
                bo51_iva = 0,
                ebo51_bins = 0,
                ebo51_iva = 0,
                bo61_bins = 0,
                bo61_iva = 0,
                ebo61_bins = 0,
                ebo61_iva = 0,
                bo12_bins = 0,
                bo12_iva = 0,
                ebo12_bins = 0,
                ebo12_iva = 0,
                bo22_bins = 0,
                bo22_iva = 0,
                ebo22_bins = 0,
                ebo22_iva = 0,
                bo32_bins = 0,
                bo32_iva = 0,
                ebo32_bins = 0,
                ebo32_iva = 0,
                bo42_bins = 0,
                bo42_iva = 0,
                ebo42_bins = 0,
                ebo42_iva = 0,
                bo52_bins = 0,
                bo52_iva = 0,
                ebo52_bins = 0,
                ebo52_iva = 0,
                bo62_bins = 0,
                bo62_iva = 0,
                ebo62_bins = 0,
                ebo62_iva = 0,
                bo_totp1 = 0,
                bo_totp2 = 0,
                ebo_totp1 = 0,
                ebo_totp2 = 0,
                edi = false,
                memissao = "n",
                nome2 = "n",
                pastamp = "n",
                snstamp = "n",
                mastamp = "n",
                origem = "n",
                orinopat = 0,
                iiva = false,
                iunit = false,
                itotais = false,
                iunitiva = false,
                itotaisiva = false,
                site = "n",
                pnome = "n",
                pno = 4,
                cxstamp = "n",
                cxusername = "n",
                ssstamp = "n",
                ssusername = "n",
                alldescli = false,
                alldesfor = false,
                series = "n",
                series2 = "n",
                quarto = "n",
                ocupacao = 4,
                tabela2 = "n",
                obstab2 = "n",
                iemail = "n",
                inome = "n",
                situacao = 0,
                lang = "n",
                ean = "n",
                iecacodisen = "n",
                boclose = false,
                dtclose = DateTime.Now,
                tpstamp = "n",
                tpdesc = "n",
                emconf = false,
                statuspda = "0",
                aprovado = false,
                boid = 0,
                ousrinis = "n",
                ousrdata = DateTime.Now,
                ousrhora = DateTime.Now.ToString("HH:mm:ss"),
                usrinis = "n",
                usrdata = DateTime.Now,
                usrhora = DateTime.Now.ToString("HH:mm:ss"),
                marcada = false,
                u_gpgasto = "n",
                u_hrs = 0,
                u_kms = 0,
                u_matricul = "n",
                u_motorist = "n",
                u_tpgasto = "n",
                u_totaldoc = 0
            };


            using (var client = new HttpClient())
            {

                var serializedProduto = JsonConvert.SerializeObject(bo);
                var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(URI, content);
                var responseString = await result.Content.ReadAsStringAsync();



                if (result.IsSuccessStatusCode)
                {
                    Uri x = result.Headers.Location;
                    MessageBox.Show(responseString);
                }

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            InsertBO();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            InsertBI();
        }

        public void InsertBI()
        {
            var d = "2018-04-12 00:00:00.000";       
            DateTime fecha = DateTime.Parse(d);


            var f = "1900-01-01 00:00:00.000";
            DateTime fecho = DateTime.Parse(f);

 /////////////////////////////////////////////////////////////////////////////////////////////////////
            var settings = new JsonSerializerSettings
            {
                DateFormatString = "yyyy-MM-ddTH:mm:ss",
                DateTimeZoneHandling = DateTimeZoneHandling.Unspecified
            };
            var json = JsonConvert.SerializeObject(DateTime.Now, settings);
   ///////////////////////////////////////////////////////////////////////////////////////////////////////
            ///
          //  DateTime nm = DateTime.Now;
          //  CultureInfo iv = CultureInfo.InvariantCulture;



           // MessageBox.Show(nm.ToString("o", iv);

            var uid = Regex.Replace(Convert.ToBase64String(Guid.NewGuid().ToByteArray()), "[/+=]", "");

            Bi p = new Bi
            {

                   bistamp = uid, nmdos = "ZZZZZZ", obrano = 34, @ref = "V002", design = "n", qtt = 123, serie = "n", fdata = DateTime.Now, nmdoc = "n", forref = "n", rdata = DateTime.Now, dedata = DateTime.Now,
                                 atedata = DateTime.Now, lobs = "n", obranome = "n", datafinal = DateTime.Now, dataobra = DateTime.Now, dataopen = DateTime.Now, datafecho = DateTime.Now, maquina = "n",
                                 marca = "n", zona = "n", litem = "n", lobs2 = "n", litem2 = "n", lobs3 = "n", lrecno = "n", local = "n", morada = "n", codpost = "n", nome = "n", vendnm = "n", tabela1 = "n",
                                 reff = "n", lote = "n", cor = "n", tam = "n", segmento = "n", bofref = "n", bifref = "n", biserie = "n", adoc = "n", codigo = "n", obistamp = "n", oobistamp = "n", usr1 = "n",
                                 usr2 = "n", usr3 = "n", usr4 = "n", usr5 = "n", usr6 = "n", unidade = "n", unidad2 = "n", oftstamp = "n", ofostamp = "n", familia = "n", nccod = "n", ncinteg = "n", classifc = "n",
                                 posic = "n", series = "n", series2 = "n", ccusto = "n", ncusto = "n", oobostamp = "n", ltab1 = "n", ltab2 = "n", ltab3 = "n", ltab4 = "n", ltab5 = "n", fami = "n", iecacodisen = "n",
                                 codfiscal = "n", dgeral = "n", tiposemp = "n", dtclose = DateTime.Now, quarto = "n", efornecedor = "n", optstamp = "n", oristamp = "n", bostamp = uid, ousrinis = "n",
                                 ousrdata = DateTime.Now, ousrhora = DateTime.Now.ToString("HH:mm:ss"), usrinis = "n", usrdata = DateTime.Now, usrhora = DateTime.Now.ToString("HH:mm:ss"), u_matric = "n"

            /*   bistamp = uid,
                nmdos = "q",
                obrano = 5,
                @ref = "n",
                design = "n",
                qtt = 1,
                qtt2 = 0,
                iva = 23,
                tabiva = 2,
                armazem = 1,
                pu = 0,
                debito = 0,
                prorc = 0,
                stipo = 4,
                no = 10,
                pcusto = 0,
                serie = "n",
                nomquina = 0,
                nopat = 0,
                fno = 0,
                fdata = DateTime.Now.Date,
                nmdoc = "n",
                ndoc = 0,
                ndos = 35,
                forref = "n",
                txiva = 23,
                rdata = DateTime.Now.Date,
                dedata = DateTime.Now.Date,
                atedata = DateTime.Now.Date,
                lobs = "n",
                ldossier = 0,
                obranome = "n",
                fechada = false,
                datafinal = DateTime.Now.Date,
                dataobra = DateTime.Now.Date,
                dataopen = DateTime.Now.Date,
                datafecho = DateTime.Now.Date,
                tecnico = 0,
                maquina = "n",
                marca = "n",
                zona = "n",
                litem = "n",
                vumoeda = 0,
                resfor = false,
                rescli = true,
                resrec = false,
                iprint = false,
                lobs2 = "n",
                litem2 = "n",
                lobs3 = "n",
                estab = 0,
                resusr = false,
                ar2mazem = 0,
                composto = false,
                compostoori = false,
                lrecno = "n",
                lordem = 10000,
                fmarcada = false,
                producao = false,
                local = "n",
                morada = "n",
                codpost = "n",
                nome = "n",
                vendedor = 0,
                vendnm = "n",
                tabfor = false,
                tabela1 = "n",
                descli = false,
                reff = "n",
                lote = "n",
                ivaincl = true,
                cor = "n",
                tam = "n",
                segmento = "n",
                bofref = "n",
                bifref = "n",
                grau = 0,
                partes = 0,
                partes2 = 0,
                altura = 0,
                largura = 0,
                espessura = 0,
                biserie = "n",
                infref = false,
                lifref = false,
                uni2qtt = 0,
                epu = 0,
                edebito = 0,
                eprorc = 0,
                epcusto = 0,
                ttdeb = 0,
                ettdeb = 0,
                ttmoeda = 0,
                adoc = "n",
                binum1 = 0,
                binum2 = 0,
                codigo = "n",
                cpoc = 0,
                stns = false,
                obistamp = "n",
                oobistamp = "n",
                usr1 = "n",
                usr2 = "n",
                usr3 = "n",
                usr4 = "n",
                usr5 = "n",
                usr6 = "n",
                usalote = false,
                texteis = false,
                unidade = "n",
                unidad2 = "n",
                oftstamp = "n",
                ofostamp = "n",
                promo = false,
                epromo = false,
                familia = "n",
                sattotal = false,
                noserie = false,
                slvu = 0,
                eslvu = 0,
                sltt = 0,
                esltt = 0,
                slvumoeda = 0,
                slttmoeda = 0,
                ncmassa = 0,
                ncunsup = 0,
                ncvest = 0,
                encvest = 0,
                nccod = "n",
                ncinteg = "n",
                classif = 0,
                classifc = "n",
                posic = "n",
                desconto = 0,
                desc2 = 0,
                desc3 = 0,
                desc4 = 0,
                desc5 = 0,
                desc6 = 0,
                series = "n",
                series2 = "n",
                ccusto = "n",
                ncusto = "n",
                num1 = 0,
                fechabo = false,
                oobostamp = "n",
                ltab1 = "n",
                ltab2 = "n",
                ltab3 = "n",
                ltab4 = "n",
                ltab5 = "n",
                fami = "n",
                pctfami = 0,
                adjudicada = false,
                tieca = 0,
                etieca = 0,
                mtieca = 0,
                volume = 0,
                iecasug = false,
                iecagrad = 0,
                iecacodisen = "n",
                peso = 0,
                pbruto = 0,
                codfiscal = "n",
                dgeral = "n",
                temoci = false,
                temomi = false,
                temsubemp = false,
                encargo = 0,
                eencargo = 0,
                custoind = 0,
                ecustoind = 0,
                tiposemp = "n",
                pvok = false,
                boclose = false,
                dtclose = DateTime.Now.Date,
                quarto = "n",
                emconf = false,
                efornecedor = "n",
                efornec = 0,
                efornestab = 0,
                cativo = false,
                optstamp = "n",
                oristamp = "n",
                temeco = false,
                ecoval = 0,
                eecoval = 0,
                tecoval = 0,
                etecoval = 0,
                ecoval2 = 0,
                eecoval2 = 0,
                tecoval2 = 0,
                etecoval2 = 0,
                econotcalc = false,
                bostamp = "n",
                ousrinis = "n",
                ousrdata = DateTime.Now.Date,
                ousrhora = DateTime.Now.ToString("HH:mm:ss"),
                usrinis = "n",
                usrdata = DateTime.Now.Date,
                usrhora = DateTime.Now.ToString("HH:mm:ss"),
                marcada = false,
                mntencargos = false,
                debitoori = 0,
                edebitoori = 0,
                trocaequi = false,
                tpromo = 0,
                valdesc = 0,
                evaldesc = 0,
                u_matric = "n"*/
            };



            //var URI = "http://localhost:50241/api/bis";

             var URI = "http://localhost:49668/api/bis";

                          string username = "";
                          string password = "";
                          String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));

                          string responseMessage = string.Empty;

            string baseAddress = "http://localhost:49668/";
            //string baseAddress = "http://localhost:50241/";


            // string apiPath = "api/boes";
            string apiPath = "api/bis";
                          var request = (HttpWebRequest)WebRequest.Create(baseAddress + apiPath);

                          request.Method = "POST";
                          // request.ContentType = "application/x-www-form-urlencoded";
                          request.ContentType = "application/json";
                          request.Headers.Add("Authorization", "Basic " + encoded);
                          //request.ProtocolVersion = HttpVersion.Version10;


                          // request.UseDefaultCredentials = true;
                          // request.Credentials = new NetworkCredential("", "", "");


                          //  string jsonOrder = JsonConvert.SerializeObject(bo);
                          string jsonOrder = JsonConvert.SerializeObject(p);
                          var data = Encoding.UTF8.GetBytes(jsonOrder);
                          request.ContentLength = data.Length;
                          string message = request.Method + baseAddress + apiPath + request.ContentType;
                          // string message =  baseAddress + apiPath ;

                          //post data

                          using (var stream = request.GetRequestStream())
                          {
                              stream.Write(data, 0, data.Length);

                          }

                          //get response
                          WebResponse response = request.GetResponse();
                          // Get the stream containing content returned by the server.
                          Stream dataStream = response.GetResponseStream();
                          // Read the content.
                          if (((HttpWebResponse)response).StatusDescription == "OK")
                          {
                              using (var stream = response.GetResponseStream())
                              {
                                  StreamReader reader = new StreamReader(stream);
                                  responseMessage = reader.ReadToEnd();

                              }
                          }

            
            /*          var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:49668/api/bis");
                       httpWebRequest.ContentType = "application/json";
                       httpWebRequest.Method = "POST";

                       using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                       {


                           streamWriter.Write(p);
                           streamWriter.Flush();
                           streamWriter.Close();
                       }

                       var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                       using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                       {
                           var result = streamReader.ReadToEnd();
                       }
                       */



          //  var URI = "http://localhost:49668/api/bis";

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////






            /*    using (var client = new HttpClient())
                {
                    var serializedProduto = JsonConvert.SerializeObject(p);
                    var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
                    var result = client.PostAsync(URI, content);
                }



             /*   var urlBase = "http://localhost:49668";
                var servicePrefix = "/api";
                var controller = "/bis";
                try
                {
                    var request = JsonConvert.SerializeObject(p);
                    var content = new StringContent(
                        request, Encoding.UTF8,
                        "application/json");
                    var client = new HttpClient();
                    client.DefaultRequestHeaders.Authorization =
                        new AuthenticationHeaderValue("", "");
                    client.BaseAddress = new Uri(urlBase);
                    var url = string.Format("{0}{1}", servicePrefix, controller);
                    var response = await client.PostAsync(url, content);
                    var result = await response.Content.ReadAsStringAsync();

                    if (!response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("OK");
                    }

                }
                catch (Exception ex)
                {

                }*/



        }


        public Bi PostGetBi()
        {

            var cliente = new WebClient();
            String uri = "http://localhost:49668/api/bis/922-454f-901f-ffac2934356";

            try
            {
                var text = cliente.DownloadString(uri);

                Bi result = JsonConvert.DeserializeObject<Bi>(text);
                return result;
            }
            catch
            {
                return null;
            }


        }



        public void button13_Click(object sender, EventArgs e)
        {
           var obj= PostGetBi();
            //textBox3.Text= obj.@ref;
           // obj.bistamp = "cq16311465148,214000001";

            Bi myBi = new Bi
            {
               // bistamp = "",
                nmdos = obj.nmdos,
                obrano = obj.obrano,
                @ref = obj.@ref,
                design = obj.design,
                qtt = obj.qtt,
                qtt2 = obj.qtt2,
                iva = obj.iva,
                tabiva = obj.tabiva,
                armazem = obj.armazem,
                pu = obj.pu,
                debito = obj.debito,
                prorc = obj.prorc,
                stipo = obj.stipo,
                no = obj.no,
                pcusto = obj.pcusto,
                serie = obj.serie,
                nomquina = obj.nomquina,
                nopat = obj.nopat,
                fno = obj.fno,
                fdata = obj.fdata,
                nmdoc = obj.nmdoc,
                ndoc =obj.ndoc,
                ndos = obj.ndos,
                forref = obj.forref,
                txiva = obj.txiva,
                rdata = obj.rdata,
                dedata = obj.dedata,
                atedata = obj.atedata,
                lobs = obj.lobs,
                ldossier = obj.ldossier,
                obranome = obj.obranome,
                fechada = obj.fechada,
                datafinal = obj.datafinal,
                dataobra = obj.dataobra,
                dataopen = obj.dataopen,
                datafecho = obj.datafecho,
                tecnico = obj.tecnico,             
                maquina = obj.maquina,
                marca = obj.marca,
                zona = obj.zona,
                litem = obj.litem,
                vumoeda = obj.vumoeda,
                resfor = obj.resfor,
                rescli = obj.rescli,
                resrec = obj.resrec,
                iprint = obj.iprint,
                lobs2 = obj.lobs2,
                litem2 = obj.litem2,
                lobs3= obj.lobs3,
                estab = obj.estab,
                resusr = obj.resusr,
                ar2mazem = obj.ar2mazem,
                composto = obj.composto,
                compostoori = obj.compostoori,
                lrecno = obj.lrecno,
                lordem = obj.lordem,
                fmarcada = obj.fmarcada,
                producao = obj.producao,
                local = obj.local,
                morada = obj.morada,
                codpost = obj.codpost,
                nome = obj.nome,
                vendedor = obj.vendedor,
                vendnm = obj.vendnm,
                tabfor = obj.tabfor,
                tabela1 = obj.tabela1,
                descli = obj.descli,
                reff = obj.reff,
                lote = obj.lote,
                ivaincl = obj.ivaincl,
                cor = obj.cor,
                tam = obj.tam,
                segmento = obj.segmento,
                bofref = obj.bofref,
                bifref = obj.bifref,
                grau = obj.grau,
                partes = obj.partes,
                partes2 = obj.partes2,
                altura = obj.altura,
                largura = obj.largura,
                espessura = obj.espessura,
                biserie = obj.biserie,
                infref = obj.infref,
                lifref = obj.lifref,
                uni2qtt = obj.uni2qtt,
                epu = obj.epu,
                edebito = obj.edebito,
                eprorc = obj.eprorc,
                epcusto = obj.epcusto,
                ttdeb = obj.ttdeb,
                ettdeb = obj.ettdeb,
                ttmoeda = obj.ttmoeda,
                adoc = obj.adoc,
                binum1 = obj.binum1,
                binum2 = obj.binum2,
                codigo = obj.codigo,
                cpoc = obj.cpoc,
                stns = obj.stns,
                obistamp = obj.obistamp,
                oobistamp = obj.oobistamp,
                usr1 = obj.usr1,
                usr2 = obj.usr2,
                usr3 = obj.usr3,
                usr4 = obj.usr4,
                usr5 = obj.usr5,
                usr6 = obj.usr6,
                usalote = obj.usalote,
                texteis = obj.texteis,
                unidade = obj.unidade,
                unidad2 = obj.unidad2,
                oftstamp = obj.oftstamp,
                ofostamp = obj.ofostamp,
                promo = obj.promo,
                epromo = obj.epromo,
                familia = obj.familia,
                sattotal = obj.sattotal,
                noserie = obj.noserie,
                slvu = obj.slvu,
                eslvu = obj.eslvu,
                sltt = obj.sltt,
                esltt = obj.esltt,
                slvumoeda = obj.slvumoeda,
                slttmoeda = obj.slttmoeda,
                ncmassa = obj.ncmassa,
                ncunsup = obj.ncunsup,
                ncvest = obj.ncvest,
                encvest = obj.encvest,
                nccod = obj.nccod,
                ncinteg = obj.ncinteg,
                classif = obj.classif,
                classifc = obj.classifc,
                posic = obj.posic,
                desconto = obj.desconto,
                desc2 = obj.desc2,
                desc3 = obj.desc3,
                desc4 = obj.desc4,
                desc5 = obj.desc5,
                desc6 = obj.desc6,
                series = obj.series,
                series2 = obj.series2,
                ccusto = obj.ccusto,
                ncusto = obj.ncusto,
                num1 = obj.num1,
                fechabo = obj.fechabo,
                oobostamp = obj.oobostamp,
                ltab1 = obj.ltab1,
                ltab2 = obj.ltab2,
                ltab3 = obj.ltab3,
                ltab4 = obj.ltab4,
                ltab5 = obj.ltab5,
                fami = obj.fami,
                pctfami = obj.pctfami,
                adjudicada = obj.adjudicada,
                tieca = obj.tieca,
                etieca = obj.etieca,
                mtieca = obj.mtieca,
                volume = obj.volume,
                iecasug = obj.iecasug,
                iecagrad = obj.iecagrad,
                iecacodisen = obj.iecacodisen,
                peso = obj.peso,
                pbruto= obj.pbruto,
                codfiscal = obj.codfiscal,
                dgeral = obj.dgeral,
                temoci = obj.temoci,
                temomi = obj.temomi,
                temsubemp = obj.temsubemp,
                encargo = obj.encargo,
                eencargo = obj.eencargo,
                custoind = obj.custoind,
                ecustoind = obj.ecustoind,
                tiposemp = obj.tiposemp,
                pvok = obj.pvok,
                boclose = obj.boclose,
                dtclose = obj.dtclose,
                quarto = obj.quarto,
                emconf = obj.emconf,
                efornecedor = obj.efornecedor,
                efornec = obj.efornec,
                efornestab = obj.efornestab,
                cativo = obj.cativo,
                optstamp = obj.optstamp,
                oristamp = obj.oristamp,
                temeco = obj.temeco,
                ecoval = obj.ecoval,
                eecoval = obj.eecoval,
                tecoval = obj.tecoval,
                etecoval = obj.etecoval,
                ecoval2 = obj.ecoval2,
                eecoval2 = obj.eecoval2,
                tecoval2 = obj.tecoval2,
                etecoval2 = obj.etecoval2,
                econotcalc = obj.econotcalc,
                bostamp = obj.bostamp,
                ousrinis = obj.ousrinis,
                ousrdata = obj.ousrdata,
                ousrhora = obj.ousrhora,
                usrinis = obj.usrinis,
                usrdata = obj.usrdata,
                usrhora = obj.usrhora,
                marcada = obj.marcada,
                mntencargos = obj.mntencargos,
                debitoori = obj.debitoori,
                edebitoori = obj.edebitoori,
                trocaequi = obj.trocaequi,
                tpromo = obj.tpromo,
                valdesc = obj.valdesc,
                evaldesc = obj.evaldesc,
                u_matric = obj.u_matric,
                
               

            };


            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("http://localhost:49668/");
                    client.DefaultRequestHeaders.AcceptCharset.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = client.PostAsJsonAsync("api/bis", obj).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Success");
                    }


                }
                catch (Exception)
                {
                    MessageBox.Show("Error");

                }

            }
        }

        private async void PostBi()
        {
            var URI = "http://localhost:49668/api/bis";

            var uid = Regex.Replace(Convert.ToBase64String(Guid.NewGuid().ToByteArray()), "[/+=]", "");

            var biex = new BiExtra
            {
                bistamp = uid,
                nmdos = "qq",
                obrano = 5,
                @ref = "n",
                design = "n",
                serie = "n",
                nmdoc = "n",
                forref = "n",
                lobs = "n",
                obranome = "n",
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
                nome = "n",
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
                quarto = "n",
                efornecedor = "n",
                optstamp = "n",
                oristamp = "n",
                bostamp = "n",
                ousrinis = "n",
                ousrhora = DateTime.Now.ToString("HH:mm:ss"),
                usrinis = "n",
                usrhora = DateTime.Now.ToString("HH:mm:ss"),
                u_matric = "n"
            };


                   string username = "";
                    string password = "";
                    String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));

                    string responseMessage = string.Empty;



                         string baseAddress = "http://localhost:49668/";
                         // string apiPath = "api/boes";
                         string apiPath = "api/bis";
                         var request = (HttpWebRequest)WebRequest.Create(baseAddress + apiPath);

                         request.Method = "POST";
                         // request.ContentType = "application/x-www-form-urlencoded";
                         //request.ContentType = "application/json";
                         request.ContentType = "application/x-www-form-urlencoded";
                 

                          request.Headers.Add("Authorization", "Basic " + encoded);
                         //request.ProtocolVersion = HttpVersion.Version10;


                         // request.UseDefaultCredentials = true;
                         // request.Credentials = new NetworkCredential("", "", "");


                         //  string jsonOrder = JsonConvert.SerializeObject(bo);
                         string jsonOrder = JsonConvert.SerializeObject(biex);
                         var data = Encoding.UTF8.GetBytes(jsonOrder);
                         request.ContentLength = data.Length;
                        // string message = request.Method + baseAddress + apiPath + request.ContentType;
                         string message =  baseAddress + apiPath ;

                         //post data

                         using (var stream = request.GetRequestStream())
                         {
                             stream.Write(data, 0, data.Length);

                         }


                    //get response
                    WebResponse response = request.GetResponse();
                         // Get the stream containing content returned by the server.
                         Stream dataStream = response.GetResponseStream();
                         // Read the content.
                         if (((HttpWebResponse)response).StatusDescription == "OK")
                         {
                             using (var stream = response.GetResponseStream())
                             {
                                 StreamReader reader = new StreamReader(stream);
                                 responseMessage = reader.ReadToEnd();

                             }
                         }
                         


         /*   ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, errors) => true; string result = "";
            string json = "{\"bistamp\":\"Et69BHWC80CITehTF18RTQ\",\"nmdos\":\"q\",\"obrano\":5.0,\"ref\":\"n\",\"design \":\"n\",\"qtt\":0.0,\"serie\":\"n\",\"nmdoc\":\"n\",\"forref\":\"n\",\"lobs\":\"n\",\"obranome\":\"n\",\"maquina\":\"n\",\"marca\":\"n\",\"zona\":\"n\",\"litem\":\"n\",\"lobs2\":\"n\",\"litem2\":\"n\",\"lobs3\":\"n\",\"lrecno\":\"n\",\"local\":\"n\",\"morada\":\"n\",\"codpost\":\"n\",\"nome\":\"n\",\"vendnm\":\"n\",\"tabela1\":\"n\",\"reff\":\"n\",\"lote\":\"n\",\"cor\":\"n\",\"tam\":\"n\",\"segmento\":\"n\",\"bofref\":\"n\",\"bifref\":\"n\",\"biserie\":\"n\",\"adoc\":\"n\",\"codigo\":\"n\",\"obistamp\":\"n\",\"oobistamp\":\"n\",\"usr1\":\"n\",\"usr2\":\"n\",\"usr3\":\"n\",\"usr4\":\"n\",\"usr5\":\"n\",\"usr6\":\"n\",\"usalote\":false,\"texteis\":false,\"unidade\":\"n\",\"unidad2\":\"n\",\"oftstamp\":\"n\",\"ofostamp\":\"n\",\"familia\":\"n\",\"nccod\":\"n\",\"ncinteg\":\"n\",\"classifc\":\"n\",\"posic\":\"n\",\"series\":\"n\",\"series2\":\"n\",\"ccusto\":\"n\",\"ncusto\":\"n\",\"oobostamp\":\"n\",\"ltab1\":\"n\",\"ltab2\":\"n\",\"ltab3\":\"n\",\"ltab4\":\"n\",\"ltab5\":\"n\",\"fami\":\"n\",\"iecacodisen\":\"n\",\"codfiscal\":\"n\",\"dgeral\":\"n\",\"tiposemp\":\"n\",\"quarto\":\"n\",\"efornecedor\":\"n\",\"optstamp\":\"n\",\"oristamp\":\"n\",\"bostamp\":\"n\",\"ousrinis\":\"n\",\"ousrhora\":\"11:37:59\",\"usrinis\":\"n\",\"usrhora\":\"11:37:59\",\"u_matric \":\"n\"}"

;

            using (var client = new WebClient())
            {
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                client.Encoding = Encoding.UTF8;
                result = client.UploadString("http://localhost:49668/api/bis/", "POST", json);


            }*/




                /*   using (var client = new HttpClient())
                   {
                       var serializedProduto = JsonConvert.SerializeObject(biex);
                       var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
                       var result = await client.PostAsync(URI, content);
                   }*/

      

        }

        private void button14_Click(object sender, EventArgs e)
        {
            PostBi();
        }

        private void button15_Click(object sender, EventArgs e)
        {



            var uid = Regex.Replace(Convert.ToBase64String(Guid.NewGuid().ToByteArray()), "[/+=]", "");

            string URL = "http://localhost:49668/api/bis";
            WebClient webClient = new WebClient();

            System.Collections.Specialized.NameValueCollection formData = new System.Collections.Specialized.NameValueCollection();
            formData["bistamp"] = uid;
            formData["nmdos"] = "mypas";
            formData["ref"] = "VV";
            formData["design"] = "VV";
            formData["serie"] = "VV";
            formData["nmdoc"] = "VV";
            formData["forref"] = "VV";
            formData["lobs"] = "VV";
            formData["obranome"] = "VV";
            formData["maquina"] = "VV";
            formData["marca"] = "VV";
            formData["zona"] = "VV";
            formData["litem"] = "vv";
            formData["lobs2"] = "vv";
            formData["litem2"] = "vv";
            formData["lobs3"] = "vv";
            formData["lrecno"] = "vv";
            formData["local"] = "vv";
            formData["morada"] = "vv";
            formData["codpost"] = "vv";
            formData["nome"] = "vv";
            formData["vendnm"] = "vv";
            formData["tabela1"] = "vv";
            formData["reff"] = "vv";
            formData["lote"] = "vv";
            formData["cor"] = "vv";
            formData["tam"] = "vv";
            formData["segmento"] = "vv";
            formData["bofref"] = "vv";
            formData["bifref"] = "vv";
            formData["biserie"] = "vv";
            formData["adoc"] = "vv";
            formData["codigo"] = "vv";
            formData["obistamp"] = "vv";
            formData["oobistamp"] = "vv";
            formData["usr1"] = "vv";
            formData["usr2"] = "vv";
            formData["usr3"] = "vv";
            formData["usr4"] = "vv";
            formData["usr5"] = "vv";
            formData["usr6"] = "vv";
            formData["unidade"] = "vv";
            formData["unidad2"] = "vv";
            formData["oftstamp"] = "vv";
            formData["ofostamp"] = "vv";
            formData["familia"] = "vv";
            formData["nccod"] = "vv";
            formData["ncinteg"] = "vv";
            formData["classifc"] = "vv";
            formData["posic"] = "vv";
            formData["series"] = "vv";
            formData["series2"] = "vv";
            formData["ccusto"] = "vv";
            formData["ncusto"] = "vv";
            formData["oobostamp"] = "vv";
            formData["ltab1"] = "vv";
            formData["ltab2"] = "vv";
            formData["ltab3"] = "vv";
            formData["ltab4"] = "vv";
            formData["ltab5"] = "vv";
            formData["fami"] = "vv";
            formData["iecacodisen"] = "vv";
            formData["codfiscal"] = "vv";
            formData["dgeral"] = "vv";
            formData["tiposemp"] = "vv";
            formData["quarto"] = "vv";
            formData["efornecedor"] = "vv";
            formData["optstamp"] = "vv";
            formData["oristamp"] = "vv";
            formData["bostamp"] = "vv";
            formData["ousrinis"] = "vv";
            formData["ousrhora"] = "vv";
            formData["usrinis"] = "vv";
            formData["usrhora"] = "vv";
            formData["u_matric"] = "vv";
            


            byte[] responseBytes = webClient.UploadValues(URL, "POST", formData);
            string Result = Encoding.UTF8.GetString(responseBytes);
        }
    }
}
