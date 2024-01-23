using FinFocus.Domain.Common;

namespace FinFocus.Domain.AggregateModels.FinancalPlanAggregate
{
    public partial class ProfitFromIis : ValueObject
    {
        public ProfitFromIis(char iisType, 
                             double capital,
                             double refil,
                             double profitPer5Years)
        {
            Value = iisType switch
            {
                'A' => (capital < 400_000 ? capital * 13 : 52_000) +
                         (refil < 33_333 ? refil * 12 : 400_000) * 13 * 5,

                'B' => profitPer5Years * 13,

                _ => 0
            };

            if(Value is 0) 
                throw new ArgumentException("Invalid input IIS type. Correct types: A or B");
        }

        public double Value { get; private set; }
    }
}