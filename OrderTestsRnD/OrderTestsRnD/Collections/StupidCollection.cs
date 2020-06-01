using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace OrderTestsRnD.Collections
{
    [CollectionDefinition("Stupid Collections")]
    public class StupidCollection : ICollectionFixture<StupidFixture>
    {
        
    }
}
