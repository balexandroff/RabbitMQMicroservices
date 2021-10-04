namespace RabbitMQMicroservices.Banking.Domain.Models
{
    public class Account
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public decimal Ballance { get; set; }
    }
}
