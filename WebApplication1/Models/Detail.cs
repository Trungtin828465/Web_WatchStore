//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Detail
    {
        public int ID_Detail { get; set; }
        public int ProductID { get; set; }
        public string Waterproof { get; set; }
        public string Origin { get; set; }
        public string GlassMaterial { get; set; }
        public string Material { get; set; }
        public string Thickness { get; set; }
        public string FaceSize { get; set; }
        public string Typeof { get; set; }
        public string GenderObject { get; set; }
    
        public virtual Product Product { get; set; }
    }
}