using System.ComponentModel.DataAnnotations;

namespace EntityCRUD.Models
{
    public class Users
    {
        [Display(Name="ID")]
        public int id { get; set; }
        [Display(Name = "Imię")]
        public string name { get; set; }
        [Display(Name = "Nazwisko")]
        public string surname { get; set; }
        [Display(Name = "E-mail")]
        public string email { get; set; }
        [Display(Name = "Miasto")]
        public string city { get; set; }
    }
}
