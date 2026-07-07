using Test.Mid1.Enums;

namespace Test.Mid1.Models
{
    public class Address
    {
        public AddressType AddressType { get; set; }

        public string AddressLine1 { get; set; } = string.Empty;

        public string? AddressLine2 { get; set; }

        public string City { get; set; } = string.Empty;

        public string State { get; set; } = string.Empty;

        public string PostalCode { get; set; } = string.Empty;

        public string Country { get; set; } = string.Empty;
    }
}
