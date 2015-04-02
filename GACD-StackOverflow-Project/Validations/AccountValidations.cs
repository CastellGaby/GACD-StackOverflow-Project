using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GACD_StackOverflow_Project.Validations
{
    public class AccountValidations
    {
        /*La contraseña debe de incluir al menos una vocal, una letra en mayúscula, un número, no debe de contener letras seguidas como (ee, aa, cc), solo debe contener letras y numeros
        La contraseña y confirmar contraseña debe tener minimo 8 caracteres y maximo 16 caracteres
        La contraseña y confirmar contraseña deben de ser iguales*/

        public static bool ConfirmPassword(string password, string confirm)
        {
            return false;
        }
    }
}