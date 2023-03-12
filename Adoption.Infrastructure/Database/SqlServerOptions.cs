using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adoption.Infrastructure.Database
{
    public class SqlServerOptions
    {
        public SqlServerOptions()
        {
        }

        public string ConnectionString { get; set; }
    }
}
