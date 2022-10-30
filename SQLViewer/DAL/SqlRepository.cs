using SQLViewer.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SQLViewer.DAL
{
    internal class SqlRepository : IRepository
    {
        private const string ConnectionString = "Server={0};Uid={1};Pwd={2}";
        private const string SelectDatabases = "SELECT name As Name FROM sys.databases";
        private const string SelectEntities = "SELECT TABLE_SCHEMA AS [Schema], TABLE_NAME AS Name FROM {0}.INFORMATION_SCHEMA.{1}S";
        private const string SelectProcedures = "SELECT SPECIFIC_NAME as Name, ROUTINE_DEFINITION as Definition FROM {0}.INFORMATION_SCHEMA.ROUTINES WHERE ROUTINE_TYPE = 'PROCEDURE'";
        private const string SelectColumns = "SELECT COLUMN_NAME as Name, DATA_TYPE as DataType FROM {0}.INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{1}'";
        private const string SelectProcedureParameters = "SELECT PARAMETER_NAME as Name, PARAMETER_MODE as Mode, DATA_TYPE as DataType FROM {0}.INFORMATION_SCHEMA.PARAMETERS WHERE SPECIFIC_NAME='{1}'";
        private const string SelectQuery = "SELECT * FROM {0}.{1}.{2}";
        private string cs;

        public void LogIn(string server, string username, string password)
        {
            using (SqlConnection con = new SqlConnection(string.Format(ConnectionString, server, username, password)))
            {
                cs = con.ConnectionString;
                con.Open();
            }
        }

        public IEnumerable<Database> GetDatabases()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = SelectDatabases;
                    cmd.CommandType = System.Data.CommandType.Text;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            yield return new Database
                            {
                                Name = dr["Name"].ToString()
                            };
                        }
                    }
                }
            }
        }

        public IEnumerable<DatabaseEntity> GetDatabaseEntities(Database database, DatabaseEntityType databaseEntity)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = string.Format(SelectEntities, database.Name, databaseEntity.ToString());
                    cmd.CommandType = System.Data.CommandType.Text;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            yield return new DatabaseEntity
                            {
                                Name = dr[nameof(DatabaseEntity.Name)].ToString(),
                                Schema = dr[nameof(DatabaseEntity.Schema)].ToString(),
                                Database = database
                            };
                        }
                    }
                }
            }
        }

        public IEnumerable<Procedure> GetProcedures(Database database)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = string.Format(SelectProcedures, database.Name);
                    cmd.CommandType = System.Data.CommandType.Text;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            yield return new Procedure
                            {
                                Name = dr[nameof(Procedure.Name)].ToString(),
                                Definition = dr[nameof(Procedure.Definition)].ToString(),
                                Database = database
                            };
                        }
                    }
                }
            }
        }

        public IEnumerable<Column> GetColumns(DatabaseEntity databaseEntity)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = string.Format(SelectColumns, databaseEntity.Database.Name, databaseEntity.Name);
                    cmd.CommandType = System.Data.CommandType.Text;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            yield return new Column
                            {
                                Name = dr[nameof(Column.Name)].ToString(),
                                DataType = dr[nameof(Column.DataType)].ToString()
                            };
                        }
                    }
                }
            }
        }

        public IEnumerable<ProcedureParameters> GetParameters(Procedure procedure)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = string.Format(SelectProcedureParameters, procedure.Database.Name, procedure.Name);
                    cmd.CommandType = System.Data.CommandType.Text;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            yield return new ProcedureParameters
                            {
                                Name = dr[nameof(ProcedureParameters.Name)].ToString(),
                                Mode = dr[nameof(ProcedureParameters.Mode)].ToString(),
                                DataType = dr[nameof(ProcedureParameters.DataType)].ToString()
                            };
                        }
                    }
                }
            }
        }

        public DataSet CreateDataset(DatabaseEntity databaseEntity)
        {
            using (SqlConnection connection = new SqlConnection(cs))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter
                (
                    string.Format
                    (
                        SelectQuery, 
                        databaseEntity.Database.Name, 
                        databaseEntity.Schema, 
                        databaseEntity.Name
                    ), 
                    connection
                );

                DataSet dataSet = new DataSet(databaseEntity.Name);
                sqlDataAdapter.Fill(dataSet);
                dataSet.Tables[0].TableName = databaseEntity.Name;

                return dataSet;
            }
        }
    }
}
