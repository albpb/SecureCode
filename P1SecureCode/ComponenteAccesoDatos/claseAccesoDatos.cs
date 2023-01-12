using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponenteAccesoDatos
{
    /// <summary>
    /// Esta clase contiene diferentes metodos que sirven para el mantenimiento basico de una tabla (BBDD)
    /// </summary>
    public class claseAccesoDatos
    {
        /// <summary>
        /// Componentes creados de manera publica para poder acceder a ellos y modificar-los desde cualquier metodo.
        /// </summary>
        public SqlConnection conn;
        private string query;
        DataSet dts;

        /// <summary>
        /// Metodo para conectar-se a la base de datos atraves de la cadena de conexio que se encuentra en el archivo de app.config, que a mes en el mateix metode encripta l'arxiu app.config.
        /// </summary>
        private void Connectar()
        {
            Configuration conf = ConfigurationManager.OpenExeConfiguration("aplicacionPrincipal.exe");

            ConnectionStringsSection section = conf.GetSection("connectionStrings") as ConnectionStringsSection;

            if (!section.SectionInformation.IsProtected)
            {
                section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
            }

            conf.Save();

            string cnx = "";
            ConnectionStringSettings conf2 = ConfigurationManager.ConnectionStrings["aplicacionPrincipal.Properties.Settings.SecureCoreG4ConnectionString"];

            if (conf2 != null)
            {
                cnx = conf2.ConnectionString;
            }

            conn = new SqlConnection(cnx);
        }

        /// <summary>
        /// Metodo para traer la tabla que nos interese con todos sus datos de la base de datos y guardar-la en un DataSet
        /// </summary>
        /// <param name="taula">Nombre de la tabla que despues utilizaremos en la consulta sql</param>
        /// <returns>DataSet con los datos de la tabla de la base de datos seleccionada</returns>
        public DataSet PortarTaula(string taula)
        {
            dts = new DataSet();

            Connectar();

            SqlDataAdapter adapter;
            query = "SELECT * From " + taula;
            adapter = new SqlDataAdapter(query, conn);

            conn.Open();

            adapter.Fill(dts, taula);

            conn.Close();

            return dts;
        }

        /// <summary>
        /// Metodo para traer la tabla que nos interese atraves de una consulta personalizda y guardar-la en un DataSet
        /// </summary>
        /// <param name="Consulta">Consulta que enviamos a la base de datos</param>
        /// <returns>DataSet con los datos que se han pedido en la consulta</returns>
        public DataSet PortarPerConsulta(string Consulta)
        {      
            dts = new DataSet();

            Connectar();

            SqlDataAdapter adapter;
            query = Consulta;
            adapter = new SqlDataAdapter(query, conn);

            conn.Open();

            adapter.Fill(dts, "Tabla");

            conn.Close();

            return dts;
        }

        /// <summary>
        /// Metodo sobrescrito de PortarPerConsulta en el que ahora ademas de recibir la consulta recibe el nombre de la Tabla
        /// </summary>
        /// <param name="Consulta">Consulta que enviamos a la base de datos</param>
        /// <param name="nomDataTable">Nombre de la tabla para el DataSet</param>
        /// <returns>DataSet con los datos que se han pedido en la consulta</returns>
        public DataSet PortarPerConsulta(string Consulta, string nomDataTable)
        {
            dts = new DataSet();

            Connectar();

            SqlDataAdapter adapter;
            query = Consulta;
            adapter = new SqlDataAdapter(query, conn);

            conn.Open();

            adapter.Fill(dts, nomDataTable);

            conn.Close();

            return dts;
        }

        /// <summary>
        /// Metodo para actulizar la base de datos, eliminar, añadir o actualizar la tabla de manera desconectada, atraves del DataSet
        /// </summary>
        /// <returns>DataSet con los valores cambiados de la tabla</returns>
        public DataSet Actualitzar()
        {
            conn.Open();

            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder cmdBuilder;
            cmdBuilder = new SqlCommandBuilder(adapter);

            if (dts.HasChanges())
            {
                int result = adapter.Update(dts.Tables[0]);
            }

            conn.Close();

            return dts;
        }

        /// <summary>
        /// Metodo para actulizar la base de datos, eliminar, añadir o actualizar la tabla de manera desconectada, atraves del DataSet
        /// </summary>
        /// <param name="dts">DataSet que utilizara para hacer los cambios</param>
        /// <param name="consulta">Consulta para ejecutar en la base de datos</param>
        /// <returns></returns>
        public DataSet Actualitzar(DataSet dts, string consulta)
        {
            int result = 0;

            conn.Open();

            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter(consulta, conn);
            SqlCommandBuilder cmdBuilder;
            cmdBuilder = new SqlCommandBuilder(adapter);

            if (dts.HasChanges())
            {
                result = adapter.Update(dts.Tables[0]);
            }

            conn.Close();

            return dts;
        }

        /// <summary>
        /// Metodo para actulizar la base de datos, eliminar, añadir o actualizar la tabla de manera directa (Conectados)
        /// </summary>
        /// <param name="Consulta">Consulta que utilizamos en la base de datos y ejuctamos en la tabla</param>
        public void Executa(string Consulta)
        {
            query = Consulta;

            conn.Open();

            SqlCommand cmd = new SqlCommand(query, conn);
            int registresAfectats = cmd.ExecuteNonQuery();

            cmd.Dispose();

            conn.Close();
        }

        //public void GeneraConsultaCerca(string nomTaula, Dictionary<string, string> dicc)
        //{
        //    SqlCommand command = conn.CreateCommand();

        //    command.CommandType = CommandType.Text;

        //    command.CommandText = "SELECT COUNT(*) FROM [Users] " +

        //    "WHERE [codeuser] = @User " +

        //    "AND [Password] = @Password";

        //    int count = (int)command.ExecuteScalar();
        //}
    }
}
