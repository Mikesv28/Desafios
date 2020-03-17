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
    public class TaskPage : PageBase
    {
        #region Mapping
        By infoTaskAtribuido = By.Id("handler_id_filter_target");
        By infoTaskRelatado = By.Id("reporter_id_filter_target");
        By infoTaskResolvido = By.XPath("//*[@id='buglist']/tbody/tr/td[9]/div/span");
        By infoTaskModificadoRecentemente = By.Id("do_filter_by_last_updated_date_filter_target");
        By infoTaskMonitorado = By.Id("user_monitor_filter_target");

        #endregion

        #region Actions
        public string RetornaInfoTaskAtribuido()
        {
            return GetText(infoTaskAtribuido);
        }

        public string RetornaInfoTaskRelatado()
        {
            return GetText(infoTaskRelatado);
        }

        public string RetornaInfoTaskResolvido()
        {
            return GetText(infoTaskResolvido);
        }

        public string RetornaInfoTaskModificadoRecentemente()
        {
            return GetText(infoTaskModificadoRecentemente);
        }

        public string RetornaInfoTaskMonitorado()
        {
            return GetText(infoTaskMonitorado);
        }
        #endregion
    }
}