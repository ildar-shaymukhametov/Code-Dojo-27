using src;
using Xunit;

namespace test
{
    public class UnitTest1
    {
        [Fact]
        public void Pub_serves_beer_in_1_pint_glasses()
        {
            Glass glass = new Pub().ServeBeer();
            Assert.Equal(20, glass.Capacity);
        }
    }
}
