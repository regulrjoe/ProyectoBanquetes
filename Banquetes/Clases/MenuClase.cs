﻿using Banquetes.Clases;
using Nivel_de_acceso.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banquetes.Class
{
    public  class MenuClase
    {
        public class Entrada
        {
            public int idEntrada { set; get; }
            public string nombre { set; get; }
            public int precioUnit { set; get; }
            public int tipo { set; get; }
            public string descripcion { set; get; }
            public string imagen { set; get; }
            public List<string> ingredientes { set; get; }

        }

        private static List<Entrada> lstEntradas = new List<Entrada>();
        private static List<MenuClase> lstMenuCliente = new List<MenuClase>();
        public static List<MenuClase> llamarMenuCliente()
        {
            return lstMenuCliente;
        }
        public static List<Entrada> llamarEntradas()
        {
            return lstEntradas;
        }

        #region Variables
        private int idEntrada;
        public int IdEntrada
        {
            get { return idEntrada; }
            set { idEntrada = value; }
        }

        private int porciones;
        public int Porciones
        {
            get { return porciones; }
            set { porciones = value; }
        }
        #endregion 

        #region Métodos
        /*Método para Actualizar lista de menú en tiempo real*/
        public void ActualizarLista(int id) 
        {
            id += 1;
            bool exists = false;
            for (int i = 0; i < lstMenuCliente.Count; i++)
            {
                if (lstMenuCliente[i].idEntrada == id)
                {
                    lstMenuCliente.RemoveAt(i);
                    exists = true;
                }
            }
            if (!exists)
        {

                MenuClase entrada = new MenuClase();
                entrada.idEntrada = id;
                entrada.Porciones = (int)Menu.arrControles[id-1].num.Value;
                lstMenuCliente.Add(entrada);
            }
        }

        /*Obtener menú del cliente de la base de datos*/
        public void ObtenerMenuCliente(int folio) 
        {
            string tabla = "Menu";
            Estructura objElements = new Estructura();
            objElements.Sentencia = "proc_getMenu";
            objElements.Parametros = new SqlParameter[]{
                new SqlParameter("id", SqlDbType.Int)
            };
            objElements.Valores = new List<object>(){ folio };
            Operaciones objOperaciones = new Operaciones();
            objOperaciones.Elemento = objElements;
            DataTable data = objOperaciones.ObtenerDataTable(tabla);
            lstMenuCliente.Clear();
            if (data.Rows.Count > 0)
            {
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    MenuClase entrada = new MenuClase();
                    entrada.idEntrada = Convert.ToInt32(data.Rows[i]["idEntrada"]);
                    entrada.porciones = Convert.ToInt32(data.Rows[i]["porciones"]);
                    lstMenuCliente.Add(entrada);
                }
            }
        }
        
        /*Método para insertar o actualizar menú a la base de datos*/
        public void GuardarMenu() 
        {
            Estructura objElementos = new Estructura();
            Operaciones objOperaciones = new Operaciones();

            if (!ReciboClase.nuevo)
            {
                objElementos.Sentencia = "proc_deleteMenu";
                objElementos.Parametros = new SqlParameter[]{
                    new SqlParameter("folio", SqlDbType.Int)
                };
                objElementos.Valores = new List<object>() { EventoClase.Evento.FolioEvento };
                objOperaciones.Elemento = objElementos;
                objOperaciones.AgregarInfo();
            }

            for (int i = 0; i < lstMenuCliente.Count; i++)
            {
                objElementos.Sentencia = "proc_setMenu";
                objElementos.Parametros = new SqlParameter[]{
                new SqlParameter("folio", SqlDbType.Int),
                new SqlParameter("identrada", SqlDbType.Int),
                new SqlParameter("porciones", SqlDbType.Int)
                };
                objElementos.Valores = new List<object>() { EventoClase.Evento.FolioEvento, lstMenuCliente[i].idEntrada, lstMenuCliente[i].porciones};

                objOperaciones.Elemento = objElementos;
                objOperaciones.AgregarInfo();
            }
        }
        
        /*Método para Calcular el Precio de los elementos del menú*/
        public int CalcularPrecioMenu() 
        {
            int total = 0;
            for (int i = 0; i < lstMenuCliente.Count; i++)
                for (int j = 0; j < lstEntradas.Count; j++)
                    if (lstMenuCliente[i].idEntrada == lstEntradas[j].idEntrada)
                        total += lstMenuCliente[i].Porciones * lstEntradas[j].precioUnit;
            return total;
        }
        
        /*Método para obtener todo el menú de la base de datos*/
        public void ObtenerMenuCompleto() 
        {
            string tabla = "Entradas";
            Estructura objElements = new Estructura();
            objElements.Sentencia = "proc_getEntradas";
            objElements.Parametros = new SqlParameter[] { };
            objElements.Valores = new List<object>() { };
            Operaciones objOperaciones = new Operaciones();
            objOperaciones.Elemento = objElements;
            DataTable data = objOperaciones.ObtenerDataTable(tabla);
            lstEntradas.Clear();

            if (data.Rows.Count > 0)
            {
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    Entrada ent = new Entrada();
                    ent.idEntrada = Convert.ToInt32(data.Rows[i]["idEntrada"]);
                    ent.nombre = data.Rows[i]["nombre"].ToString();
                    ent.precioUnit = Convert.ToInt32(data.Rows[i]["precioUnit"]);
                    ent.tipo = Convert.ToInt32(data.Rows[i]["tipo"]);
                    ent.descripcion = data.Rows[i]["descripcion"].ToString();
                    ent.imagen = data.Rows[i]["imagen"].ToString();
                    lstEntradas.Add(ent);
                }
            }

            for (int i = 0; i < lstEntradas.Count; i++)
            {
                tabla = "Ingredientes";
                objElements.Sentencia = "proc_getIngredientes";
                objElements.Parametros = new SqlParameter[] {
                    new SqlParameter("id", SqlDbType.Int)
                };
                objElements.Valores = new List<object>() { i + 1 };
                objOperaciones.Elemento = objElements;
                data = objOperaciones.ObtenerDataTable(tabla);
                lstEntradas[i].ingredientes = new List<string>(); 

                for (int j = 0; j < data.Rows.Count; j++)
                {
                    lstEntradas[i].ingredientes.Add(data.Rows[j]["nombre"].ToString());
                }
            }
        }

        public void BorrarMenucliente()
        {
            lstMenuCliente.Clear();
        }
        #endregion
    }
}