using FinFocus.Domain.Common;

namespace FinFocus.Domain.AggregateModels.FinancalPlanAggregate.ValueObjects
{
    public partial class AvgPortfolioProfit : ValueObject
    {
        public AvgPortfolioProfit(double potentialSharesProfit,
                                  double sharePercent,
                                  double bondProfit)

            => Value = (potentialSharesProfit * sharePercent) + bondProfit * (1 - sharePercent);
        
        public double Value { get; private set; }

    }
}