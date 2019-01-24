using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RequisicaoSServer.Views
{
    public interface IInterfaz2
    {
        ComboBox ComboBox3Form3 { get; set; }
        ComboBox ComboBox2Form3 { get; set; }
        ComboBox ComboBox1Form3 { get; set; }

        TextBox numDocForm3 { get; set; }
        DataGridView DataGridForm3 { get; set; }                  
    }
}
