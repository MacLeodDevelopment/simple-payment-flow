using SimplePaymentFlow.Api.Models;

namespace SimplePaymentFlow.Api.Infrastructure;

/// <summary>
/// In-memory store of Sites.
/// </summary>
/// <remarks>
/// It is assumed that for the purposes of this test a site
/// has a single pump and that this is sufficient.
/// An in-memory store is deemed suitable for the purposes of this technical test,
/// as no data storage is required. 
/// </remarks>
public class StaticSiteStore
{
    private static IEnumerable<Site>? _sites;

    public StaticSiteStore()
    {
        _sites = RefreshSites();
    }

    public static IEnumerable<Site> Sites => _sites ??= RefreshSites();

    /// <summary>
    /// Loads the sites into memory.
    /// </summary>
    /// <remarks>
    /// Gets the current version of the site's pump from the site data store.
    /// This is built to emulate retrieving the sites from a database. 
    /// </remarks>
    internal static IEnumerable<Site> RefreshSites()
    {
        return new List<Site>
        {
            new()
            {
                Name = "Dyno Fuels",
                Address = "44 North Road, WATFORD,WD76 8MT",
                Pump = StaticPumpStore.Pumps.Single(p => p.Name.Equals("Pump 01", StringComparison.OrdinalIgnoreCase))
            },
            new()
            {
                Name = "World Central Fuel",
                Address = "787 New Road, GLASGOW, G42 3YP",
                Pump = StaticPumpStore.Pumps.Single(p => p.Name.Equals("Pump 02", StringComparison.OrdinalIgnoreCase))
            },
            new()
            {
                Name = "Universal Power",
                Address = "26 Richmond Road, HULL, HU30 0NR",
                Pump = StaticPumpStore.Pumps.Single(p => p.Name.Equals("Pump 03", StringComparison.OrdinalIgnoreCase))
            },
            new()
            {
                Name = "ACE Pumps",
                Address = "8 Park Road, WORCESTER, WR1 3GA",
                Pump = StaticPumpStore.Pumps.Single(p => p.Name.Equals("Pump 04", StringComparison.OrdinalIgnoreCase))
            },
            new() {
                Name = "Turbo Car Food",
                Address = "19 Kingsway, KINGSTON UPON THAMES, KT36 7XC",
                Pump = StaticPumpStore.Pumps.Single(p => p.Name.Equals("Pump 05", StringComparison.OrdinalIgnoreCase))
            },
            new()
            {
                Name = "Tech for Motors",
                Address = "44 Springfield Road, DARLINGTON, DL69 0NB",
                Pump = StaticPumpStore.Pumps.Single(p => p.Name.Equals("Pump 06", StringComparison.OrdinalIgnoreCase))
            },
            new()
            {
                Name = "Grand Fuels",
                Address = "9872 York Road, SOUTH WEST LONDON, SW62 3AP",
                Pump = StaticPumpStore.Pumps.Single(p => p.Name.Equals("Pump 07", StringComparison.OrdinalIgnoreCase))
            },
            new()
            {
                Name = "Smart 2000 Petroleum",
                Address = "994 Chester Road, DERBY, DE47 9NM",
                Pump = StaticPumpStore.Pumps.Single(p => p.Name.Equals("Pump 08", StringComparison.OrdinalIgnoreCase))
            },
            new()
            {
                Name = "Power Sol",
                Address = "81 North Street, TORQUAY, TQ60 8MT",
                Pump = StaticPumpStore.Pumps.Single(p => p.Name.Equals("Pump 09", StringComparison.OrdinalIgnoreCase))
            },
            new()
            {
                Name = "Pro Power Fuels",
                Address = "9497 Church Lane, WOLVERHAMPTON, WV14 4JM",
                Pump = StaticPumpStore.Pumps.Single(p => p.Name.Equals("Pump 10", StringComparison.OrdinalIgnoreCase))
            },
            new()
            {
                Name = "Synergy Studio",
                Address = "91 The Grove, LERWICK, ZE85 6PD",
                Pump = StaticPumpStore.Pumps.Single(p => p.Name.Equals("Pump 11", StringComparison.OrdinalIgnoreCase))
            },
            new()
            {
                Name = "Team Petroleum",
                Address = "88 Mill Lane, NEWPORT, NP27 9HW",
                Pump = StaticPumpStore.Pumps.Single(p => p.Name.Equals("Pump 12", StringComparison.OrdinalIgnoreCase))
            },
            new()
            {
                Name = "Digital 4 Auto",
                Address = "12 Grange Road, PERTH, PH63 0TD",
                Pump = StaticPumpStore.Pumps.Single(p => p.Name.Equals("Pump 13", StringComparison.OrdinalIgnoreCase))
            },
            new()
            {
                Name = "Z Future Fuel",
                Address = "50 Church Road, CANTERBURY, CT40 8IH",
                Pump = StaticPumpStore.Pumps.Single(p => p.Name.Equals("Pump 14", StringComparison.OrdinalIgnoreCase))
            },
            new()
            {
                Name = "Infinite Stream Pumped Fuel",
                Address = "86 Kings Road, PETERBOROUGH, PE81 6YX",
                Pump = StaticPumpStore.Pumps.Single(p => p.Name.Equals("Pump 15", StringComparison.OrdinalIgnoreCase))
            },
            new()
            {
                Name = "System Tech Fuels",
                Address = "25 King Street, WEST LONDON, W15 1ED",
                Pump = StaticPumpStore.Pumps.Single(p => p.Name.Equals("Pump 16", StringComparison.OrdinalIgnoreCase))
            },
            new()
            {
                Name = "Quality Essence Petrol",
                Address = "54 West Street, PRESTON, PR65 6TQ",
                Pump = StaticPumpStore.Pumps.Single(p => p.Name.Equals("Pump 17", StringComparison.OrdinalIgnoreCase))
            },
            new()
            {
                Name = "Supreme Primo",
                Address = "48 Queensway, WALSALL, WS54 5RN",
                Pump = StaticPumpStore.Pumps.Single(p => p.Name.Equals("Pump 18", StringComparison.OrdinalIgnoreCase))
            },
            new()
            {
                Name = "Dyno Magic Combustibles",
                Address = "9101 New Street, PORTSMOUTH, PO24 6PZ",
                Pump = StaticPumpStore.Pumps.Single(p => p.Name.Equals("Pump 19", StringComparison.OrdinalIgnoreCase))
            },
            new()
            {
                Name = "Energy Extra",
                Address = "91 George Street, CREWE, CW67 7KW",
                Pump = StaticPumpStore.Pumps.Single(p => p.Name.Equals("Pump 20", StringComparison.OrdinalIgnoreCase))
            }
        };
    }
}