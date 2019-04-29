/*
 * ITSE 1430
 * Jakob Rodriguez
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile.Stores.Sql
{
    public class SqlProductDatabase : ProductDatabase
    {
        private readonly string _connectionString;

        public SqlProductDatabase( string connectionString )
        {
            _connectionString = connectionString;
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

        private string GetString(IDataReader reader, string name)
        {
            var ordinal = reader.GetOrdinal(name);

            if (reader.IsDBNull(ordinal))
                return "";

            return reader.GetString(ordinal);
        }
        
        protected override Product GetCore( int id )
        {
            using (var conn = GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "GetProduct";
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var prodId = reader.GetInt32(0);
                    if (prodId == id)
                    {
                        return new Product()
                        {
                            Id = prodId,
                            Name = GetString(reader, "Name"),
                            Description = GetString(reader, "Description"),
                            Price = reader.GetFieldValue<decimal>(3),
                            IsDiscontinued = Convert.ToBoolean(reader.GetValue(4))
                        };
                    };
                };
            };

            return null;
        }

        protected override IEnumerable<Product> GetAllCore()
        {
            var ds = new DataSet();

            using (var conn = GetConnection())
            {
                var cmd = new SqlCommand("GetAllProducts", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                var da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
            };
            
            var table = ds.Tables.OfType<DataTable>().FirstOrDefault();
            if (table != null)
            {
                return from r in table.Rows.OfType<DataRow>()
                       select new Product()
                       {
                           Id = Convert.ToInt32(r[0]), 
                           Name = r["Name"].ToString(),
                           Description = r.IsNull("Description") ? "" : r["Description"].ToString(), //handle database nulls
                           Price = r.Field<decimal>("Price"),
                           IsDiscontinued = r.Field<bool>("IsDiscontinued"),
                       };
            };

            return Enumerable.Empty<Product>();
        }

        protected override void RemoveCore( int id )
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                 
                var cmd = connection.CreateCommand();
                cmd.CommandText = "RemoveProduct";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", id);
                
                cmd.ExecuteNonQuery();
            };
        }

        protected override Product UpdateCore( int id, Product newItem )
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                //var cmd = new SqlCommand("", connection);
                var cmd = connection.CreateCommand();
                cmd.CommandText = "UpdateProduct";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //Add parameter 1 - long way when you need control over parameter
                var parameter = new SqlParameter("@Name", System.Data.SqlDbType.NVarChar);

                cmd.Parameters.AddWithValue("@Name", newItem.Name);
                cmd.Parameters.AddWithValue("@Description", newItem.Description);
                cmd.Parameters.AddWithValue("@Price", newItem.Price);
                cmd.Parameters.AddWithValue("@IsDiscontinued", newItem.IsDiscontinued);
                cmd.Parameters.AddWithValue("@Id", id);

                //No results
                cmd.ExecuteNonQuery();
            };

            return newItem;
        }

        protected override Product AddCore( Product product )
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                
                var cmd = connection.CreateCommand();
                cmd.CommandText = "AddProduct";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Name", product.Name);
                cmd.Parameters.AddWithValue("@Description", product.Description);
                cmd.Parameters.AddWithValue("@Price", product.Price);
                cmd.Parameters.AddWithValue("@IsDiscontinued", product.IsDiscontinued);


                var result = Convert.ToInt32(cmd.ExecuteScalar());

                product.Id = result;
                return product;
            };
        }
    }
}
