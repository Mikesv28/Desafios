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
    public class ManegeEditUserPage : PageBase
    {
        #region Mapping
        By infoUsername = By.Id("edit-username");
        #endregion

        #region Actions
        public string RetornaInfoNomeUsuario()
        {
            return GetText(infoUsername);
        }
        #endregion
    }
}