using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuatri2021.Practica.Winforms
{
    public static class Validador
    {


        public static void Validacion(ComboBox _CBox)
        {
            if ((int)_CBox.SelectedValue == 0 || _CBox.SelectedValue == null)
                //HAY QUE CASTEARLO PORQUE SI NO LO TOMACOMO STRING
                throw new Exception($"Seleccione un valor en {_CBox.Name}");

        }
        public static void Validacion(ListBox _lBox)
        {
            if ((int)_lBox.SelectedValue == -1 || _lBox.SelectedValue is null)
                //HAY QUE CASTEARLO PORQUE SI NO LO TOMACOMO STRING
                throw new Exception($"Seleccione un valor de la lista");

        }

        public static void Validacion(TextBox _txt)
        {
            if (string.IsNullOrEmpty(_txt.Text))
                //HAY QUE CASTEARLO PORQUE SI NO LO TOMACOMO STRING
                throw new Exception($"Ingrese datos en {_txt.Name}");

        }

        public static void ValidacionInt(TextBox _txt)
        {
            if (string.IsNullOrEmpty(_txt.Text))
                throw new Exception($"Ingrese datos en {_txt.Name}");

            int numero;
            if (!int.TryParse(_txt.Text, out numero)) // que no permita ingresar letras y simbolos, solo numeros
                throw new Exception($"Ingrese Valores Numéricos en {_txt.Name}");
        }

        public static void ValidacionDouble(TextBox _txt)
        {
            if (string.IsNullOrEmpty(_txt.Text))
                throw new Exception($"Ingrese datos en {_txt.Name}");

            double numero;
            if (!double.TryParse(_txt.Text, out numero)) // que no permita ingresar letras y simbolos, solo numeros
                throw new Exception($"Ingrese Valores Numéricos en {_txt.Name}");
        }


    }
}
