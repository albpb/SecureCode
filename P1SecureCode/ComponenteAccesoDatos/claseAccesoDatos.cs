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
    /// 
    /// </summary>
    public abstract class claseAccesoDatos
    {
        /// <summary>
        /// 
        /// </summary>
        public SqlConnection conn;
        private string query;
        DataSet dts;

        /// <summary>
        /// 
        /// </summary>
        public virtual void Connectar()
        {
            string cnx = "";
            ConnectionStringSettings conf = ConfigurationManager.ConnectionStrings[""];

            if (conf != null)
            {
                cnx = conf.ConnectionString;
            }

            conn = new SqlConnection(cnx);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="taula"></param>
        /// <returns></returns>
        public DataSet PortarTaula(string taula)
        {
            dts = new DataSet();

            SqlDataAdapter adapter;
            query = "SELECT * From " + taula;
            adapter = new SqlDataAdapter(query, conn);

            conn.Open();

            adapter.Fill(dts, taula);

            conn.Close();

            return dts;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Consulta"></param>
        /// <returns></returns>
        public DataSet PortarPerConsulta(string Consulta)
        {
            dts = new DataSet();

            SqlDataAdapter adapter;
            query = Consulta;
            adapter = new SqlDataAdapter(query, conn);

            conn.Open();

            adapter.Fill(dts, "Tabla");

            conn.Close();

            return dts;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Consulta"></param>
        /// <param name="nomDataTable"></param>
        /// <returns></returns>
        public DataSet PortarPerConsulta(string Consulta, string nomDataTable)
        {
            dts = new DataSet();

            SqlDataAdapter adapter;
            query = Consulta;
            adapter = new SqlDataAdapter(query, conn);

            conn.Open();

            adapter.Fill(dts, nomDataTable);

            conn.Close();

            return dts;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <param name="Consulta"></param>
        public void Executa(string Consulta)
        {
            query = Consulta;

            conn.Open();

            SqlCommand cmd = new SqlCommand(query, conn);
            int registresAfectats = cmd.ExecuteNonQuery();

            cmd.Dispose();

            conn.Close();
        }
    }
}
