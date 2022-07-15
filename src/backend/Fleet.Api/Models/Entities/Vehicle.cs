namespace Fleet.Api.Models.Entities
{
    public class Vehicle: BaseEntity
	{
        public string LicensePlace { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public short Year { get; set; }
    }
}
