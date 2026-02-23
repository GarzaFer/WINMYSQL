using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;


namespace WINMYSQL.CLASES
{
    internal class Datos
    {
        String cadenaConexion = "server=localhost; user=luis;pwd=joseluis";

        MySqlConnection conexion;

        private void Conectar()
        {
            try
            {
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Desconectar()
        {
            try
            {
                if (conexion != null)
                {
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }








        }
}
