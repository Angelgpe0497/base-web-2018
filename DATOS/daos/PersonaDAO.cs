using DATOS.modelo;
using DATOS.util;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS.daos
{
    public class PersonaDAO
    {
        public void insert(Persona p)
        {
            Conexion con = new Conexion();
            String SQL ="INSERT INTO persona (nombre,fecha)" +
                "VALUES (@nombre, @fecha);";

            MySqlCommand sqlCom = new MySqlCommand();
            sqlCom.CommandText = SQL;
            sqlCom.Parameters.AddWithValue("@nombre", p.nombre);
            sqlCom.Parameters.AddWithValue("@fecha", p.fecha);
            con.EjecutaSQLComando(sqlCom);
        }
        
        public void delete(Persona p)
        {
            Conexion con = new Conexion();
            String SQL = "DELETE FROM persona WHERE id=@id limit 1;";

            MySqlCommand sqlCom = new MySqlCommand();
            sqlCom.CommandText = SQL;
            sqlCom.Parameters.AddWithValue("@id", p.id);
            con.EjecutaSQLComando(sqlCom);
        }
        
        public void delete2(int id)
        {
            Conexion con = new Conexion();
            String SQL = "DELETE FROM persona WHERE id=@id limit 1;";

            MySqlCommand sqlCom = new MySqlCommand();
            sqlCom.CommandText = SQL;
            sqlCom.Parameters.AddWithValue("@id", id);
            con.EjecutaSQLComando(sqlCom);
        }

        public void update(Persona p)
        {
            Conexion con = new Conexion();
            String SQL = "UPDATE persona" +
                "SET nombre = @nombre" +
                "WHERE id = @id limit 1;";

            MySqlCommand sqlCom = new MySqlCommand();
            sqlCom.CommandText = SQL;
            sqlCom.Parameters.AddWithValue("@id", p.id);
            sqlCom.Parameters.AddWithValue("@nombre", p.nombre);
            con.EjecutaSQLComando(sqlCom);
        }


        public List<Persona> getAll() {
            List<Persona> lista = new List<Persona>();
            Conexion con = new Conexion();

            DataSet datos = con.LLenaComboGrid("SELECT * FROM persona");
            DataTable dt = datos.Tables[0];
            Persona p;
            foreach (DataRow r in  dt.Rows){

                p = new Persona();
                p.id =(int) r.ItemArray[0];
                p.nombre = (string)r.ItemArray[1];
                lista.Add(p);
            }

            return lista;
        }

        public DataSet getAllDataset()
        {
            Conexion con = new Conexion();
            DataSet datos = con.LLenaComboGrid("SELECT * FROM persona");
            return datos;
        }
    }
}
