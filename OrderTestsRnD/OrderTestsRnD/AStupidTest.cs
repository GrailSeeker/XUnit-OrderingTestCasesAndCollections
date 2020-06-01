using OrderTestsRnD.Collections;
using System.Diagnostics;
using Xunit;
using Xunit.Extensions.Ordering;

[assembly: TestFramework("Xunit.Extensions.Ordering.TestFramework", "Xunit.Extensions.Ordering")]
namespace OrderTestsRnD
{
    [Collection("Stupid Collections"), Order(1)]
    public class AStupidTest
    {
        StupidFixture _fixture;

        public AStupidTest(StupidFixture fixture)
        {
            this._fixture = fixture;
        }

        [Fact, Order(3)]
        public void AStupidTest1()
        {
            this._fixture.CollectionOfAnts.Add("AStupidTest# 3");
        }

        [Fact, Order(2)]
        public void AStupidTest2()
        {
            this._fixture.CollectionOfAnts.Add("AStupidTest# 2");
        }

        [Fact, Order(1)]
        public void AStupidTest3()
        {
            this._fixture.CollectionOfAnts.Add("AStupidTest# 1");
        }
    }
}
