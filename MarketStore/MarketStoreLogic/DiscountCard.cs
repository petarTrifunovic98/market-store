using System;

namespace MarketStoreLogic
{
    public abstract class DiscountCard
    {
        private string _ownerName;
        private float _turnover;
        private float _initialDiscountRate;

        protected float Turnover
        {
            get { return _turnover; }
        }

        protected float InitialDiscountRate
        {
            get { return _initialDiscountRate; }
        }

        public DiscountCard(string ownerName, float turnover, float initialDiscountRate)
        {
            _ownerName = ownerName;
            _turnover = turnover;
            _initialDiscountRate = initialDiscountRate;
        }

        public abstract float CalculateDiscountRate(float purchaseValue);

        public void PrintDiscountAndPurchase(float purchaseValue)
        {
            float discountRate = CalculateDiscountRate(purchaseValue);
            float discount = (discountRate / 100) * purchaseValue;
            float total = purchaseValue - discount;

            Console.WriteLine("Purchase value: $" + purchaseValue.ToString("0.00"));
            Console.WriteLine("Discount rate: " + discountRate.ToString("0.00") + "%");
            Console.WriteLine("Discount: $" + discount.ToString("0.00"));
            Console.WriteLine("Total: $" + total.ToString("0.00"));
            Console.WriteLine();
        }
    }
}
