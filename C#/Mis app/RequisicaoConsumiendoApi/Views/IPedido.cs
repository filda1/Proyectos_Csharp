using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Requisicao.Models;

namespace Requisicao.Views
{
    public interface IPedido
    {     
        ComboBox ComboBoxEntidades{ get; set; }
        DataGridView DataGridText { get; set; }
    }
}
