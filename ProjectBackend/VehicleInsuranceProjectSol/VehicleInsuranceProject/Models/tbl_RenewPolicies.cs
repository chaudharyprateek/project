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
    
    public partial class tbl_RenewPolicies
    {
        public int Id { get; set; }
        public string Policy_Type { get; set; }
        public Nullable<int> Duration { get; set; }
        public Nullable<int> Veh_Id { get; set; }
        public int Policy_Amount { get; set; }
        public Nullable<System.DateTime> Policy_StartDate { get; set; }
        public Nullable<System.DateTime> Policy_Purchase_Date { get; set; }
        public Nullable<int> Total_IDV { get; set; }
        public Nullable<System.DateTime> Policy_Expiry_Date { get; set; }
        public string Approved_By { get; set; }
        public string Policy_Approve_Status { get; set; }
        public string Policy_Payment_Status { get; set; }
        public Nullable<int> previousPolicyId { get; set; }
        public Nullable<int> Cust_Id { get; set; }
    
        public virtual tbl_Policies tbl_Policies { get; set; }
        public virtual tbl_User tbl_User { get; set; }
        public virtual tbl_VehicleInfo tbl_VehicleInfo { get; set; }
    }
}
