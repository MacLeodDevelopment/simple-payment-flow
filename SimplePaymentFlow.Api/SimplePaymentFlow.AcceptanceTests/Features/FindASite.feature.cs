// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SimplePaymentFlow.AcceptanceTests.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Find a Site")]
    public partial class FindASiteFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "FindASite.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Find a Site", "Find a site to buy some petrol. ", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get sites endpoint returns a list of all sites")]
        public virtual void GetSitesEndpointReturnsAListOfAllSites()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get sites endpoint returns a list of all sites", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 5
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
 testRunner.Given("the list sites endpoint is running", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 7
 testRunner.When("I request a list of sites", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                            "Site Name",
                            "Site Address"});
                table1.AddRow(new string[] {
                            "Dyno Fuels",
                            "44 North Road, WATFORD,WD76 8MT"});
                table1.AddRow(new string[] {
                            "World Central Fuel",
                            "787 New Road, GLASGOW, G42 3YP"});
                table1.AddRow(new string[] {
                            "Universal Power",
                            "26 Richmond Road, HULL, HU30 0NR"});
                table1.AddRow(new string[] {
                            "ACE Pumps",
                            "8 Park Road, WORCESTER, WR1 3GA"});
                table1.AddRow(new string[] {
                            "Turbo Car Food",
                            "19 Kingsway, KINGSTON UPON THAMES, KT36 7XC"});
                table1.AddRow(new string[] {
                            "Tech for Motors",
                            "44 Springfield Road, DARLINGTON, DL69 0NB"});
                table1.AddRow(new string[] {
                            "Grand Fuels",
                            "9872 York Road, SOUTH WEST LONDON, SW62 3AP"});
                table1.AddRow(new string[] {
                            "Smart 2000 Petroleum",
                            "994 Chester Road, DERBY, DE47 9NM"});
                table1.AddRow(new string[] {
                            "Power Sol",
                            "81 North Street, TORQUAY, TQ60 8MT"});
                table1.AddRow(new string[] {
                            "Pro Power Fuels",
                            "9497 Church Lane, WOLVERHAMPTON, WV14 4JM"});
                table1.AddRow(new string[] {
                            "Synergy Studio",
                            "91 The Grove, LERWICK, ZE85 6PD"});
                table1.AddRow(new string[] {
                            "Team Petroleum",
                            "88 Mill Lane, NEWPORT, NP27 9HW"});
                table1.AddRow(new string[] {
                            "Digital 4 Auto",
                            "12 Grange Road, PERTH, PH63 0TD"});
                table1.AddRow(new string[] {
                            "Z Future Fuel",
                            "50 Church Road, CANTERBURY, CT40 8IH"});
                table1.AddRow(new string[] {
                            "Infinite Stream Pumped Fuel",
                            "86 Kings Road, PETERBOROUGH, PE81 6YX"});
                table1.AddRow(new string[] {
                            "System Tech Fuels",
                            "25 King Street, WEST LONDON, W15 1ED"});
                table1.AddRow(new string[] {
                            "Quality Essence Petrol",
                            "54 West Street, PRESTON, PR65 6TQ"});
                table1.AddRow(new string[] {
                            "Supreme Primo",
                            "48 Queensway, WALSALL, WS54 5RN"});
                table1.AddRow(new string[] {
                            "Dyno Magic Combustibles",
                            "9101 New Street, PORTSMOUTH, PO24 6PZ"});
                table1.AddRow(new string[] {
                            "Energy Extra",
                            "91 George Street, CREWE, CW67 7KW"});
#line 8
 testRunner.Then("the following sites are listed:", ((string)(null)), table1, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
