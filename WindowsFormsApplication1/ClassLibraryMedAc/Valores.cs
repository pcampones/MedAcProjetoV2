//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibraryMedAc
{
    using System;
    using System.Collections.Generic;
    
    public partial class Valores
    {
        public int Id { get; set; }
        public int BloodPressureMin { get; set; }
        public int HeartRate { get; set; }
        public int OxygenSaturation { get; set; }
        public System.DateTime DataOfRegist { get; set; }
        public int BloodPressureMax { get; set; }
    
        public virtual Utente Utente { get; set; }
    }
}
