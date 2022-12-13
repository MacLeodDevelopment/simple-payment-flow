Feature: UnlockPump

Unlocking a pump 

@tag1
Scenario: Locked pump is unlocked
	Given a locked pump with name "Pump 10"
	When a request is made to unlock the pump
	Then the pump is unlocked
