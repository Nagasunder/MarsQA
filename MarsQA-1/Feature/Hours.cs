using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class Hours
    {
        [Given(@"Click on edit icon to select Hours option")]
        public void GivenClickOnEditIconToSelectHoursOption()
        {
            Driver.driver.FindElement(By.XPath("//*[@class='ui list']/div[3]/div/span/i")).Click();
        }

        [Given(@"Select option from hours drop down")]
        public void GivenSelectOptionFromHoursDropDown()
        {
            Driver.driver.FindElement(By.XPath("//*[@class='right floated content']/span/select/option[4]")).Click();
        }

    }
}
