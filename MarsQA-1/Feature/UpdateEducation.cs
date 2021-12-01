using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class UpdateEducation
    {
        [Given(@"Click On Education tab")]
        public void GivenClickOnEducationTab()
        {
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]")).Click();
        }

        [Given(@"click on the edit icon")]
        public void GivenClickOnTheEditIcon()
        {
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[1]/i")).Click();
        }

        [Given(@"Clear the Current education")]
        public void GivenClearTheCurrentEducation()
        {
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[1]/input")).Clear();
        }
        
        [Given(@"Update new education")]
        public void GivenUpdateNewEducation()
        {
            Driver.driver.FindElement(By.Name("instituteName")).SendKeys("NIE");
        }

        [Given(@"Country of college / university from dropdown")]
        public void GivenCountryOfCollegeUniversityFromDropdown()
        {
            Driver.driver.FindElement(By.XPath("//*[@class='six wide field']/select/option[2]")).Click();
        }


        [Given(@"Clear the current degree")]
        public void GivenClearTheCurrentDegree()
        {
            Driver.driver.FindElement(By.Name("degree")).Clear();
        }

        [Given(@"Update new degree")]
        public void GivenUpdateNewDegree()
        {
            Driver.driver.FindElement(By.Name("degree")).SendKeys("ISE");
        }
        
        [Then(@"Click on Update education")]
        public void ThenClickOnUpdateEducation()
        {
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[3]/input[1]")).Click();
        }
    }
}
