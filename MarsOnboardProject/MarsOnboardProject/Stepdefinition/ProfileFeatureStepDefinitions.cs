using MarsOnboardingProject.Utilities;
using MarsOnboardProject.Pages;
using System;
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
            throw new PendingStepException();
        }

        [When(@"I navigated to profile pages")]
        public void WhenINavigatedToProfilePages()
        {
            throw new PendingStepException();
        }

        [Given(@"Added '([^']*)' and '([^']*)' to the languages")]
        public void GivenAddedAndToTheLanguages(string english, string fluent)
        {
            throw new PendingStepException();
        }

        [Then(@"the '([^']*)' and '([^']*)' created  successfully")]
        public void ThenTheAndCreatedSuccessfully(string english, string fluent)
        {
            throw new PendingStepException();
        }

        [Given(@"edited '([^']*)' and '([^']*)' to the languages")]
        public void GivenEditedAndToTheLanguages(string hindi, string conversational)
        {
            throw new PendingStepException();
        }

        [Then(@"the '([^']*)' and '([^']*)'  edited successfully")]
        public void ThenTheAndEditedSuccessfully(string hindi, string conversational)
        {
            throw new PendingStepException();
        }

        [Given(@"Deleted '([^']*)' and '([^']*)' in the language")]
        public void GivenDeletedAndInTheLanguage(string language, string level)
        {
            throw new PendingStepException();
        }

        [Then(@"the '([^']*)' and '([^']*)'  deleted successfully")]
        public void ThenTheAndDeletedSuccessfully(string language, string level)
        {
            throw new PendingStepException();
        }

        [Given(@"When Added '([^']*)' and '([^']*)' to the skills")]
        public void GivenWhenAddedAndToTheSkills(string p0, string skilllevel)
        {
            throw new PendingStepException();
        }

        [Then(@"'([^']*)' and '([^']*)'  created successfully")]
        public void ThenAndCreatedSuccessfully(string p0, string skilllevel)
        {
            throw new PendingStepException();
        }

        [Given(@"edited '([^']*)' and '([^']*)' to the skills")]
        public void GivenEditedAndToTheSkills(string skill, string skilllevel)
        {
            throw new PendingStepException();
        }

        [Then(@"'([^']*)' and '([^']*)'  edited successfully")]
        public void ThenAndEditedSuccessfully(string skill, string skilllevel)
        {
            throw new PendingStepException();
        }

        [Given(@"Deleted '([^']*)' and '([^']*)' in the skills")]
        public void GivenDeletedAndInTheSkills(string skill, string skilllevel)
        {
            throw new PendingStepException();
        }

        [Then(@"'([^']*)' and '([^']*)'  deleted successfully")]
        public void ThenAndDeletedSuccessfully(string skill, string skilllevel)
        {
            throw new PendingStepException();
        }

        [Given(@"When Added '([^']*)' and '([^']*)' and '([^']*)'  to the Certifications")]
        public void GivenWhenAddedAndAndToTheCertifications(string p0, string p1, string p2)
        {
            throw new PendingStepException();
        }

        [Then(@"t '([^']*)' and '([^']*)' and '([^']*)'  created successfully")]
        public void ThenTAndAndCreatedSuccessfully(string p0, string p1, string p2)
        {
            throw new PendingStepException();
        }

        [Given(@"edited '([^']*)' and '([^']*)' and '([^']*)'  to the Certifications")]
        public void GivenEditedAndAndToTheCertifications(string p0, string p1, string p2)
        {
            throw new PendingStepException();
        }

        [Then(@"the '([^']*)' and '([^']*)' and '([^']*)'  to the Certifications edited successfully")]
        public void ThenTheAndAndToTheCertificationsEditedSuccessfully(string p0, string p1, string p2)
        {
            throw new PendingStepException();
        }

        [Given(@"Deleted '([^']*)', '([^']*)' , '([^']*)'  to the Certifications")]
        public void GivenDeletedToTheCertifications(string certificate, string year, string from)
        {
            throw new PendingStepException();
        }

        [Then(@"the '([^']*)' , '([^']*)' , '([^']*)'  to the Certifications  deleted successfully")]
        public void ThenTheToTheCertificationsDeletedSuccessfully(string certificate, string year, string from)
        {
            throw new PendingStepException();
        }
    }
}
