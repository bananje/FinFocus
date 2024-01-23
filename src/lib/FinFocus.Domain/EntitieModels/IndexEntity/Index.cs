using FinFocus.Domain.Common;

namespace FinFocus.Domain.EntitieModels.IndexEntity
{
    public class Index : Entity<IndexId>
    {
        /// <summary>
        /// Тикер индекса
        /// </summary>
        public string Tiсker { get; set; } = null!;

        /// <summary>
        /// Наименование
        /// </summary>
        public string Title { get; set; } = null!;

        /// <summary>
        /// Начало отслеживания
        /// </summary>
        public DateTime StatisticsStart { get; set; }

        /// <summary>
        /// Закрытие отслеживания
        /// </summary>
        public DateTime StatisticsEnd { get; set; }
    }
}
