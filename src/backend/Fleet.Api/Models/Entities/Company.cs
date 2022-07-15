namespace Fleet.Api.Models.Entities
{
    public class Company: BaseEntity
	{
        public string Name { get; set; }
        public IEnumerable<Vehicle> Fleet { get; set; }
    }
}
