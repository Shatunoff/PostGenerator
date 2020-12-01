using Presentor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Image : IEntity
    {
        /// <summary>
        /// Идентификатор изображения в бд
        /// </summary>
        public virtual int Id { get; set; }

        /// <summary>
        /// Наименование файла изображения
        /// </summary>
        public virtual string Filename { get; set; }

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
