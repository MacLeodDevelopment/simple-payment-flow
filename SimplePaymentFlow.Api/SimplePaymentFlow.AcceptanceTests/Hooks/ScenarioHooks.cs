using BoDi;
using Microsoft.AspNetCore.Mvc.Testing;

namespace SimplePaymentFlow.AcceptanceTests.Hooks
{
    [Binding]
    public class ScenarioHooks
    {
        private readonly IObjectContainer _container;

        public ScenarioHooks(IObjectContainer container)
        {
            _container = container;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            var simplePaymentFlowApi = new WebApplicationFactory<Api.Program>();
            _container.RegisterInstanceAs(simplePaymentFlowApi);
        }
    }
}