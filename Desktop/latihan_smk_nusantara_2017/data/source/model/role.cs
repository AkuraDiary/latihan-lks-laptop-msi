//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace latihan_smk_nusantara_2017.data.source.model
{
    using System;
    using System.Collections.Generic;
    
    public partial class role
    {
        public role()
        {
            this.users = new HashSet<user>();
        }
    
        public int role_id { get; set; }
        public string role_name { get; set; }
    
        public virtual ICollection<user> users { get; set; }
    }
}
