using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RequisicaoSServer.Models
{
   public class DbConsultation
   {
        List<ag> Items;
        List<st> Items2;
        List<st> Items3;
        List<st> Items4;
        st conta;
       

        String numString;

        // Get All, List for ComboBox Table Ag
        public List<ag> GetAllComboBox()
        {
            Items = new List<ag>();
            using (DBConnect db = new DBConnect())
            {

                Items = db.ag.ToList<ag>();

            }

            return Items;
        }

        // Get All, List for ComboBox Table st, usr3
        public List<st> GetAllComboBoxSt()
        {
            Items3 = new List<st>();
            using (DBConnect db = new DBConnect())
            {

     
                Items3 = (from  c in db.st
                       where c.usr3.StartsWith("MP")
                            || c.usr3.StartsWith("Ferragens")
                          select  c).ToList();
            }

            return Items3;
        }


        // Search usr3 in Table st
        public List<st> GetIdSt(String y)
        {
            var valueS = y;
            Items4 = new List<st>();

            using (DBConnect db = new DBConnect())
            {

                Items4 = (from c in db.st
                          where c.usr3 == valueS
                          select c).ToList();


            }

            return Items4;
        }



        // GetMax Obrano, table Bo
        public string GetMax()
        {
            string Year = DateTime.Now.Year.ToString();
            var yearDeci = Decimal.Parse(Year);
          

            try
            {
                using (DBConnect db = new DBConnect())
                {

                    var rept_max = (from c in db.bo
                                    where c.boano == yearDeci && c.ndos == 35
                                    select c).Max(c => c.obrano);

                    numString = rept_max.ToString();
                   
                }
            }
            catch
            {
                numString = "true";
               // MessageBox.Show(numString);
            }
           

            return numString;
        }

        // Search value in database for combox dataGridview
        public List<st> GetComboBoxDataGrid()
        {
            Items2 = new List<st>();
            using (DBConnect db = new DBConnect())
            {

                Items2 = db.st.ToList<st>();

            }

            return Items2;
        }


        // Search Design in database for load Ref in (Cell 1, Colummns1) datagridView, Form1
        public st GetId(String y)
        {
            var valueS = y;

            using (DBConnect db = new DBConnect())
            {
                try
                {
                    conta = db.st.First(p => p.design == valueS);
                }
                catch
                {
                   // MessageBox.Show("Valores vazios vvvvv");
                }
                   
                          
            }

            return conta;
        }

        // Search Ref in database for load Design in datagridview Form3, Ref, design 
        public st GetIdRef(String y)
        {
            var valueS = y;

            using (DBConnect db = new DBConnect())
            {

                conta = db.st.First(p => p._ref == valueS);


            }

            return conta;
        }

        // Search Ref in database for load in datagridview Form3, Ref, design
        public st GetIdDesign(String y)
        {
            var valueS = y;

            using (DBConnect db = new DBConnect())
            {

                conta = db.st.First(p => p.design == valueS);


            }

            return conta;
        }

        // Insert obj en rown in database, table Bi
        public void Add(bi model, string n)
        {

            try
            {
                using (DBConnect db = new DBConnect())
                {

                    db.bi.Add(model);
                    db.SaveChanges();


                   // MessageBox.Show("Successfully" + "," + "Line" + " " + n);

                }

            }
            catch
            {
                //MessageBox.Show("Error" + "," + "Line" + " " + n);
            }

        }

        // Insert obj en rown in database, table Bo
        public void Add2(bo model)
        {

                using (DBConnect db = new DBConnect())
                {

                    db.bo.Add(model);
                    db.SaveChanges();


                   // MessageBox.Show("Successfully head");

                }      

        }
    }

}

