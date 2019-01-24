using Newtonsoft.Json;
using Requisicao.Models;
using Requisicao.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Requisicao.Presenters
{
    public class RequisicaoPresenter
    {
        #region Var
        private readonly ApiServices apiServices;
        IPedido requisicaoView;
        String indexComboBox;
        #endregion


        #region Constructor
        public RequisicaoPresenter(IPedido view)
        {
            requisicaoView = view;
            this.apiServices = new ApiServices();

        }

        #endregion



        #region Methods

        //Get apis (ApiServices.cs) send it to view
        public async Task Requisicao()
        {

            apiServices.GetAll(requisicaoView);

           


        }

        public void ItemSelect()
        {
            indexComboBox = requisicaoView.ComboBoxEntidades.SelectedItem.ToString();
            MessageBox.Show(indexComboBox);
        }


        // Find value in api and insert values into the corresponding columns of the datagridview record
        public void ValueRowns()
        {
            for (int i = 0; i < 1000; i++)
            {
               
                try
                {
                    var valueFila = requisicaoView.DataGridText.Rows[i].Cells[0].Value.ToString();
                    var item = apiServices.GetId(valueFila);

                   requisicaoView.DataGridText[1, i].Value = item.design;
                   //requisicaoView.DataGridText[2, i].Value = item.title;
                }

                catch (Exception)
                {

                }

            }
            #endregion
        }
    }
}
