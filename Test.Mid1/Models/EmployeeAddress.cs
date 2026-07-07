using Test.Core.Models;

namespace Test.Mid1.Models
{
    public class EmployeeAddress
    {
        public Employee Employee { get; init; } = null!;
        public List<Address> Addresses { get; init; } = [];
    }
}
