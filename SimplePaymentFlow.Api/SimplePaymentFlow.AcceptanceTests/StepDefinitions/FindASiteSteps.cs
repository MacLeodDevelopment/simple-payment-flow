using System.Net;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using SimplePaymentFlow.AcceptanceTests.TestModels;

namespace SimplePaymentFlow.AcceptanceTests.StepDefinitions
{
    [Binding]
    public sealed class FindASiteSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly HttpClient _client;
        
        public FindASiteSteps(
            WebApplicationFactory<Api.Program> simplePaymentFlowApi,
            ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _client = simplePaymentFlowApi.CreateClient();
        }

        [Given(@"the list sites endpoint is running")]
        public async Task GivenTheListSitesEndpointIsRunning()
        {
            var response = await _client.GetAsync("/sites");
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [When(@"I request a list of sites")]
        public async Task WhenIRequestAListOfSites()
        {
            var response = await _client.GetAsync("/sites");

            var responseContent = await response.Content.ReadAsStringAsync();
            var sites = JsonConvert.DeserializeObject<TestSite[]>(responseContent);
            
            _scenarioContext["Sites"] = sites;
        }

        [Then(@"the following sites are listed:")]
        public void ThenTheFollowingSitesAreListed(Table table)
        {
            var sites = _scenarioContext["Sites"] as TestSite[] ?? Array.Empty<TestSite>();

            sites.Length.Should().Be(20);

            foreach (var row in table.Rows)
            {
                sites.Should().Contain(x => x.Name == row["Site Name"]);
                sites.Should().Contain(x => x.Address == row["Site Address"]);
            }
        }
    }
}