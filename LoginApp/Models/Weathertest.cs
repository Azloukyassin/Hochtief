//------------------------------------------------------------------------------
// <auto-generated>
//    Dieser Code wurde aus einer Vorlage generiert.
//
//    Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten Ihrer Anwendung.
//    Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoginApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public partial class Weathertest
    {
        [Required(ErrorMessage = "This Field is Required please")]
        public int weather_id {get; set;}
        [Required(ErrorMessage = "This Field is Required please")]
        [DataType(DataType.Time)]
        public string Temp_Time {get; set;}
        [Required(ErrorMessage = "This Field is Required please")]
        public string Temp {get; set;}
        [Required(ErrorMessage = "This Field is Required please")]
        public string Temp_condition {get; set;}
    }
}
