namespace SalesOrderManager.Shared.Models
{
    public class Order : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public List<Window> Windows { get; set; }

    }
}

