namespace SimplePaymentFlow.Api.Models;

public class Pump
{
    public Pump(string name)
    {
        Name = name;
        Id = Guid.NewGuid();
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public bool Unlocked { get; set; }
}