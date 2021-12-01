using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class Availability
    {
        [Given(@"Click on edit icon to select availability option")]
        public void GivenClickOnEditIconToSelectAvailabilityOption()
        {
            Driver.driver.FindElement(By.XPath("//*[@class='right floated outline small write icon']")).Click();
        }
        
        [Given(@"Select option from drop down")]
        public void GivenSelectOptionFromDropDown()
        {
            Driver.driver.FindElement(By.XPath("//*[@class='right floated content']/span/select/option[2]")).Click();
        }
        
        [Then(@"the result get saved automatically")]
        public void ThenTheResultGetSavedAutomatically()
        {
            //ScenarioContext.Current.Pending();
        }
    }
}
