namespace SalesOrderManager.Shared.Models
{
    public class Window : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int QuantityOfWindows { get; set; }
        public int TotalSubElements { get; set; }
        public int OrderId { get; set; }
        public List<SubElement> SubElements { get; set; }

    }
}
