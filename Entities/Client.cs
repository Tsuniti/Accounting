namespace Accounting.Entities;

public class Client
{
    public Guid Id { get; set; }
    public string Surname { get; set; }
    public string Name { get; set; }
    public decimal Balance { get; set; }
    public bool IsAdult { get; set; }

    public override string ToString() => $"{Surname} {Name}";
}
