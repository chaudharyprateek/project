//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VehicleInsuranceProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Payment
    {
        public int Id { get; set; }
        public Nullable<int> Cust_Id { get; set; }
        public Nullable<int> Pol_Id { get; set; }
        public System.DateTime Payment_Date { get; set; }
        public int Payment_Amount { get; set; }
        public string Payment_Status { get; set; }
    
        public virtual tbl_User tbl_User { get; set; }
        public virtual tbl_Policies tbl_Policies { get; set; }
    }
}
