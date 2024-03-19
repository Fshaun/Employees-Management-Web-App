using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EmployeesManagment.Models
{
    public class Country
    {
        [Key]

        public int Id { get; set; }

        [DisplayName("Country Code")]
        public required string CountryCode { get; set; }

        [DisplayName("Country Name")]
        public required string CountryName { get; set; }
    }
}
