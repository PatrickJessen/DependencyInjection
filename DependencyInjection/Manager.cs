using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Manager
    {
        public IReader Reader { get; set; }

        public Manager(IReader reader)
        {
            Reader = reader;
        }

        public string Manage()
        {
            return Reader.Read();
        }
    }
}
