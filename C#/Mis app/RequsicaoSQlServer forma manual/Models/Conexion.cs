using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace Prueba.Models
{
   public class Conexion
    {
        String connectionString = "data source=192.168.100.4;initial catalog=e_INDUSTRIAL;integrated security=True";

        String numString;
        public string Year = DateTime.Now.Year.ToString();


        public void llennar(DataGridView dgv)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            String query = "SELECT *FROM ag";

            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(query,connection);

            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet,"ag");

            dgv.DataSource = dataSet.Tables["ag"];
            connection.Close();

        }


        // MAx Obrano da Base de datos
        public String MaxObrano()
        {
            //string Year = DateTime.Now.Year.ToString();
            //var yearDeci = Decimal.Parse(Year);
            Decimal year = DateTime.Now.Year;
            

            SqlConnection connection = new SqlConnection(connectionString);
           
            //String query = "SELECT MAX(obrano ) As  Maxid FROM bo WHERE boano = 2019 and ndos = 66";
            String query = "SELECT MAX(obrano) As  Maxid FROM bo WHERE boano =" + year + " and ndos = 35";

  
            connection.Open();

            SqlCommand cmd = new SqlCommand(query,connection);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                //txb.Text = (dr["Maxid"].ToString());
                numString = (dr["Maxid"].ToString());

                return numString;

            }

            return numString;

            connection.Close();
         
        }



        // Obter nomes da tabela ag (Entidades)
        public void GetEntidades(ComboBox combox)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            String query = "SELECT nome FROM ag";

            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                combox.Items.Add(DR[0]);

            }
            connection.Close();
        }


        // Obter usr3 (categorias) de tabela st
        public void GetCategorias(ComboBox combox)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            String query = "SELECT  DISTINCT usr3 FROM st WHERE usr3 LIKE 'MP%' OR usr3 LIKE '%Ferragens%' ";

            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                combox.Items.Add(DR[0]);

            }
            connection.Close();
        }



        // Obter Ref y Design 
        public void GetRefDesign(ComboBox combox)
        {
            var value = "MP.Ferragens";
            SqlConnection connection = new SqlConnection(connectionString);
            String query = "SELECT  ref,design FROM st WHERE usr3 LIKE '%Ferragens%' ";

            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader DR = cmd.ExecuteReader();


            while (DR.Read())
            {
                combox.Items.Add(DR[0]);

            }
            connection.Close();
        }



        // Obter Ref y Design 
        public void GetRefDesign2(ComboBox combox, string x)
        {
            var value = x;
            SqlConnection connection = new SqlConnection(connectionString);
            String query = "SELECT  ref,design FROM st WHERE usr3 LIKE '%" + value + "%' ";

            connection.Open();

      
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                combox.Items.Add(dt.Rows[i]["ref"].ToString() + "       " + dt.Rows[i]["design"].ToString());
            }

            connection.Close();
        }




        // Load datagridview, Ref y design
        public void InsertDatagridView( DataGridView dgv, string valor )
        {

            SqlConnection connection = new SqlConnection(connectionString);       
            String query = "SELECT * FROM st WHERE ref LIKE '%" + valor + "%' ";


            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
              
               var refe = valor;
               var designe = (dr["design"].ToString());

                //MessageBox.Show(designe);

                ArrayList row = new ArrayList
                 {   refe, designe,  "0" };

                  dgv.Rows.Add(row.ToArray());

            }
            
            connection.Close();

        }


        public String boo()
        {
            //string Year = DateTime.Now.Year.ToString();
            //var yearDeci = Decimal.Parse(Year);
            Decimal year = DateTime.Now.Year;


            SqlConnection connection = new SqlConnection(connectionString);

            //String query = "SELECT MAX(obrano ) As  Maxid FROM bo WHERE boano = 2019 and ndos = 66";
            String query = "SELECT * FROM bo WHERE b";


            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                //txb.Text = (dr["Maxid"].ToString());
                numString = (dr["Maxid"].ToString());

                return numString;

            }

            return numString;

            connection.Close();

        }



        // Insert  en base de datos
        public void InsertBD ()
        {
            string base64Guid = Convert.ToBase64String(Guid.NewGuid().ToByteArray());
            //var valorEntidad = view2.ComboBox3Form3.SelectedItem.ToString();

            String valorEntidad = "nn";

            decimal voano = Decimal.Parse(Year);
            //decimal numeroDo = Decimal.Parse(nDocumento);
            decimal numeroDo = 22;

            //Requisição Interna
            string nmdos = "Vazio"; Decimal obrano = numeroDo; DateTime? dataobra = DateTime.Now; string nome = valorEntidad; string tipo = "Interno"; DateTime? datafinal = DateTime.Now; Decimal boano = voano; DateTime? dataopen = DateTime.Now; DateTime? datafecho = DateTime.Now;
           string vendnm = "nn"; string obranome = "n"; string tecnnm = "n"; string maquina = "n"; string marca = "n"; string serie = "n"; string zona = "n"; string obs = "n"; string trab1 = "n"; string trab2 = "n"; string trab3 = "n"; string trab4 = "n"; string trab5 = "n";
           Decimal ndos = 35; Decimal custo = 0; string moeda = "EURO"; string morada = "nnn"; string local = "n"; string codpost = "n"; DateTime? ultfact = DateTime.Now; string tabela1 = "n"; string ncont = "n"; string segmento = "n"; string userimpresso = "n"; string fref = "n";
           string ccusto = "n"; string ncusto = "n"; string cobranca = "n"; string memissao = "EURO"; string nome2 = "n"; string pastamp = "n"; string snstamp = "n"; string mastamp = "n"; string origem = "BO"; string site = "n"; string pnome = "n"; string cxstamp = "n"; 
           string cxusername = "n"; string ssstamp = "n"; string ssusername = "n"; string series = "n"; string series2 = "n"; string quarto = "n"; string tabela2 = "n"; string obstab2 = "n"; string iemail = "n"; string inome = "n"; string lang = "n"; string ean = "n";
           string iecacodisen = "n"; DateTime? dtclose = DateTime.Now; string tpstamp = "n"; string tpdesc = "n"; string statuspda = "n"; string ousrinis = "n"; DateTime? ousrdata = DateTime.Now; string ousrhora = "10:00:00"; string usrinis = "n"; DateTime? usrdata = DateTime.Now;
           string usrhora = "10:00:00"; string u_gpgasto = "n"; string u_matricul = "nn"; string u_motorist = "n"; string u_tpgasto = "n";

           

            SqlConnection connection = new SqlConnection(connectionString);
            /*String query = "INSERT INTO bo(bostamp,nmdos,obrano,dataobra,nome,tipo,datafinal,boano,dataopen,datafecho,vendnm,obranome,tecnnm,maquina,marca,serie,zona,obs,trab1,trab2,trab3,trab4,trab5," +
                "ndos,custo,moeda,morada,local,codpost,ultfact,tabela1,ncont,segmento,userimpresso,fref,ccusto,ncusto,cobranca,memissao," +
                "nome2,pastamp,snstamp,mastamp,origem,site,pnome,cxstamp,cxusername,ssstamp,ssusername,series,series2,quarto,tabela2,obstab2,iemail,inome,lang," +
                "ean,iecacodisen,dtclose,tpstamp,tpdesc,statuspda,ousrinis,ousrdata,ousrhora,usrinis,usrdata,usrhora,u_matricul)" +

                "VALUES('"+ base64Guid +"','"+ nmdos + "','" + obrano + "', '" + dataobra + "', '" + nome + "', '" + tipo + "' , '" + datafinal + "', '" + boano + "', '" + dataopen + "', '" + datafecho + "', '" + vendnm + "', '" + obranome + "', '" + tecnnm + "', '" + maquina + "', '" + marca + "',  '" + serie + "', '" + zona + "', '" + obs + "', '" + trab1 + "', '" + trab2 + "', '" + trab3 + "', '" + trab4 + "', '" + trab5 + "', '" + ndos + "', '" + custo + "', '" + moeda + "', '" + morada + "', '" + local + "', '" + codpost + "', '" + ultfact + "', '" + tabela1 + "', '" + ncont + "', '" + segmento + "', '" + userimpresso + "', '" + fref + "', '" + ccusto + "', '" + ncusto + "', '" + cobranca + "', '" + memissao + "', '" + nome2 + "', '" + pastamp + "', '" + snstamp + "', '" + mastamp + "','" + origem + "', '" + site + "', '" + pnome + "', '" + cxstamp + "', '" + cxusername + "', '" + ssstamp + "', '" + ssusername + "', '" + series + "', '" + series2 + "', '" + quarto + "', '" + tabela2 + "', '" + obstab2 + "', '" + iemail + "', '" + inome + "', '" + lang + "', '" + ean + "', '" + iecacodisen + "', '" + dtclose + "',  '" + tpstamp + "', '" + tpdesc + "', '" + statuspda + "', '" + ousrinis + "', '" + ousrdata + "',  '" + ousrhora + "', '" + usrinis + "','" + usrdata + "', '" + usrhora + "', '" + u_matricul + "' )";*/

            string id = "00B18E7FCFCFFFD6101631229";
            decimal voano1 = 2039;

            String query = "INSERT INTO bo(bostamp,nmdos,obrano,boano,ndos)" +

           "VALUES('" + base64Guid + "','" + nmdos + "','" + obrano + "' , '" + voano1 + "', + '" + ndos + "')";



            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Exito");

            connection.Close();


        }



        // Insert  en base de datos
        public void InsertBDbi()
        {
            string base64Guid = Convert.ToBase64String(Guid.NewGuid().ToByteArray());
            //var valorEntidad = view2.ComboBox3Form3.SelectedItem.ToString();

            String valorEntidad = "nn";

            decimal voano = Decimal.Parse(Year);
            //decimal numeroDo = Decimal.Parse(nDocumento);
            decimal numeroDo = 22;

            //Requisição Interna
            string nmdos = "Vazio"; Decimal obrano = numeroDo; DateTime? dataobra = DateTime.Now; string nome = valorEntidad; string tipo = "Interno"; DateTime? datafinal = DateTime.Now; Decimal boano = voano; DateTime? dataopen = DateTime.Now; DateTime? datafecho = DateTime.Now;
            string vendnm = "nn"; string obranome = "n"; string tecnnm = "n"; string maquina = "n"; string marca = "n"; string serie = "n"; string zona = "n"; string obs = "n"; string trab1 = "n"; string trab2 = "n"; string trab3 = "n"; string trab4 = "n"; string trab5 = "n";
            Decimal ndos = 35; Decimal custo = 0; string moeda = "EURO"; string morada = "nnn"; string local = "n"; string codpost = "n"; DateTime? ultfact = DateTime.Now; string tabela1 = "n"; string ncont = "n"; string segmento = "n"; string userimpresso = "n"; string fref = "n";
            string ccusto = "n"; string ncusto = "n"; string cobranca = "n"; string memissao = "EURO"; string nome2 = "n"; string pastamp = "n"; string snstamp = "n"; string mastamp = "n"; string origem = "BO"; string site = "n"; string pnome = "n"; string cxstamp = "n";
            string cxusername = "n"; string ssstamp = "n"; string ssusername = "n"; string series = "n"; string series2 = "n"; string quarto = "n"; string tabela2 = "n"; string obstab2 = "n"; string iemail = "n"; string inome = "n"; string lang = "n"; string ean = "n";
            string iecacodisen = "n"; DateTime? dtclose = DateTime.Now; string tpstamp = "n"; string tpdesc = "n"; string statuspda = "n"; string ousrinis = "n"; DateTime? ousrdata = DateTime.Now; string ousrhora = "10:00:00"; string usrinis = "n"; DateTime? usrdata = DateTime.Now;
            string usrhora = "10:00:00"; string u_gpgasto = "n"; string u_matricul = "nn"; string u_motorist = "n"; string u_tpgasto = "n";



            SqlConnection connection = new SqlConnection(connectionString);
            /*String query = "INSERT INTO bo(bostamp,nmdos,obrano,dataobra,nome,tipo,datafinal,boano,dataopen,datafecho,vendnm,obranome,tecnnm,maquina,marca,serie,zona,obs,trab1,trab2,trab3,trab4,trab5," +
                "ndos,custo,moeda,morada,local,codpost,ultfact,tabela1,ncont,segmento,userimpresso,fref,ccusto,ncusto,cobranca,memissao," +
                "nome2,pastamp,snstamp,mastamp,origem,site,pnome,cxstamp,cxusername,ssstamp,ssusername,series,series2,quarto,tabela2,obstab2,iemail,inome,lang," +
                "ean,iecacodisen,dtclose,tpstamp,tpdesc,statuspda,ousrinis,ousrdata,ousrhora,usrinis,usrdata,usrhora,u_matricul)" +

                "VALUES('"+ base64Guid +"','"+ nmdos + "','" + obrano + "', '" + dataobra + "', '" + nome + "', '" + tipo + "' , '" + datafinal + "', '" + boano + "', '" + dataopen + "', '" + datafecho + "', '" + vendnm + "', '" + obranome + "', '" + tecnnm + "', '" + maquina + "', '" + marca + "',  '" + serie + "', '" + zona + "', '" + obs + "', '" + trab1 + "', '" + trab2 + "', '" + trab3 + "', '" + trab4 + "', '" + trab5 + "', '" + ndos + "', '" + custo + "', '" + moeda + "', '" + morada + "', '" + local + "', '" + codpost + "', '" + ultfact + "', '" + tabela1 + "', '" + ncont + "', '" + segmento + "', '" + userimpresso + "', '" + fref + "', '" + ccusto + "', '" + ncusto + "', '" + cobranca + "', '" + memissao + "', '" + nome2 + "', '" + pastamp + "', '" + snstamp + "', '" + mastamp + "','" + origem + "', '" + site + "', '" + pnome + "', '" + cxstamp + "', '" + cxusername + "', '" + ssstamp + "', '" + ssusername + "', '" + series + "', '" + series2 + "', '" + quarto + "', '" + tabela2 + "', '" + obstab2 + "', '" + iemail + "', '" + inome + "', '" + lang + "', '" + ean + "', '" + iecacodisen + "', '" + dtclose + "',  '" + tpstamp + "', '" + tpdesc + "', '" + statuspda + "', '" + ousrinis + "', '" + ousrdata + "',  '" + ousrhora + "', '" + usrinis + "','" + usrdata + "', '" + usrhora + "', '" + u_matricul + "' )";*/

            string id = "00B18E7FCFCFFFD6101631229";
            decimal voano1 = 2039;

            string vazio = "Vazio";

            String query = "INSERT INTO bi(bistamp,nmdos)" +
          
           "VALUES('" + base64Guid + "', '" + vazio+ "')";



            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Exito");

            connection.Close();


        }

    }
}
