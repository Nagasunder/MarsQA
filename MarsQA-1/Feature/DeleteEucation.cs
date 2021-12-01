using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class DeleteEucation
    {

        [Given(@"click on delete icon")]
        public void GivenClickOnDeleteIcon()
        {
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[2]/i")).Click();
        }

        
        [Then(@"Education will be deleted")]
        public void ThenEducationWillBeDeleted()
        {
           // ScenarioContext.Current.Pending();
        }
    }
}
