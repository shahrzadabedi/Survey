//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Survey.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Survey_Q_User
    {
        public int Id { get; set; }
        public short QId { get; set; }
        public string QDesc { get; set; }
        public short Score { get; set; }
        public int FK_SurveyId { get; set; }
        public int FK_Survey_User { get; set; }
    
        public virtual User_Survey User_Survey { get; set; }
        public virtual Survey Survey { get; set; }
    }
}
