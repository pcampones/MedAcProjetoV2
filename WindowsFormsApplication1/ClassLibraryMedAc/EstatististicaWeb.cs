using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMedAc
{
    [DataContract]

    public class EstatisticasWeb
    {
        [DataMember]
        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        [DataMember]
        private DateTime startDate;

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        [DataMember]
        private DateTime endDate;

        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }


        }
        [DataMember]
        private int valorMin;

        public int ValorMin
        {
            get { return valorMin; }
            set { valorMin = value; }
        }

        [DataMember]
        private int valorMax;

        public int ValorMax
        {
            get { return valorMax; }
            set { valorMax = value; }
        }

        [DataMember]
        private double valorMed;

        public double ValorMed
        {
            get { return valorMed; }
            set { valorMed = value; }
        }
    }

    //public class EstatisticasWeb
    //{

    //    private string tipo;

    //    public string Tipo
    //    {
    //        get { return tipo; }
    //        set { tipo = value; }
    //    }


    //    private DateTime startDate;

    //    public DateTime StartDate
    //    {
    //        get { return startDate; }
    //        set { startDate = value; }
    //    }


    //    private string endDate;

    //    public string EndDate
    //    {
    //        get { return endDate; }
    //        set { endDate = value; }


    //    }

    //    private int valorMin;

    //    public int ValorMin
    //    {
    //        get { return valorMin; }
    //        set { valorMin = value; }
    //    }


    //    private int valorMax;

    //    public int ValorMax
    //    {
    //        get { return valorMax; }
    //        set { valorMax = value; }
    //    }


    //    private int valorMed;

    //    public int ValorMed
    //    {
    //        get { return valorMed; }
    //        set { valorMed = value; }
    //    }
    //}
}
