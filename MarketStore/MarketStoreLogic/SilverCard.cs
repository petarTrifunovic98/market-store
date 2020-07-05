namespace MarketStoreLogic
{
    public class SilverCard : DiscountCard
    {
        public SilverCard(string ownerName, float turnover):base(ownerName, turnover, 2)
        { }

        public override float CalculateDiscountRate(float purchaseValue)
        {
            float turnover = Turnover;
            float discountRate = InitialDiscountRate;

            if (turnover > 300)
                discountRate = 3.5f;

            return discountRate;
        }
    }
}
