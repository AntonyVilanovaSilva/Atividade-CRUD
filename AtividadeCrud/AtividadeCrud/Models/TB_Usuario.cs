//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AtividadeCrud.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_Usuario()
        {
            this.TB_Tarefa = new HashSet<TB_Tarefa>();
        }
    
        public int IDUsu { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Tarefa> TB_Tarefa { get; set; }
    }
}
