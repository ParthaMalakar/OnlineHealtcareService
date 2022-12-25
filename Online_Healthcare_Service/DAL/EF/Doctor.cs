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
    
    public partial class Doctor
    {
        public Doctor()
        {
            this.Appointments = new HashSet<Appointment>();
            this.Prescriptions = new HashSet<Prescription>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specaility { get; set; }
        public string Visiting_Hour { get; set; }
        public int Hid { get; set; }
        public Nullable<int> Fees { get; set; }
        public string User_Type { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }
    
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual Hospital Hospital { get; set; }
        public virtual ICollection<Prescription> Prescriptions { get; set; }
    }
}
