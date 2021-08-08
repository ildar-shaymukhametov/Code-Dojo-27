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
            Glass glass = new Pub().ServeBeer();
            Assert.Equal(20, glass.RemainingLiquid);
        }

        [Fact]
        public void Glasses_initially_empty()
        {
            var glass = new Glass();
            Assert.True(glass.IsEmpty);
        }

        [Fact]
        public void Drinking_from_glass_removes_1_ounce_of_remaining_liquid()
        {
            var amountToDrink = 1;
            var glass = CreateGlass();
            var expected = glass.RemainingLiquid - amountToDrink;
            glass.Drink();
            Assert.Equal(expected, glass.RemainingLiquid);
        }

        [Fact]
        public void Quaffing_from_glass_removes_4_ounces_of_remaining_liquid()
        {
            var amountToDrink = 4;
            var glass = CreateGlass();
            var expected = glass.RemainingLiquid - amountToDrink;
            glass.Quaff();
            Assert.Equal(expected, glass.RemainingLiquid);
        }

        [Fact]
        public void Downing_in_one_removes_makes_glass_empty()
        {
            var glass = CreateGlass();
            glass.DownInOne();
            Assert.True(glass.IsEmpty);
        }

        private static Glass CreateGlass()
        {
            var glass = new Glass();
            glass.Fill(10);
            return glass;
        }
    }
}
