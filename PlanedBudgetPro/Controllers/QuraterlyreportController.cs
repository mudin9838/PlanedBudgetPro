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
    public class QuraterlyreportController : Controller
    {

        // GET: Yearlyreport
        public ActionResult Index()
        {
            string ssrsUrl = ConfigurationManager.AppSettings["SSRSReportsUrl"].ToString();
            ReportViewer reportViewer = new ReportViewer
            {

                ProcessingMode = ProcessingMode.Remote,
                SizeToReportContent = true,
                Width = Unit.Percentage(500),
                Height = Unit.Percentage(900),
                AsyncRendering = false
            };
            reportViewer.ServerReport.ReportServerUrl = new Uri(ssrsUrl);
            reportViewer.ServerReport.ReportPath = "/planreport/የሩብ ዓመት ሪፖርት";
            ViewBag.ReportViewer = reportViewer;
            return View();

        }


    }
}