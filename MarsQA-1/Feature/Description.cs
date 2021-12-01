using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class Description
    {
        [Given(@"Click on edit icon")]
        public void GivenClickOnEditIcon()
        {
            //xpath for edit button for description
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i")).Click();
        }
        
        [Given(@"Enter the description")]
        public void GivenEnterTheDescription()
        {
            //xpath for text 
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea")).SendKeys("Descriptiontext");

        }

        [Then(@"Click on save button to save the discription")]
        public void ThenClickOnSaveButtonToSaveTheDiscription()
        {
            //xpath for savebutton
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button")).Click();

        }
    }
}
