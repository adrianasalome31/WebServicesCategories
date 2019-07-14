using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WebServicesCategories
{
    public class DataCategoriesModel
    {

        public DataSet getCategories()
        {
            //EL DataSet REPRESENTA UNA MEMORIA CACHÉ DE DATOS EN MEMORIA 
            DataSet dataTable = new DataSet();

            //A TRAVEZ DE LA CADENA DE CONEXION DEL WEBCONFIG Y LA OBTENEMOS  
            //CON EL CONFIGURATIONMANAGER 
            using (SqlConnection con = new SqlConnection(
                ConfigurationManager.ConnectionStrings["connectionLocal"]
                .ConnectionString))
            {
                //SE ABRE LA CONEXION 
                con.Open();

                //SE UTILIZA PARA LLENAR UN DATASET CON LOS ELEMENTOS NECESARIOS  
                //COMO UNA CONEXION DE BASE DE DATOS 
                using (SqlDataAdapter sqlAdapter = new SqlDataAdapter(
                    "SELECT * FROM Categories", con))
                {
                    //SE LLENA EL DATASET CON LOS DATOS OBTENIDOS EN EL SQLADAPTER 
                    sqlAdapter.Fill(dataTable);
                }
            }
            //REGRESAMOS LOS DATOS COMO DATOS EN MEMORIA 
            return dataTable;
        }
    }
}