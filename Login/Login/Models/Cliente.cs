//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Login.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            this.Aulas = new HashSet<Aula>();
            this.Faturas = new HashSet<Fatura>();
            this.Pedido_Aula = new HashSet<Pedido_Aula>();
        }
    
        public int ID { get; set; }
        public string Nome { get; set; }
        public System.DateTime Data_Nascimento { get; set; }
        public string Email { get; set; }
        public int Numero_Telemovel { get; set; }
        public int NIF { get; set; }
        public string Cidade { get; set; }
        public string Distrito { get; set; }
        public string Freguesia { get; set; }
        public int Porta { get; set; }
        public string Coordenadas_GPS { get; set; }
        public string Password { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Aula> Aulas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fatura> Faturas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedido_Aula> Pedido_Aula { get; set; }
    }
}
