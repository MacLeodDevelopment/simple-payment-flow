using SimplePaymentFlow.Api.Commands;
using SimplePaymentFlow.Api.Infrastructure;

namespace SimplePaymentFlow.Api.Handlers;

internal class PumpCommandHandler
{
    public Task Handle(TogglePumpLockCommand togglePumpLockCommand)
    {
        StaticPumpStore.UpdatePumpLock(togglePumpLockCommand);
        StaticSiteStore.RefreshSites();

        return Task.CompletedTask;
    }
}