using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalAlert
{
    class Estatisticas
    {
        private string type;
        private int mediaValue;
        private int maxValue;
        private int minValue;
        private DateTime startDate;
        private DateTime endDate;

        public Estatisticas(string type, int mediaValue, int maxValue, int minValue, DateTime startDate, DateTime endDate)
        {
            this.type = type;
            this.MediaValue = mediaValue;
            this.MaxValue = maxValue;
            this.MinValue = minValue;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        public int MediaValue
        {
            get
            {
                return mediaValue;
            }

            set
            {
                mediaValue = value;
            }
        }

        public int MaxValue
        {
            get
            {
                return maxValue;
            }

            set
            {
                maxValue = value;
            }
        }

        public int MinValue
        {
            get
            {
                return minValue;
            }

            set
            {
                minValue = value;
            }
        }

        public DateTime StartDate
        {
            get
            {
                return startDate;
            }

            set
            {
                startDate = value;
            }
        }

        public DateTime EndDate
        {
            get
            {
                return endDate;
            }

            set
            {
                endDate = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }
    }
}
