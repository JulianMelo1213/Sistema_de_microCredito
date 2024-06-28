using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Gestion_de_MicroCreditos
{
    internal class Limpiar
    {
        public void Borrar(Control control)
        {
            foreach (var txt in control.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
                else if (txt is RadioButton)
                {
                    ((RadioButton)txt).Checked = false;
                }
            }
        }
    }
}
