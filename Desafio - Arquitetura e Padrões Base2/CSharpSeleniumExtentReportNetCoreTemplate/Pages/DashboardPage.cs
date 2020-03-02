using CSharpSeleniumExtentReportNetCoreTemplate.Bases;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeleniumExtentReportNetCoreTemplate.Pages
{
    
    public class DashboardPage : PageBase
    {
       
        #region Mapping
            
        By clicarEmProjetos = By.XPath("/html/body/div/nav/div[2]/div/ul/a[2]/li/div/i");

        #endregion

        public void ClicarEmProjetos()
        {
            Click(clicarEmProjetos);
        }

        public void AguardaProjetos()
        {
            WaitForElement(By.XPath("/html/body/div/nav/div[2]/div/ul/a[2]/li/div/i"));
        }
    }
}
