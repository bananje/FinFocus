using FinFocus.Domain.Common;

namespace FinFocus.Domain.AggregateModels.FinancalPlanAggregate.ValueObjects
{
    public partial class PassiveProfitOnStart : ValueObject
    {
        public PassiveProfitOnStart(double capitalOnBond, double bondPercent)
            => Value = capitalOnBond * bondPercent / 12;

        public double Value { get; private set; }
    }
}