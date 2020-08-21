using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SafeAutoKada.Model;
using SafeAutoKada.DAO;
using SafeAutoKada.Controllers;


namespace SafeAutoKada.DAO
{
    public interface IGetReportDAO
    {
        List<Report> GetAllReports();
    }
}