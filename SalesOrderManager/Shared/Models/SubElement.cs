namespace SalesOrderManager.Shared.Models
{
    public class SubElement : IEntity
    {
        public int Id { get; set; }
        public int Element { get; set; }
        public string Type { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int WindowId { get; set; }

    }

}
