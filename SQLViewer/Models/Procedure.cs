using SQLViewer.DAL;
using System;
using System.Collections.Generic;

namespace SQLViewer.Models
{
    public class Procedure
    {
        private readonly Lazy<IEnumerable<ProcedureParameters>> parameters;

        public Procedure()
        {
            parameters = new Lazy<IEnumerable<ProcedureParameters>>(() => RepositoryFactory.GetRepository().GetParameters(this));
        }

        public IList<ProcedureParameters> Parameters
        {
            get => new List<ProcedureParameters>(parameters.Value);
        }

        public string Name { get; set; }
        public string Definition { get; set; }
        public Database Database { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
