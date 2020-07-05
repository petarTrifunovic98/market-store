namespace MarketStoreLogic
{
    public class BronzeCard : DiscountCard
    {
        public BronzeCard(string ownerName, float turnover):base(ownerName, turnover, 0)
        { }

        public override float CalculateDiscountRate(float purchaseValue)
        {
            float turnover = Turnover;
            float discountRate = InitialDiscountRate;

            if (turnover >= 100 && turnover <= 300)
                discountRate = 1;
            else if (turnover > 300)
                discountRate = 2.5f;

            return discountRate;
        }
    }
}
