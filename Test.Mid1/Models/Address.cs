using Test.Mid1.Enums;

namespace Test.Mid1.Models
{
    public class Address
    {
        public AddressType AddressType { get; init; }

        public string AddressLine1 { get; init; } = string.Empty;

        public string? AddressLine2 { get; init; }

        public string City { get; init; } = string.Empty;

        public string State { get; init; } = string.Empty;

        public string PostalCode { get; init; } = string.Empty;

        public string Country { get; init; } = string.Empty;
    }
}
