using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ls1_5_class
{
    public class Trade
    {
        #region Fields
        public enum __directions : int { Short = -1, Long = 1, noValue = 0 }
        public enum __securities : int { Si, RTS, BR, MIX, SBRF, noValue }

        /// <summary>
        /// Цена инструмента
        /// </summary>
        public decimal Price = 0;
        public string SecCode = "";
        public string ClassCode = "";
        public DateTime DateTime = DateTime.MinValue;
        public string Portfolio = "";
        #endregion

        #region Properties
        /// <summary>
        /// Объем сделки
        /// </summary>
        public decimal Volume
        {
            get
            {
                return _volume;
            }

            set
            {
                _volume = value;
            }
        }
        decimal _volume = 0;

        public __directions Direction
        {
            get
            {
                return _direction;
            }

            set
            {
                _direction = value;
            }
        }
        __directions _direction = __directions.noValue;

        public __securities Security
        {
            get
            {
                return _security;
            }

            set
            {
                _security = value;
            }
        }
        __securities _security = __securities.noValue;

        #endregion
    }
}
