using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba.Controllers
{
    public class PrincipalController
    {
        String numStringMAX_OBRANO;

        public PrincipalController()
        {

        }

        public void llenar(DataGridView dgv)
        {
            Conexion con = new Conexion();
            con.llennar(dgv);
        }


        //Get, numero MAx Obrano
        public String GetMaxObrano()
        {
            Conexion con = new Conexion();
            var numString = con.MaxObrano();

            if (String.IsNullOrEmpty(numString))
            {
                numStringMAX_OBRANO = "1";

                return numStringMAX_OBRANO;
            }
            else
            {
                var num = Int32.Parse(numString);
                var num1 = ++num;
                var maxString = num1.ToString();
                numStringMAX_OBRANO = maxString;


                //numStringMAX_OBRANO = numString;

                return numStringMAX_OBRANO;
            }     
        }

        // Enviar 
        public void Process()
        {
            Conexion con = new Conexion();
            con.InsertBDbi();
        }


        // Load Combo Entidades
        public void LoadEntidades(ComboBox combo)
        {
            Conexion con = new Conexion();
            con.GetEntidades(combo);
        }


        // Load Combo Categorias
        public void LoadCategorias(ComboBox combo)
        {
            Conexion con = new Conexion();
            con.GetCategorias(combo);
        }



        // Load Combo RefDesign
        public void LoadRefDesign(ComboBox combo, string valor)
        {
            Conexion con = new Conexion();
            con.GetRefDesign2(combo,valor);
        }


        // Load Datagridview
        public void LoadRefDesignDatagrid(DataGridView datagrid, string valor)
        {
            Conexion con = new Conexion();
            con.InsertDatagridView(datagrid, valor);
        }
    }
}
