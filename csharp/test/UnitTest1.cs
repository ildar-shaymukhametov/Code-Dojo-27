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

        [Fact]
        public void Served_glasses_are_filled_with_20_ounces_of_beer()
        {
            var expectedAmountOfBeer = 20;
            Glass glass = new Pub().ServeBeer();
            Assert.Equal(expectedAmountOfBeer, glass.Amount);
        }

        [Fact]
        public void Glasses_initially_empty()
        {
            var glass = new Glass();
            Assert.True(glass.IsEmpty);
        }

        [Fact]
        public void Drinking_from_glass_removes_1_ounce_of_beer()
        {
            var amountToDrink = 1;
            var glass = new Glass();
            glass.Fill(10);
            var expectedAmountOfBeer = glass.Amount - amountToDrink;
            glass.Drink();
            Assert.Equal(expectedAmountOfBeer, glass.Amount);
        }

        [Fact]
        public void Quaffing_from_glass_removes_4_ounces_of_beer()
        {
            var amountToDrink = 4;
            var glass = new Glass();
            glass.Fill(10);
            var expected = glass.Amount - amountToDrink;
            glass.Quaff();
            Assert.Equal(expected, glass.Amount);
        }
    }
}
