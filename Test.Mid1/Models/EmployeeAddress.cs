using Test.Core.Models;

namespace Test.Mid1.Models
{
    public class EmployeeAddress
    {
        public Employee Employee { get; set; } = null!;
        public List<Address> Addresses { get; set; } = [];
    }
}
