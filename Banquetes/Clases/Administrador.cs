﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banquetes.Class
{
   public class Administrador
   {
       #region Variables
       private string usuario;

       public string Usuario
       {
           get { return usuario; }
           set { usuario = value; }
       }
       private string password;

       public string Password
       {
           get { return password; }
           set { password = value; }
       }

       #endregion 

       #region Métodos
       //Método para verificar existencia de credencial
       public bool Verificar(string usr, string pwd) 
       {
           return true;
       }
       #endregion
   }
}
