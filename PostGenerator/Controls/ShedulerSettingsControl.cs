using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostGenerator
{
    public partial class ShedulerSettingsControl : UserControl
    {
        /// <summary>
        /// Тайм-аут между изображениями (дней)
        /// </summary>
        public decimal? ImageTimeout
        {
            get
            {
                return nudImageTimeout.Value;
            }
            set
            {
                nudImageTimeout.Value = value ?? 30;
            }
        }

        /// <summary>
        /// Тайм-аут между текстами (дней)
        /// </summary>
        public decimal? TextTimeout
        {
            get
            {
                return nudTextTimeout.Value;
            }
            set
            {
                nudTextTimeout.Value = value ?? 7;
            }
        }

        /// <summary>
        /// Диапазон часов публикации (от)
        /// </summary>
        public decimal? PubHoursRangeFrom
        {
            get
            {
                return nudPubHoursRangeFrom.Value;
            }
            set
            {
                nudPubHoursRangeFrom.Value = value ?? 6;
            }
        }

        /// <summary>
        /// Диапазон часов публикации (до)
        /// </summary>
        public decimal? PubHoursRangeTo
        {
            get
            {
                return nudPubHoursRangeTo.Value;
            }
            set
            {
                nudPubHoursRangeTo.Value = value ?? 23;
            }
        }

        /// <summary>
        /// Минимальный интервал между постами (минут)
        /// </summary>
        public decimal? IntervalBetweenPosts
        {
            get
            {
                return nudIntervalBetweenPosts.Value;
            }
            set
            {
                nudIntervalBetweenPosts.Value = value ?? 60;
            }
        }

        public ShedulerSettingsControl()
        {
            InitializeComponent();
        }
    }
}
