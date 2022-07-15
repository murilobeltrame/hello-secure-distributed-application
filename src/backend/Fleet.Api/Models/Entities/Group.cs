namespace Fleet.Api.Models.Entities
{
    public class Group: BaseEntity
	{
        public string Name { get; set; }
        public IEnumerable<Company> Companies { get; set; }
    }
}
