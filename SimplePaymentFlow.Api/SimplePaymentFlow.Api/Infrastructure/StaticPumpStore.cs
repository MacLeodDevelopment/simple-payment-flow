using SimplePaymentFlow.Api.Commands;
using SimplePaymentFlow.Api.Models;

namespace SimplePaymentFlow.Api.Infrastructure;

/// <summary>
/// In-memory store of pumps.
/// </summary>
/// <remarks>
/// This is deemed suitable for the purposes of this technical test,
/// as no data storage is required. 
/// </remarks>
public class StaticPumpStore
{
    private static List<Pump>? _pumps;

    public StaticPumpStore()
    {
        _pumps = RefreshPumps();
    }

    public static IEnumerable<Pump> Pumps => _pumps ??= RefreshPumps();
    
    private static List<Pump> RefreshPumps()
    {
        return new List<Pump>
        {
            new("Pump 01"),
            new("Pump 02"),
            new("Pump 03"),
            new("Pump 04"),
            new("Pump 05"),
            new("Pump 06"),
            new("Pump 07"),
            new("Pump 08"),
            new("Pump 09"),
            new("Pump 10"),
            new("Pump 11"),
            new("Pump 12"),
            new("Pump 13"),
            new("Pump 14"),
            new("Pump 15"),
            new("Pump 16"),
            new("Pump 17"),
            new("Pump 18"),
            new("Pump 19"),
            new("Pump 20")
        };
    }

    internal static void UpdatePumpLock(TogglePumpLockCommand togglePumpLockCommand)
    {
        Pumps.Single(p => p.Id == togglePumpLockCommand.PumpId).Unlocked = togglePumpLockCommand.Unlocked;
    }
}