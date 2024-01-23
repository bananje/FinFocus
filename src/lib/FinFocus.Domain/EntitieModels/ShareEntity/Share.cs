using FinFocus.Domain.Common;
using FinFocus.Domain.EntitieModels.Common;
using FinFocus.Domain.EntitieModels.ShareEntity.Enumerations;

namespace FinFocus.Domain.EntitieModels.ShareEntity
{
    public class Share : Entity<ShareId>, IAsset
    {
        /// <summary>
        /// Налачие дивидендов
        /// </summary>
        public bool? HasDividends { get; set; }

        /// <summary>
        /// Годовая дивидендная доходность
        /// </summary>
        public double? DividendsPercent { get; set; }

        /// <summary>
        /// Капитализация
        /// </summary>
        public decimal? Capitalization { get; set; }

        /// <summary>
        /// Стоимость лота
        /// </summary>
        public decimal? LotPrice { get; set; }

        /// <summary>
        /// P/E значение
        /// </summary>
        public decimal? PeValue { get; set; }

        /// <summary>
        /// Beta значение
        /// </summary>
        public decimal? BetaValue { get; set; }

        /// <summary>
        /// Peg значение
        /// </summary>
        public decimal? PegValue { get; set; }

        /// <summary>
        /// Прирост за год
        /// </summary>
        public double? IncreasePerYear { get; set; }

        /// <summary>
        /// Прирост за месяц
        /// </summary>
        public double? IncreasePerMonth { get; set; }

        /// <summary>
        /// Прирост за 3 года
        /// </summary>
        public double? IncreasePerThreeYears { get; set; }

        /// <summary>
        /// Индекс бумаги
        /// </summary>
        public IndexEntity.Index? Index { get; set; } = null!;

        /// <summary>
        /// Доля экспорта
        /// </summary>
        public double? ExportShare { get; set; }

        /// <summary>
        /// Юрисдикция акции
        /// </summary>
        public Jurisdiction? Jurisdiction { get; set; } = null!;
    }
}
