using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace OrangeHRMJune2020.StepDefinition
{
    [Binding]
    public class ManageAdminUserSteps
    {
        IWebDriver driver = new ChromeDriver();
        [Given(@"I login to Orange HRM portal as an administration")]
        public void GivenILoginToOrangeHRMPortalAsAnAdministration()
        {
            var loginPage = new LoginPage(driver);
            loginPage.LoginSuccess();
        }
        
        [Given(@"I navigate to systems user page")]
        public void GivenINavigateToSystemsUserPage()
        {
            var dashboardPage = new DashBoardPage(driver);
            dashboardPage.ClickUsers();
        }
        
        [Then(@"I should able to create a new user successfully")]
        public void ThenIShouldAbleToCreateANewUserSuccessfully()
        {
            var systemUsersPage = new SystemUsersPage(driver);
            systemUsersPage.ClickAdd();
            systemUsersPage.AddAndSaveUser();
            systemUsersPage.VerifyUser();
        }

        [Then(@"I should able to edit an existing user successfully")]
        public void ThenIShouldAbleToEditAnExistingUserSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should able to delete an existing user successfully")]
        public void ThenIShouldAbleToDeleteAnExistingUserSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }


    }
}
