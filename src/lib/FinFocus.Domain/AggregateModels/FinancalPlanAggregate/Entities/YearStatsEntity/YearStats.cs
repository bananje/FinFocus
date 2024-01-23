using FinFocus.Domain.AggregateModels.FinancalPlanAggregate.Entities.YearStatsEntity.ValueObjects;
using FinFocus.Domain.Common;

namespace FinFocus.Domain.AggregateModels.FinancalPlanAggregate.Entities.YearStatsEntity
{
    public class YearStats : Entity<YearStatsId>
    {
        public DateTime? FinanceYear { get; set; }

        /// <summary>
        /// Капитал на текущий год
        /// </summary>
        public double? Capital { get; set; }

        /// <summary>
        /// Рублей в акциях
        /// </summary>
        public ShareProportion? ShareProportion { get; set; }

        /// <summary>
        /// Рублей в облигациях
        /// </summary>
        public double BondProportion { get; set; }

        /// <summary>
        /// Доход от акций
        /// </summary>
        public ShareProfit? ShareProfit { get; set; }

        /// <summary>
        /// Доход от облигаций
        /// </summary>
        public BondProfit? BondProfit { get; set; }

        /// <summary>
        /// Доходность портфеля за год
        /// </summary>
        public TotalProfit? TotalProfit { get; set; }

        /// <summary>
        /// Ежемесячное пополнение
        /// </summary>
        public RefilValue? RefilValue { get; set; }

        /// <summary>
        /// Сумма ежемесячного купона
        /// </summary>
        public CouponeValue? CouponeValue { get; set; }
    }
}
