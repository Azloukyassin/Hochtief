//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoginApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class UserTab
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "This Field is Required please")]
        public string Username { get; set; }
        [Required(ErrorMessage = "This Field is Required please")]
        public string Projektname { get; set; }
        [Required(ErrorMessage = "This Field is Required please")]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [Required(ErrorMessage = "This Field is Required please")]
        [DataType(DataType.Password)]
        [DisplayName("Confirm Password")]
        [Compare("password")]
        public string confrimPassword { get; set; }

        public bool isAdmin { get; set; }

        public string LoginErrorMessage { get; set; }
    }
}
