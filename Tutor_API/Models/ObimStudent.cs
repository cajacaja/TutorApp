//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tutor_API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ObimStudent
    {
        public int ObimStudentId { get; set; }
        public int TutorId { get; set; }
        public int TipStudentaId { get; set; }
    
        public virtual ObimStudent ObimStudent1 { get; set; }
        public virtual ObimStudent ObimStudent2 { get; set; }
        public virtual TipStudenta TipStudenta { get; set; }
        public virtual Tutor Tutor { get; set; }
    }
}
