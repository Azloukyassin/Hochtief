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

    public partial class A6Labourtest
    {
        [Required(ErrorMessage = "This Field is Required please")]
        public int labour_id { get; set; }
        [Required(ErrorMessage = "This Field is Required please")]
        public string fullname { get; set; }
        [Required(ErrorMessage = "This Field is Required please")]
        public string Firstname { get; set; }
        [Required(ErrorMessage = "This Field is Required please")]
        public string Lastname { get; set; }
        [Required(ErrorMessage = "This Field is Required please")]
        public string Company { get; set; }
        [Required(ErrorMessage = "This Field is Required please")]
        public string area { get; set; }
        [Required(ErrorMessage = "This Field is Required please")]
        public string Comment { get; set; }
        [Required(ErrorMessage = "This Field is Required please")]
        public string Position { get; set; }
    }
}
