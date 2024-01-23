using FinFocus.Domain.EntitieModels.Common;

namespace FinFocus.Domain.AggregateModels.PortfolioAggregate
{
    public class Portfolio
    {
        private readonly HashSet<IAsset> _assets = new();

        /// <summary>
        /// Наименование портфеля
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Дата создания портфеля
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Общая стоимость 
        /// </summary>
        public decimal TotalPrice { get; set; }

        /// <summary>
        /// Процент акций в портфеле
        /// </summary>
        public decimal SharesPercent { get; set; }

        /// <summary>
        /// Процент облигаций в порфтеле
        /// </summary>
        public decimal BoundsPercent { get; set; }

        /// <summary>
        /// Процент EFT в портфеле
        /// </summary>
        public decimal EtfPercent { get; set; }

        /// <summary>
        /// Процент за год
        /// </summary>
        public decimal PercentPerYear { get; set; }

        /// <summary>
        /// Расчётный потенциал
        /// </summary>
        public decimal Potential { get; set; }

        /// <summary>
        /// Средний P/E активов в портфеле
        /// </summary>
        public double PeAvg { get; set; }

        /// <summary>
        /// Активы в портфеле
        /// </summary>
        public IReadOnlyCollection<IAsset> Assets => _assets;

        public Portfolio()
        {
            
        }
    }
}
