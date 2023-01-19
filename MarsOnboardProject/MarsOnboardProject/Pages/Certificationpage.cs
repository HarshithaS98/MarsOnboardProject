using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsOnboardingProject.Utilities;

namespace MarsOnboardProject.Pages
{
    public class Certificationpage : CommonDriver
    {
        public void CreateCertification(string certificate, string Year, string From)
        {
            //Identify certification button
            IWebElement cerbutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            cerbutton.Click();
            // identify add new button
            IWebElement addCer = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            addCer.Click();

            //identify certificate or award textbox and add Istqb Certification
            IWebElement certoolbox = driver.FindElement(By.Name("certificationName"));
            certoolbox.SendKeys(From);
            // identify year dropbox and choose 2022
            IWebElement yearCer = driver.FindElement(By.Name("certificationYear"));
            //choose2022
            yearCer.Click();
            IWebElement yearofcer = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[3]"));
            yearofcer.Click();
            //identify add and save details
            IWebElement addcertificate = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
            addcertificate.Click();
        }
        public string getCertificate()// get languages table for assertion
        {
            Thread.Sleep(1500);
            IWebElement newcer = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table"));
            return newcer.GetAttribute("outerText").ToString();

        }
        public void EditCertification(string certificate, string Year, string From)
        {
            //identifycertification button
            IWebElement cereditbutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            cereditbutton.Click();
            //identify edit button
            IWebElement editcer = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[1]/i"));
            editcer.Click();
            //edit cer tool box
            IWebElement cer = driver.FindElement(By.Name("certificationName"));
            cer.Clear();
            cer.SendKeys(certificate);
            // edi from details
            IWebElement from = driver.FindElement(By.Name("certificationFrom"));
            cer.Clear();
            from.SendKeys(From);
            Thread.Sleep(700);
            SelectElement yearlevelDropdown = new SelectElement(driver.FindElement(By.Name("level")));
            yearlevelDropdown.SelectByValue(Year);
            Thread.Sleep(1000);
            //// edit year details
            //IWebElement year = driver.FindElement(By.Name("certificationYear"));
            //year.Click();
            //IWebElement yearcer = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[3]/select/option[2]"));
            //yearcer.Click();
            // click on update button
            IWebElement updatecer = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            updatecer.Click();
        }
        public void DelCertification()
        {
            //identifycertification button
            IWebElement delcerbutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            delcerbutton.Click();
            IWebElement delcer = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[2]/i"));
            delcer.Click();
        }
    }
}

