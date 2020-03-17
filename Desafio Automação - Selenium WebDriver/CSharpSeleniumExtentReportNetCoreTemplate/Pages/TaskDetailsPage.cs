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
    public class TaskDetailsPage : PageBase
    {
        #region Mapping
        By infoTaskDetails = By.XPath("//*[@id='view-issue-details']/div/div[1]/h4");

        #endregion

        #region Actions
        public string RetornaInfoTaskDetails()
        {
            return GetText(infoTaskDetails);
        }
               
        #endregion
    }
}