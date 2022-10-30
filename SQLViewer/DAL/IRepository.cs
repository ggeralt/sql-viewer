using SQLViewer.Models;
using System.Collections.Generic;
using System.Data;

namespace SQLViewer.DAL
{
    public interface IRepository
    {
        IEnumerable<Column> GetColumns(DatabaseEntity databaseEntity);
        IEnumerable<DatabaseEntity> GetDatabaseEntities(Database database, DatabaseEntityType databaseEntity);
        IEnumerable<Database> GetDatabases();
        IEnumerable<ProcedureParameters> GetParameters(Procedure procedure);
        IEnumerable<Procedure> GetProcedures(Database database);
        void LogIn(string server, string username, string password);
        DataSet CreateDataset(DatabaseEntity databaseEntity);
    }
}