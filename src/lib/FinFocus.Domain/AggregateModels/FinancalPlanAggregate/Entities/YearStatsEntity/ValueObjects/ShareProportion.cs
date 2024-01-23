using FinFocus.Domain.Common;

namespace FinFocus.Domain.AggregateModels.FinancalPlanAggregate.Entities.YearStatsEntity.ValueObjects
{
    public partial class ShareProportion : ValueObject
    {
        public ShareProportion(double capital, double sharePercent)

            => Value = capital * (sharePercent / 100);

        public double Value { get; private set; }
    }
}