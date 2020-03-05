using CSharpSeleniumExtentReportNetCoreTemplate.Bases;
using CSharpSeleniumExtentReportNetCoreTemplate.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpSeleniumExtentReportNetCoreTemplate.Pages
{
    public class ProjectPage : PageBase
    {
        #region Mapping
        By clicarEmCasoDeTeste = By.XPath("/html/body/div/div/div[1]/div[2]/ul/li[3]/a/span");

        #endregion

        #region Actions
        public void ClicarEmCasoDeTeste()
        {
            Click(clicarEmCasoDeTeste);

        }

        public void VerificaCasoDeTeste()
        {
            IWebElement Item = DriverFactory.INSTANCE.FindElement(By.XPath(".//td[@class='sorting_1' and contains(text(),'Validar o cadastro de releases')]"));

            Assert.IsTrue(Item.Displayed);
        }
        #endregion
    }
}
