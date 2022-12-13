Feature: Find a Site

Find a site to buy some petrol. 

Scenario: Get sites endpoint returns a list of all sites
	Given the list sites endpoint is running
	When I request a list of sites 	
	Then the following sites are listed:
	| Site Name                   | Site Address                                |
	| Dyno Fuels                  | 44 North Road, WATFORD,WD76 8MT             |
	| World Central Fuel          | 787 New Road, GLASGOW, G42 3YP              |
	| Universal Power             | 26 Richmond Road, HULL, HU30 0NR            |
	| ACE Pumps                   | 8 Park Road, WORCESTER, WR1 3GA             |
	| Turbo Car Food              | 19 Kingsway, KINGSTON UPON THAMES, KT36 7XC |
	| Tech for Motors             | 44 Springfield Road, DARLINGTON, DL69 0NB   |
	| Grand Fuels                 | 9872 York Road, SOUTH WEST LONDON, SW62 3AP |
	| Smart 2000 Petroleum        | 994 Chester Road, DERBY, DE47 9NM           |
	| Power Sol                   | 81 North Street, TORQUAY, TQ60 8MT          |
	| Pro Power Fuels             | 9497 Church Lane, WOLVERHAMPTON, WV14 4JM   |
	| Synergy Studio              | 91 The Grove, LERWICK, ZE85 6PD             |
	| Team Petroleum              | 88 Mill Lane, NEWPORT, NP27 9HW             |
	| Digital 4 Auto              | 12 Grange Road, PERTH, PH63 0TD             |
	| Z Future Fuel               | 50 Church Road, CANTERBURY, CT40 8IH        |
	| Infinite Stream Pumped Fuel | 86 Kings Road, PETERBOROUGH, PE81 6YX       |
	| System Tech Fuels           | 25 King Street, WEST LONDON, W15 1ED        |
	| Quality Essence Petrol      | 54 West Street, PRESTON, PR65 6TQ           |
	| Supreme Primo               | 48 Queensway, WALSALL, WS54 5RN             |
	| Dyno Magic Combustibles     | 9101 New Street, PORTSMOUTH, PO24 6PZ       |
	| Energy Extra                | 91 George Street, CREWE, CW67 7KW           |
