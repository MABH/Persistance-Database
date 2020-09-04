using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySQL_Empleat.Models
{
    public class EmpleatContext
    {
        public string ConnectionString { get; set; }
        public EmpleatContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<Empleat> GetAllEmpleats()
        {
            List<Empleat> list = new List<Empleat>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from Empleat", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Empleat()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Nom = reader["Nom"].ToString(),
                            Cognom = reader["Cognom"].ToString(),
                            Carrec = reader["Carrec"].ToString(),
                            Sou = Convert.ToInt32(reader["Sou"])
                        });
                    }
                }
            }
            return list;
        }

        
        public  Empleat DeleteEmpleat(int id_empleat, string nom_empleat, string cognom_empleat, string carrec_empleat, int sou_empleat)
        {
            Empleat emp = new Empleat();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("delete from Empleat where id ="+id_empleat, conn);
                
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        
                    };
                    emp.Id = id_empleat;
                    emp.Nom = nom_empleat;
                    emp.Cognom = cognom_empleat;
                    emp.Carrec = carrec_empleat;
                    emp.Sou = sou_empleat;
                };
            }
            return emp;
        }

        public Empleat UpdateEmpleat(Empleat new_empleat)
        {
            Empleat emp = new Empleat();
            emp = new_empleat;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("update Empleat set nom='"+new_empleat.Nom+"',cognom='"+new_empleat.Cognom+"', carrec='"+new_empleat.Carrec+"',sou='"+new_empleat.Sou+"' where id='"+new_empleat.Id+"';", conn);
                
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                                             
                    }
                    
                }

            }
            return emp;
        }

        public Empleat InsertEmpleat(Empleat new_empleat)
        {
            Empleat emp = new Empleat();
            emp = new_empleat;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("insert into Empleat (id,nom,cognom,carrec,sou) values('" + new_empleat.Id + "','" + new_empleat.Nom + "','" + new_empleat.Cognom + "','" + new_empleat.Carrec + "','" + new_empleat.Sou + "');", conn);
                
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                    }

                }

            }
            return emp;
        }
    }
}
