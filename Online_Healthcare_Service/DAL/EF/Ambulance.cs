//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ambulance
    {
        public int Id { get; set; }
        public string Driver_Name { get; set; }
        public string Phone { get; set; }
        public string Rent { get; set; }
        public string Status { get; set; }
        public int Hid { get; set; }
        public Nullable<int> Pid { get; set; }
    
        public virtual Patient Patient { get; set; }
    }
}
