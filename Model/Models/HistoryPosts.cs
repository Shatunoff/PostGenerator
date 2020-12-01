using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class HistoryPosts
    {
        /// <summary>
        /// Id поста
        /// </summary>
        public virtual int Id { get; private set; }

        /// <summary>
        /// Использованное изображение
        /// </summary>
        public virtual Image UsedImage { get; set; }

        /// <summary>
        /// Использованный текст
        /// </summary>
        public virtual Text UsedText { get; set; }

        /// <summary>
        /// Социальная сеть, в которой пост был опубликован
        /// </summary>
        public virtual string SocialNetworkName { get; set; }

        /// <summary>
        /// Дата публикации
        /// </summary>
        public virtual DateTime DateOfPublication { get; set; }
    }
}
