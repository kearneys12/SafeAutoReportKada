using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SafeAutoKada.Model;
using SafeAutoKada.DAO;

namespace SafeAutoKada.Controllers
{
   
    [ApiController]
    [Route("[controller]")]
    public class GetReportController : ControllerBase
    {
        private readonly IGetReportDAO GetReportDAO;

        public GetReportController(IGetReportDAO _GetReportDAO)
        {
            GetReportDAO = _GetReportDAO;
        }

        

        [HttpGet]
        public List<Report> GetReports()
        {
            List<Report> ListOfDriversWithRequestedInformation = GetReportDAO.GetAllReports();
            return ListOfDriversWithRequestedInformation;
        }
    }
}
