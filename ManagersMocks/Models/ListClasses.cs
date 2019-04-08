namespace ManagersModels
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Agent { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }

    public class Manager
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
    }

    public class OrderState
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class OrderSource
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Order
    {
        public int Number { get; set; }
        public string ContractNumber { get; set; }
        public string CreateDate { get; set; }
        public string CompleteDate { get; set; }
        public long ClientId { get; set; }
        public int ManagerId { get; set; }
        public int StateId { get; set; }
        public int SourceId { get; set; }
        public string Theme { get; set; }
        public string ContractDate { get; set; }
        public string AccountNumber { get; set; }
        public string DatePayment { get; set; }
        public string DateAct { get; set; }
        public double ValueAddedTax { get; set; }
        public double ContactAmount { get; set; }
        public string Comment { get; set; }
        public Client Client { get; set; }
        public Manager Manager { get; set; }
        public OrderState State { get; set; }
        public OrderSource Source { get; set; }
    }
}
