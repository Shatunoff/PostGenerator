using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentor
{
    public interface IProject
    {
        string ProjectFolderPath { get; set; }
        IEntity Settings { get; set; }
        IList<IEntity> ImageBase { get; set; }
        IList<IEntity> TextBase { get; set; }
        IList<IEntity> Calendar { get; set; }
    }
}
