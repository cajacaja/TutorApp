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
    
    public partial class OcjenaTutor
    {
        public int OcjenaTutorId { get; set; }
        public int Ocjena { get; set; }
        public System.DateTime Datum { get; set; }
        public string Komentar { get; set; }
        public int TutorId { get; set; }
        public int StudentId { get; set; }
    
        public virtual Student Student { get; set; }
        public virtual Tutor Tutor { get; set; }
    }
}
