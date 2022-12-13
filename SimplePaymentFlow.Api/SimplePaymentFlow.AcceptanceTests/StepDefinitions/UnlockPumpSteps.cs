using System.Net;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using SimplePaymentFlow.AcceptanceTests.TestModels;

namespace SimplePaymentFlow.AcceptanceTests.StepDefinitions;

[Binding]
public class UnlockPumpSteps
{
    private readonly ScenarioContext _scenarioContext;
    private readonly HttpClient _client;
 
    public UnlockPumpSteps(
        WebApplicationFactory<Api.Program> simplePaymentFlowApi,
        ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
        _client = simplePaymentFlowApi.CreateClient();
    }

    [Given(@"a locked pump with name ""([^""]*)""")]
    public async Task GivenALockedPumpWithName(string? pumpName)
    {
        _scenarioContext["PumpName"] = pumpName;
        var pump = await GetPumpFromSites(pumpName);
        
        pump.Should().NotBeNull();
        pump!.Unlocked.Should().BeFalse();

        _scenarioContext["PumpId"] = pump.Id.ToString();
    }

    [When(@"a request is made to unlock the pump")]
    public async Task WhenARequestIsMadeToUnlockThePump()
    {
        var pumpId = _scenarioContext["PumpId"];
        var requestUrl = new Uri($"{_client.BaseAddress?.AbsoluteUri}pump/{pumpId}?unlocked={true}");
        var response = await _client.PutAsync(requestUrl, null);
        
        response.StatusCode.Should().Be(HttpStatusCode.NoContent);
    }

    [Then(@"the pump is unlocked")]
    public async Task ThenThePumpIsUnlocked()
    {
        var pumpName = _scenarioContext["PumpName"].ToString();
        var pump = await GetPumpFromSites(pumpName);

        pump.Should().NotBeNull();
        pump!.Id.Should().Be(_scenarioContext["PumpId"].ToString());
        pump.Unlocked.Should().BeTrue();
    }

    private async Task<TestPump?> GetPumpFromSites(string? pumpName)
    {
        var response = await _client.GetAsync("/sites");

        var responseContent = await response.Content.ReadAsStringAsync();
        var sites = JsonConvert.DeserializeObject<TestSite[]>(responseContent);

        var site = sites.Single(x =>
            x.Pump is { Name: { } }
            && x.Pump.Name.Equals(pumpName, StringComparison.OrdinalIgnoreCase));
        var pump = site.Pump;
        return pump;
    }
}