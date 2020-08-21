using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SafeAutoKada.Model;
using SafeAutoKada.Controllers;
using System.IO;

namespace SafeAutoKada.DAO
{
    public class GetReportDAO : IGetReportDAO
    {

        public List<Report> GetAllReports()
        {


            List<Report> Reports = new List<Report>();
            List<Report> AllTrips = new List<Report>();




                try
                {
                string sourcefile = @".\SafeAutoTextFile.txt";

                using (StreamReader sr = new StreamReader(sourcefile))
                    {
                        string[] drivers = new string[0];
                    List<string> driverNames = new List<string>();
                        
                        while (!sr.EndOfStream)
                        {

                            string line = sr.ReadLine();

                            drivers = line.Split(" ");

                        for (int i = 0; i < drivers.Length; i++)
                        {
                            Report finalReport = new Report();
                            if (drivers[i] == "Driver")
                            {
                                Report report = new Report();
                                report.Name = drivers[i+1];
                                Reports.Add(report);
                            }

                            if (drivers[i] == "Trip")
                            {
                                TimeSpan startingTime = TimeSpan.Parse(drivers[i+2]);
                                TimeSpan endingTime = TimeSpan.Parse(drivers[i + 3]);
                                TimeSpan span = endingTime.Subtract(startingTime);
                                Report report = new Report();
                                report.Name = drivers[i+1];
                                report.MinutesDriven = (int) span.TotalMinutes;
                                report.Miles = double.Parse(drivers[i + 4]);

                                AllTrips.Add(report);
                            }
                        }


                        }
                        foreach(string name in driverNames)
                        {
                        Report report = new Report();
                        report.Name = name;
                        Reports.Add(report);
                        }

                    }
                }

                catch
                {
                    Console.WriteLine("done but broke");
                    Console.ReadLine();

                }
            foreach(Report driver in Reports)
            {
                for(int i = 0; i < AllTrips.Count; i++)
                {
                    if (AllTrips[i].Name == driver.Name)
                    {
                        driver.MinutesDriven = driver.MinutesDriven + AllTrips[i].MinutesDriven;
                        driver.Miles = driver.Miles + AllTrips[i].Miles;
                    }
                }
            }

            foreach(Report driver in Reports)
            {
                if (driver.Miles != 0 & driver.MinutesDriven != 0)
                {
                    driver.MilesPerHour = driver.Miles / (driver.MinutesDriven / 60);
                }
                driver.Miles = Math.Round(driver.Miles);
                driver.MilesPerHour = Math.Round(driver.MilesPerHour);

            }
            //insert logic here to read document, organize it into required data for report model
            return Reports;

        }
    }
}
