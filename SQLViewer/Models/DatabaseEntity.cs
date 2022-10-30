using SQLViewer.DAL;
using System;
using System.Collections.Generic;

namespace SQLViewer.Models
{
    public class DatabaseEntity
    {
        private readonly Lazy<IEnumerable<Column>> columns;

        public DatabaseEntity()
        {
            columns = new Lazy<IEnumerable<Column>>(() => RepositoryFactory.GetRepository().GetColumns(this));
        }

        public IList<Column> Columns
        {
            get => new List<Column>(columns.Value);
        }

        public string Schema { get; set; }
        public string Name { get; set; }
        public Database Database { get; set; }

        public override string ToString()
        {
            return $"{Schema}.{Name}";
        }
    }
}
