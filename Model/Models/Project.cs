using Presentor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Project : IProject
    {
        /// <summary>
        /// Путь к папке проекта
        /// </summary>
        public string ProjectFolderPath { get; set; }

        /// <summary>
        /// Настройки проекта
        /// </summary>
        public IEntity Settings { get; set; }

        /// <summary>
        /// База изображений проекта
        /// </summary>
        public IList<IEntity> ImageBase { get; set; }

        /// <summary>
        /// База текстов проекта
        /// </summary>
        public IList<IEntity> TextBase { get; set; }

        /// <summary>
        /// История публикаций постов
        /// </summary>
        public IList<IEntity> Calendar { get; set; }
    }
}
