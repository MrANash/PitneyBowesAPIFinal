namespace PitneyBowesPickup
{
    internal class PickUpResponse
    {
        internal class PickupReponse
        {
            public PickUpAddress? Address { get; set; }
            public string? Carrier { get; set; }
            public PickUpSummary[]? pickupSummary { get; set; }
            public string? Reference { get; set; }
            public string? PackageLocation { get; set; }
            public string? SpecialInstructions { get; set; }
            public string? PickUpDateTime { get; set; }
            public string? PickupConfirmationNumber { get; set; }
            public string? PickupID { get; set; }
            public PickUpOptions? PickUpOptions { get; set; }
        }

        public class PickUpAddress
        {
            public string[]? AddressLines { get; set; }
            public string? CityTown { get; set; }
            public string? StateProvince { get; set; }
            public string? PostalCode { get; set; }
            public string? CountryCode { get; set; }
            public string? Phone { get; set; }
            public string? Email { get; set; }
            public bool IsResidential { get; set; }
            public string? DeliveryPoint { get; set; }
            public string? CarrierRoute { get; set; }
            public string? TaxID { get; set; }
            //public string Status { get; set; }
        }
        public class PickUpSummary
        {
            public bool ReturnShipment { get; set; }
            public TotalWeight? TotalWeight { get; set; }
            public string? ServiceID { get; set; }
            public int Count { get; set; }

        }
        public class TotalWeight
        {
            public float Weight { get; set; }
            public string? UnitOfMeasurement { get; set; }

        }
        public class PickUpOptions
        {
            public string? Name { get; set; }
            public string? Value { get; set; }
        }
    }
}



