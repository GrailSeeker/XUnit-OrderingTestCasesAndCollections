using OrderTestsRnD.Collections;
using System.Diagnostics;
using Xunit;
using Xunit.Extensions.Ordering;

namespace OrderTestsRnD
{
    [Collection("Stupid Collections"), Order(2)]
    public class AnotherStupidTest
    {
        StupidFixture _fixture;

        public AnotherStupidTest(StupidFixture fixture)
        {
            this._fixture = fixture;
        }

        [Fact, Order(3)]
        public void AnotherStupidTest1()
        {
            this._fixture.CollectionOfAnts.Add("AStupidTest# 3");
        }

        [Fact, Order(1)]
        public void AnotherStupidTest2()
        {
            this._fixture.CollectionOfAnts.Add("AStupidTest# 1");
        }

        [Fact, Order(2)]
        public void AnotherStupidTest3()
        {
            this._fixture.CollectionOfAnts.Add("AStupidTest# 2");
        }
    }
}
