//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PlanedBudgetPro.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customerm
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customerm()
        {
            this.Orderms = new HashSet<Orderm>();
        }
    
        public System.Guid CustomerId { get; set; }
        public string ParentId { get; set; }
        public string ChildId { get; set; }
        public string FisicalYearId { get; set; }
        public string MonthId { get; set; }
        public System.DateTime OrderDate { get; set; }
        public int Id { get; set; }
    
        public virtual Child Child { get; set; }
        public virtual FisicalYear FisicalYear { get; set; }
        public virtual Month Month { get; set; }
        public virtual Parent Parent { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orderm> Orderms { get; set; }
    }
}
