
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace CS_project
{

using System;
    using System.Collections.Generic;
    
public partial class TB_Users
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public TB_Users()
    {

        this.TB_Tasks = new HashSet<TB_Tasks>();

    }


    public int ID { get; set; }

    public string FullName { get; set; }

    public string UserName { get; set; }

    public string Password { get; set; }

    public string State { get; set; }

    public string Role { get; set; }

    public byte[] image { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<TB_Tasks> TB_Tasks { get; set; }

}

}
