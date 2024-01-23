using FinFocus.Domain.Common;

namespace FinFocus.Domain.AggregateModels.FinancalPlanAggregate.Entities.YearStatsEntity.ValueObjects
{
    public partial class ShareProfit : ValueObject
    {
        public ShareProfit(double shareProportion,
                           double potentialShareProfit)

        => Value = shareProportion * (potentialShareProfit / 100);

        public double Value { get; private set; }
    }
}