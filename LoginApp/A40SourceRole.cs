//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoginApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class A40SourceRole
    {
        public int Source_id { get; set; }
        [Required(ErrorMessage = "This Field is Required please")]
        public string En_Role { get; set; }
        [Required(ErrorMessage = "This Field is Required please")]
        public string De_Role { get; set; }
        [Required(ErrorMessage = "This Field is Required please")]
        public string Code { get; set; }
        public string LoginErrorMessage { get; set; }
    }
}
