using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9M2
{
    class Program
    {
        static void Main(string[] args)
        {

            var factory = DbProviderFactories.GetFactory("System.Data.SqlClient");

            

            using (DbConnection myCn = factory.CreateConnection())
            {
                myCn.ConnectionString = @"Data Source=(LocalDB)\v11.0;Initial Catalog=School;Integrated Security=true;";

                myCn.Open();

                using (var cmd = myCn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT * FROM dbo.Person";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                Console.WriteLine("{0}", reader.GetName(i));
                            }
                            Console.WriteLine("\n");
                            while (reader.Read())
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    Console.WriteLine("{0}", reader.GetValue(i));
                                }
                                Console.WriteLine("\n");
                            }
                        }
                        Console.ReadLine();
                        
                    }

                    cmd.CommandText = @"SELECT * FROM dbo.Course";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                Console.WriteLine("{0}", reader.GetName(i));
                            }
                            Console.WriteLine("\n");
                            while (reader.Read())
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    Console.WriteLine("{0}", reader.GetValue(i));
                                }
                                Console.WriteLine("\n");
                            }
                        }
                    }
                    Console.ReadLine();
                }


            }


        }
    }
}
