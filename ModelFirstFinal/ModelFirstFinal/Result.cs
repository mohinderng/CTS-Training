//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModelFirstFinal
{
    using System;
    using System.Collections.Generic;
    
    public partial class Result
    {
        public int Rid { get; set; }
        public int StudentSid { get; set; }
        public int ExamEid { get; set; }
        public string Score { get; set; }

        public virtual Student Student { get; set; }
        public virtual Exam Exam { get; set; }
    }
}
