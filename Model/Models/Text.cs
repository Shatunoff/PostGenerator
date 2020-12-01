using Presentor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Text : IEntity
    {
        /// <summary>
        /// Идентификатор текста в бд
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Текстовое содержимое поста
        /// </summary>
        public virtual string Content { get; set; }

        /// <summary>
        /// Дата последнего использования в ВК
        /// </summary>
        public virtual DateTime DateLastUseInVK { get; set; }

        /// <summary>
        /// Дата последнего использования в Телеграм
        /// </summary>
        public virtual DateTime DateLastUseInTelegram { get; set; }
    }
}
