//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab29_WebAPI_MovieDB.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Movy
    {
        public string Title { get; set; }
        public string Rating { get; set; }
        public System.TimeSpan Runtime { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }
        public int MovieID { get; set; }
    }
}