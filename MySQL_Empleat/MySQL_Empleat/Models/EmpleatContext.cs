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

        public List<Empleat> DeleteEmpleat(int id_empleat)
        {
            List<Empleat> list = new List<Empleat>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("delete * from Empleat where id = @id_empleat", conn);
                var reader = cmd.ExecuteReader();

                cmd = new MySqlCommand("select * from Empleat", conn);

                using (reader = cmd.ExecuteReader())
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

        public List<Empleat> UpdateEmpleat(Empleat new_empleat)
        {
            List<Empleat> list = new List<Empleat>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("Update empleat SET nom=@new_empleat.nom, cognom=@new_empleat.cognom, carrec=@new_empleat.carrec, sou=@new_empleat.sou  WHERE id= @new_empleat.id", conn);
                var reader = cmd.ExecuteReader();

                cmd = new MySqlCommand("select * from Empleat", conn);

                using (reader = cmd.ExecuteReader())
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
    }
}
