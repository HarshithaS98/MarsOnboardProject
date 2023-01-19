using MarsOnboardingProject.Utilities;
using MarsOnboardProject.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Reflection.Emit;
using TechTalk.SpecFlow;

namespace MarsOnboardProject.Stepdefinition
{
    [Binding]
    public class ProfileFeatureStepDefinitions : CommonDriver
    {
        loginpPage loginPageObj = new loginpPage();
        LanguagePage LanguagePageObj = new LanguagePage();
        skillsPage skillsPageObj = new skillsPage();
        Certificationpage certificationObj = new Certificationpage();
        [Given(@"I logged into Mars page successfully")]
        public void GivenILoggedIntoMarsPageSuccessfully()
        {
            driver = new ChromeDriver();

            loginPageObj.loginActions();
        }

        [When(@"I navigated to profile pages")]
        public void WhenINavigatedToProfilePages()
        {
            loginPageObj.loginActions();
        }

        [Given(@"Added '([^']*)' and '([^']*)' to the languages")]
        public void GivenAddedAndToTheLanguages(string english, string fluent)
        {
            LanguagePageObj.Createlanguage(english, fluent);
        }

        [Then(@"the '([^']*)' and '([^']*)' created  successfully")]
        public void ThenTheAndCreatedSuccessfully(string english, string fluent)
        {

            string createlanguage = LanguagePageObj.getlanguage();
            string createlanguagelevel = LanguagePageObj.getlanguage();

            Assert.That(createlanguage.Contains(english), "created language and expected language do NotFiniteNumberException match");
            Assert.That(createlanguagelevel.Contains(fluent), "chosen level and expected level do not match");
            driver.Quit();
        }

        [Given(@"edited '([^']*)' and '([^']*)' to the languages")]
        public void GivenEditedAndToTheLanguages(string hindi, string conversational)
        {
            LanguagePageObj.EditLanguage(hindi, conversational);
        }

        [Then(@"the '([^']*)' and '([^']*)'  edited successfully")]
        public void ThenTheAndEditedSuccessfully(string hindi, string conversational)
        {
            string editlanguage = LanguagePageObj.getlanguage();
            string editlanguagelevel = LanguagePageObj.getlanguage();

            Assert.That(editlanguage.Contains(hindi), "edited language and expected language do Not match");
            Assert.That(editlanguagelevel.Contains(conversational), "edited chosen level and expected level do not match");
            driver.Quit();
        }

        [Given(@"Deleted '([^']*)' and '([^']*)' in the language")]
        public void GivenDeletedAndInTheLanguage(string language, string level)
        {
            LanguagePageObj.DelLanguage();
        }

        [Then(@"the '([^']*)' and '([^']*)'  deleted successfully")]
        public void ThenTheAndDeletedSuccessfully(string language, string level)
        {
            string deletelanguage = LanguagePageObj.getlanguage();

            Assert.That(deletelanguage != "language", "edited language and expected language do Not match");
        }

        [Given(@"When Added '([^']*)' and '([^']*)' to the skills")]
        public void GivenWhenAddedAndToTheSkills(string p0, string skilllevel)
        {
            skillsPageObj.Createskill(p0, skilllevel);
        }

        [Then(@"'([^']*)' and '([^']*)'  created successfully")]
        public void ThenAndCreatedSuccessfully(string p0, string skilllevel)
        {
            string createskil = skillsPageObj.getskill();
            string createskillevel = skillsPageObj.getskill();

            Assert.That(createskil.Contains(p0), "created skill and expected skill do not match");
            Assert.That(createskillevel.Contains(skilllevel), "chosen skill level and expected level do not match");
        }

        [Given(@"edited '([^']*)' and '([^']*)' to the skills")]
        public void GivenEditedAndToTheSkills(string skill, string skilllevel)
        {
            skillsPageObj.Editskill(skill, skilllevel);
        }

        [Then(@"'([^']*)' and '([^']*)'  edited successfully")]
        public void ThenAndEditedSuccessfully(string skill, string skilllevel)
        {
            string editskil = skillsPageObj.getskill();
            string editskillevel = skillsPageObj.getskill();

            Assert.That(editskil.Contains(skill), "edited skill and expected skill do not match");
            Assert.That(editskillevel.Contains(skilllevel), "chosen edited skill level and expected level"
        }

        [Given(@"Deleted '([^']*)' and '([^']*)' in the skills")]
        public void GivenDeletedAndInTheSkills(string skill, string skilllevel)
        {
            skillsPageObj.Delskill();
        }

        [Then(@"'([^']*)' and '([^']*)'  deleted successfully")]
        public void ThenAndDeletedSuccessfully(string skill, string skilllevel)
        {
            string deleskil = skillsPageObj.getskill();
            Assert.That(deleskil != "skill", "edited skill and expected skill do Not match");
            driver.Quit();
        }

        [Given(@"When Added '([^']*)' and '([^']*)' and '([^']*)'  to the Certifications")]
        public void GivenWhenAddedAndAndToTheCertifications(string p0, string p1, string p2)
        {
            certificationObj.CreateCertification(p0, p1, p2);
        }

        [Then(@"t '([^']*)' and '([^']*)' and '([^']*)'  created successfully")]
        public void ThenTAndAndCreatedSuccessfully(string p0, string p1, string p2)
        {
            string createcert = certificationObj.getCertificate();
            string createcerfrom = certificationObj.getCertificate();
            string createceryear = certificationObj.getCertificate();

            Assert.That(createcert.Contains(p0), "created certificate and expected skill do not match");
            Assert.That(createcerfrom.Contains(p1), "chosen certification from and expected value do not match");
            Assert.That(createceryear.Contains(p2), "chosen certification year  and expected value do not match");
        }

        [Given(@"edited '([^']*)' and '([^']*)' and '([^']*)'  to the Certifications")]
        public void GivenEditedAndAndToTheCertifications(string p0, string p1, string p2)
        {
            certificationObj.EditCertification(p0, p1, p2);
        }

        [Then(@"the '([^']*)' and '([^']*)' and '([^']*)'  to the Certifications edited successfully")]
        public void ThenTheAndAndToTheCertificationsEditedSuccessfully(string p0, string p1, string p2)
        {

            string editcert = certificationObj.getCertificate();
            string editcerfrom = certificationObj.getCertificate();
            string editceryear = certificationObj.getCertificate();

            Assert.That(editcert.Contains(p0), "edited certificate and expected skill do not match");
            Assert.That(editcerfrom.Contains(p1), "chosen edited certification from and expected value do not match");
            Assert.That(editceryear.Contains(p2), "chosen edited certification year  and expected value do not match");
        }

        [Given(@"Deleted '([^']*)', '([^']*)' , '([^']*)'  to the Certifications")]
        public void GivenDeletedToTheCertifications(string certificate, string year, string from)
        {
            certificationObj.DelCertification();
        }

        [Then(@"the '([^']*)' , '([^']*)' , '([^']*)'  to the Certifications  deleted successfully")]
        public void ThenTheToTheCertificationsDeletedSuccessfully(string certificate, string year, string from)
        {
            string delcert = certificationObj.getCertificate();
            Assert.That(delcert != "skill", "edited skill and expected skill do Not match");
            driver.Quit();
        }
    }
}
