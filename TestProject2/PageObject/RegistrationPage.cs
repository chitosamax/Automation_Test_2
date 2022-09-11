using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestProject2.Utilities;

namespace TestProject2.PageObject
{
    class RegistrationPage
    {
        public RegistrationPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement FirstName => driver.FindElement(By.XPath("//*[@id='basicBootstrapForm']/div[1]/div[1]/input"));
        IWebElement LastName => driver.FindElement(By.XPath("//*[@id='basicBootstrapForm']/div[1]/div[2]/input"));
        IWebElement Email => driver.FindElement(By.XPath("//*[@id='eid']/input"));
        IWebElement ContactNumber => driver.FindElement(By.XPath("//*[@id='basicBootstrapForm']/div[4]/div/input"));
        IWebElement Password => driver.FindElement(By.XPath("//input[@type='password']"));
        IWebElement ConfirmPassword => driver.FindElement(By.XPath("(//input[@type='password'])[2]"));

          



        public void EnterFirstName()
        {
            FirstName.SendKeys("Samax12");
        }

        public void EnterLastName()
        {
            LastName.SendKeys("Ezeigwfre");
        }

        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://demo.automationtesting.in/Register.html");
        }

        public void EnterEmail()
        {
            Email.SendKeys("Ezei98gwe@gmail.com");
        }

        public void EnterContactNumber()
        {
            ContactNumber.SendKeys("07033880978");
        }

        public void EnterPassword()
        {
            Password.SendKeys("abbey123");
        }


     



    }
}
