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
    
    public partial class Customerdf
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customerdf()
        {
            this.Orderfds = new HashSet<Orderfd>();
        }
    
        public System.Guid CustomerId { get; set; }
        public string ParentId { get; set; }
        public string ChildId { get; set; }
        public string FisicalYearId { get; set; }
        public string MonthId { get; set; }
        public System.DateTime OrderDate { get; set; }
        public int Id { get; set; }
    
        public virtual Childf Childf { get; set; }
        public virtual FisicalYear FisicalYear { get; set; }
        public virtual Month Month { get; set; }
        public virtual Parentf Parentf { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orderfd> Orderfds { get; set; }
    }
}
