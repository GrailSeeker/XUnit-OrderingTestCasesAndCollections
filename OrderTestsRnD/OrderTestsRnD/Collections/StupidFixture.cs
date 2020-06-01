using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTestsRnD.Collections
{
    public class StupidFixture : IDisposable
    {
        public List<string>  CollectionOfAnts { get; set; }

        public StupidFixture()
        {
            CollectionOfAnts = new List<string>();
        }

        public void Dispose()
        {
           //...
        }
    }
}
