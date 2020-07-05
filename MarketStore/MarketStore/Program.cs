using MarketStoreLogic;

namespace MarketStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DiscountCard discountCard = new BronzeCard("Petar", 0);
            discountCard.PrintDiscountAndPurchase(150);

            discountCard = new SilverCard("Marko", 600);
            discountCard.PrintDiscountAndPurchase(850);

            discountCard = new GoldenCard("Stevan", 1500);
            discountCard.PrintDiscountAndPurchase(1300);
        }
    }
}
