using FinFocus.Domain.Common;

namespace FinFocus.Domain.AggregateModels.FinancalPlanAggregate.Entities.YearStatsEntity.ValueObjects
{
    public partial class BondProfit : ValueObject
    {
        public BondProfit(double bondProportion,
                          double bondProfit)

            => Value = bondProportion * (bondProfit / 100);
        public double Value { get; private set; }
    }
}