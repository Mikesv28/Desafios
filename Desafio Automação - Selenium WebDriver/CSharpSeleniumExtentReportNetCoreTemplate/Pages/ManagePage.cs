using CSharpSeleniumExtentReportNetCoreTemplate.Bases;
using CSharpSeleniumExtentReportNetCoreTemplate.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeleniumExtentReportNetCoreTemplate.Pages
{
    public class ManegePage : PageBase
    {
        #region Mapping
        By clickManegeUsers = By.XPath("/html/body/div[2]/div[2]/div[3]/div/ul/li[2]/a");
        By clickCreateNewAccount = By.XPath("//*[@id='manage-user-div']/div[1]/a");
        #endregion

        #region Actions
       
        public void ClicarEmGerenciarUsuarios()
        {
            Click(clickManegeUsers);
        }
        public void ClicarEmCriarNovaConta()
        {
            Click(clickCreateNewAccount);
        }

        #endregion
    }
}