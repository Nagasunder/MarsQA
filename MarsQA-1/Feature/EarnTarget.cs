using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class EarnTarget
    {
        [Given(@"Click on edit icon to select EarnTarget option")]
        public void GivenClickOnEditIconToSelectEarnTargetOption()
        {
            Driver.driver.FindElement(By.XPath("//*[@class='right floated outline small write icon']")).Click();
        }
        
        [Given(@"Select option from EarnTarget drop down")]
        public void GivenSelectOptionFromEarnTargetDropDown()
        {
            Driver.driver.FindElement(By.XPath("//*[@class='right floated content']/span/select/option[2]")).Click();
        }
        
        [Then(@"the result get saved automaticallys")]
        public void ThenTheResultGetSavedAutomaticallys()
        {
            //ScenarioContext.Current.Pending();
        }
    }
}
