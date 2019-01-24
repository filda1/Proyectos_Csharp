using Newtonsoft.Json;
using Requisicao.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Requisicao.Models
{
    public class ApiServices
    {
        #region Var
        List<MyRequisicao> Items;
        IPedido requisicaoView;
        #endregion

        #region Methods

        // Get All, get the list of records of the url
        public async void GetAll(IPedido view)
        {
            requisicaoView = view;

            String URI = "  http://localhost:49668/api/ags/GetNome";
            //var URI = "http://localhost:50241/api/ags/GetNome";

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URI))
                {
                 try
                  {

                  
                     if (response.IsSuccessStatusCode)
                     {
                        var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                        var Lista = JsonConvert.DeserializeObject<Models.MyRequisicao[]>(ProdutoJsonString).ToList();
                    

                        foreach (var item in Lista)
                        {
                     
                          requisicaoView.ComboBoxEntidades.Items.Add(item.title);
                         
                        }

                     }

                    }
                    catch(Exception)
                    {
                       
                    }
                }
            }
        }


        //GetId , get registration table st 
        public St GetId(String i)
        {
         
            String uri = "http://localhost:49668/api/sts/" + i;

            try
            {

                var cliente = new WebClient();
                var text = cliente.DownloadString(uri);

                St result = JsonConvert.DeserializeObject<St>(text);
                return result;
            }
            catch
            {
                return null;
            }
        
        }
        #endregion
    }
}
