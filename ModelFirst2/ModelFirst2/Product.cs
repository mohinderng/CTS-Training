//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModelFirst2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int Pid { get; set; }
        public string Pname { get; set; }
        public string Price { get; set; }
        public int CategoryCid { get; set; }
    
        public virtual Category Category { get; set; }
    }
}
