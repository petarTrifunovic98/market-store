namespace MarketStoreLogic
{
    public class GoldenCard : DiscountCard
    {
        public GoldenCard(string ownerName, float turnover) : base(ownerName, turnover, 2)
        { }

        public override float CalculateDiscountRate(float purchaseValue)
        {
            float turnover = Turnover;
            float discountRate = InitialDiscountRate;
            int numberOfHundreds = (int)(turnover / 100);

            discountRate += numberOfHundreds;
            if (discountRate > 10)
                discountRate = 10;

            return discountRate;
        }
    }
}
