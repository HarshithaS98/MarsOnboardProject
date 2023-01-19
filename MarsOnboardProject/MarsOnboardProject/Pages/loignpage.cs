using MarsOnboardingProject.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsOnboardProject.Pages
{
    public class loginpPage : CommonDriver
    {

        //static void Main() { }
        public void loginActions()
        {
            // open browser

            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
            // launch local host:5000
            driver.Navigate().GoToUrl("http://localhost:5000/Home");

            // Identify signin button
            IWebElement signinbutton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
            signinbutton.Click();

            // Identify username textbox and enter valid username
            IWebElement usernameTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            usernameTextbox.SendKeys("harshi.s98@gmail.com");

            // Identify password textbox and enter password 
            IWebElement passwordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            passwordTextbox.SendKeys("harshitha4");

            //Identify login button
            IWebElement loginbutton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginbutton.Click();
            // check if user has logged in successfully
        }
    }
}
}
