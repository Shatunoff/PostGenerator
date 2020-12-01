using Presentor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ProjectSettings : IEntity
    {
        /// <summary>
        /// Системный номер параметра
        /// </summary>
        public virtual int Id { get; private set; }
        
        /// <summary>
        /// Код параметра
        /// </summary>
        public virtual string Code { get; set; }

        /// <summary>
        /// Значение параметра
        /// </summary>
        public virtual string Value { get; set; }

        /// <summary>
        /// Описание параметра
        /// </summary>
        public virtual string Description { get; set; }
    }
}
