using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EmployeesManagment.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [DisplayName("First Name")]
        [Required]
        public string FirstName { get; set; }

        [DisplayName("Middle Name")]
        [Required]
        public string MiddleName { get; set; }

        [DisplayName("Last Name")]
        [Required]
        public string LastName { get; set; }

        [DisplayName("Full Name")]
        public string FullName => $"{FirstName} {MiddleName} {LastName}";

        [DisplayName("Email Address")]
        [EmailAddress]
        [Required]
        public string EmailAddress { get; set; }

        [DisplayName("Phone Number")]
        public string PhoneNo { get; set; }

        [DisplayName("Address")]
        public string Address { get; set; }

        [DisplayName("Country")]
        public int? CountryId { get; set; }

        public Country? Country { get; set; }

        [DisplayName("County")]
        public int? CountyId { get; set; }

        public County? County { get; set; }
    }
}