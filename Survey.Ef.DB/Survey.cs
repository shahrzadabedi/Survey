//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Survey.Ef.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Survey
    {
        public Survey()
        {
            this.Survey_Q_User = new HashSet<Survey_Q_User>();
            this.User_Survey = new HashSet<User_Survey>();
        }
    
        public int Id { get; set; }
        public int Duration { get; set; }
        public Nullable<short> QCount { get; set; }
        public string CreatorUserName { get; set; }
        public int State { get; set; }
        public System.DateTime CreateDateTime { get; set; }
        public string Q1 { get; set; }
        public string Q2 { get; set; }
        public string Q3 { get; set; }
        public string Q4 { get; set; }
        public string Q5 { get; set; }
        public string Q6 { get; set; }
        public string Q7 { get; set; }
        public string Q8 { get; set; }
        public string Q9 { get; set; }
        public string Q10 { get; set; }
    
        public virtual ICollection<Survey_Q_User> Survey_Q_User { get; set; }
        public virtual ICollection<User_Survey> User_Survey { get; set; }
    }
}