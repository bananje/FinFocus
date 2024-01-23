using FinFocus.Domain.AggregateModels.FinancalPlanAggregate.Entities.YearStatsEntity;
using FinFocus.Domain.AggregateModels.FinancalPlanAggregate.ValueObjects;
using FinFocus.Domain.Common;

namespace FinFocus.Domain.AggregateModels.FinancalPlanAggregate
{
    public class FinancialPlan : AggregateRoot<FinancialPlanId>
    {
        private readonly HashSet<YearStats> _yearStats = new();

        /// <summary>
        /// Начальный капитал
        /// </summary>
        public decimal Capital { get; set; }

        /// <summary>
        /// Процент акций в портфеле
        /// </summary>
        public double SharePercent { get; set; }

        /// <summary>
        /// Потенциальная доходность акций
        /// </summary>
        public double PotentialSharesProfit { get; set; }

        /// <summary>
        /// Доходность облигаций
        /// </summary>
        public double BondProfit { get; set; }

        /// <summary>
        /// Средняя доходность портфеля
        /// </summary>
        public AvgPortfolioProfit AvgPortfolioProfit { get; set; } = null!;

        /// <summary>
        /// Пассивный доход на старте
        /// </summary>
        public PassiveProfitOnStart PassiveProfitOnStart { get; set; } = null!;

        /// <summary>
        /// Доход от ИИС
        /// </summary>
        public ProfitFromIis ProfitFromIis{ get; set; } = null!;

        /// <summary>
        /// Статистические показатели за год
        /// </summary>
        public IReadOnlyCollection<YearStats> YearStats => _yearStats;

    }
}
