using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ejerciciosexaulxd
{
    /// <summary>
    /// Descripción breve de ejercicios
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ejercicios : System.Web.Services.WebService
    {


        [WebMethod]
        public int Sumar(int num1, int num2)
        {
            return opsum.Sumar(num1, num2);
        }
        public static class opsum
        {
            public static int Sumar(int num1, int num2)
            {
                return num1 + num2;
            }
        }

        [WebMethod]
        public int restar(int num1, int num2)
        {
            return Opres.restar(num1, num2);
        }
        public static class Opres
        {
            public static int restar(int num1, int num2)
            {
                return num1 - num2;
            }
        }

        [WebMethod]

        public string mostrarnombre(string nombre)
        {
            return $"hola {nombre} bienvenido a soap :D";
        }

        public static class Nombre
        {
            public static string mostrarnombre(string nombre)
            {
                return nombre;
            }
        }
        [WebMethod]
        public string Calculadora(int num1, int num2, string operacion)
        {
            switch (operacion.ToLower())
            {
                case "sumar":
                    return $"Resultado de la suma: {num1 + num2}";
                case "restar":
                    return $"Resultado de la resta: {num1 - num2}";
                case "multiplicar":
                    return $"Resultado de la multiplicación: {num1 * num2}";
                case "dividir":
                    if (num2 != 0)
                    {
                        return $"Resultado de la división: {num1 / num2}";
                    }
                    else
                    {
                        return "No se puede dividir por cero.";
                    }
                default:
                    return "Operación no válida.";
            }
        }
        [WebMethod]
        public string PosicionEnMatriz(int fila, int columna, int filasMatriz, int columnasMatriz)
        {
            if (fila >= 0 && fila < filasMatriz && columna >= 0 && columna < columnasMatriz)
            {
                return $"La posición ({fila}, {columna}) está dentro de la matriz.";
            }
            else
            {
                return $"La posición ({fila}, {columna}) está fuera de la matriz.";
            }
        }

    }
}
