using FinFocus.Domain.Common;
using FinFocus.Domain.EntitieModels.Common;
using FinFocus.Domain.EnumerationModels;

namespace FinFocus.Domain.EntitieModels.BondEntity
{
    public class Bond : Entity<BondId>, IAsset
    {
        /// <summary>
        /// Годовая купонная доходность
        /// </summary>
        public decimal? CouponePercent { get; set; }

        /// <summary>
        /// Расчётная валюта
        /// </summary>
        public Currency? Currency { get; set; }

        /// <summary>
        /// Наличие оферты
        /// </summary>
        public bool? HasOffer { get; set; } 

        /// <summary>
        /// Наличие суббординации
        /// </summary>
        public bool? HasSubordination { get; set; } 

        /// <summary>
        /// Cтруктурность облигации
        /// </summary>
        public bool? IsStructure { get; set; }

        /// <summary>
        /// Квалификация инвестора
        /// </summary>
        public bool? HasQualification { get; set; } 

        /// <summary>
        /// Обеспечение
        /// </summary>
        public Security? HasSecurity { get; set; } = null!;

        /// <summary>
        /// Изначальная цена
        /// </summary>
        public decimal? InitPrice { get; set; }

        /// <summary>
        /// Текущая цена
        /// </summary>
        public decimal? CurrentPrice { get; set; }

        /// <summary>
        /// Тип цены
        /// </summary>
        public PriceType? PriceType { get; set; } = null!;

        /// <summary>
        /// Количество купонных вылпат в год
        /// </summary>
        public int? CouponsCountPerYear { get; set; }

        /// <summary>
        /// Эмитент 
        /// </summary>
        public string? CompanyName { get; set; } = null!;

        /// <summary>
        /// Дата выпуска
        /// </summary>
        public DateTime? IssueDate { get; set; }

        /// <summary>
        /// Дата гашения
        /// </summary>
        public DateTime? CancellationDate { get; set; }

        /// <summary>
        /// Дата ближайшего купона
        /// </summary>
        public DateTime? NextCoupon { get; set; }

        /// <summary>
        /// Вид облигаций
        /// </summary>
        public BondType? BondType { get; set; } = null!;
    }
}
