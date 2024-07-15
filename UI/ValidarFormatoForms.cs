using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PlantAndHealth.Validaciones
{
    internal static class ValidarFormatoForms
    {

        private static Regex regexTexts = new Regex(@"^[a-zA-Z\s]+$");
        private static Regex regexNumbers = new Regex(@"^[0-9]+$");

        public static bool validarTexts(params TextBox[] textos)
            {
            if (!VerificarCamposNoVacios(textos))
            {
                foreach (var texto in textos)
                {
                    if (!(regexTexts.IsMatch(texto.Text)))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool validarNumbers(params TextBox[] numeros)
        {
            if (!VerificarCamposNoVacios(numeros))
            {
                foreach (var numero in numeros)
                {
                    if (!(regexNumbers.IsMatch(numero.Text)))
                    {
                        return false;
                    }
                }
            }

            return true;
        }



        private static bool VerificarCamposNoVacios(params TextBox[] textos)
        {
            foreach (var texto in textos)
            {
                if (!(string.IsNullOrEmpty(texto.Text)))
                {
                    return false;
                }
            }
            return true;
        }


        private static bool validarComboVacio(params ComboBox[] combos)
        {
            foreach (var combo in combos)
            {
                if (combo.SelectedItem == null || combo.SelectedIndex == -1)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool validarComboBox(params ComboBox[] combos)
        {
            if (validarComboVacio(combos)) 
            {
                return false; 
            }

            foreach (var combo in combos)
            {
                if (string.IsNullOrEmpty(combo.Text))
                {
                    return false; 
                }
            }
            return true;
        }
    }
}
