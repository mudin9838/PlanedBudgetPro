using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;


namespace PlanedBudgetPro.Controllers
{
    public class YearlyreportController : Controller
    {

        // GET: Yearlyreport
        public ActionResult Index()
        {
            string ssrsUrl = ConfigurationManager.AppSettings["SSRSReportsUrl"].ToString();
            ReportViewer reportViewer = new ReportViewer { 
            ProcessingMode = ProcessingMode.Remote,
            SizeToReportContent = true,
            Width = Unit.Percentage(500),
            Height = Unit.Percentage(900),
            //Width = Unit.Percentage(100),
            //Height = Unit.Percentage(100),
            AsyncRendering = false
            };
            reportViewer.ServerReport.ReportServerUrl = new Uri(ssrsUrl);
            reportViewer.ServerReport.ReportPath = "/planreport/አመታዊ ሪፖርት በጥቅል";
            ViewBag.ReportViewer = reportViewer;
            return View();

        }
      
        
    }
}