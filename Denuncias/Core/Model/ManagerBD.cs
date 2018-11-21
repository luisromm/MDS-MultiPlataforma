using System;

//Librerias
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

public class ManagerBD
{
    public string strCadenaConexion
    { get; set; }

    public ManagerBD() { }

    /// <summary>
    /// Autor: MHR
    /// Constructor que inicializa la cadena de Conexión
    /// </summary>
    /// <param name="strNombreConexion"></param>
    public ManagerBD(string strNombreConexion)
    {
        strCadenaConexion = ConfigurationManager.ConnectionStrings[strNombreConexion].ConnectionString;
    }
}
