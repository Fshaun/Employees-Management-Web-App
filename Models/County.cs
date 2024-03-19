using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EmployeesManagment.Models
{
    public class County
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("County Code")]
        public required string CountyCode { get; set; }

        [DisplayName("County Name")]
        public required string CountyName { get; set; }
    }
}
