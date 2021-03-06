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
    
    public partial class tbl_VehicleInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_VehicleInfo()
        {
            this.tbl_Policies = new HashSet<tbl_Policies>();
            this.tbl_RenewPolicies = new HashSet<tbl_RenewPolicies>();
        }
    
        public int Id { get; set; }
        public string Vehicle_Type { get; set; }
        public string Manufacturer { get; set; }
        public string Veh_Model { get; set; }
        public string Driving_Licence { get; set; }
        public System.DateTime Purchase_Date { get; set; }
        public string Registration_Number { get; set; }
        public string Engine_No { get; set; }
        public string ChasisNo { get; set; }
        public Nullable<int> Cust_Id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Policies> tbl_Policies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_RenewPolicies> tbl_RenewPolicies { get; set; }
        public virtual tbl_User tbl_User { get; set; }
        public virtual tbl_Vehicle_Price tbl_Vehicle_Price { get; set; }
    }
}
