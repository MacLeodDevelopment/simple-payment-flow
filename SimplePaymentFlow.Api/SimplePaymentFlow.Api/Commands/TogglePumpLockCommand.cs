namespace SimplePaymentFlow.Api.Commands;

internal class TogglePumpLockCommand
{
    public TogglePumpLockCommand(Guid pumpId, bool unlocked)
    {
        PumpId = pumpId;
        Unlocked = unlocked;
    }

    public Guid PumpId { get; set; }
    public bool Unlocked { get; set; }
}