using System;
using System.Collections.Generic;
using System.Web.Services;

namespace project_8
{
    /// <summary>
    /// Finding the Nearest Achitectural Firm
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ArchitecturalFirmsWebService : System.Web.Services.WebService
    {
        // Importing Data of Architectural firms in Class and Constructing of objects 
        // X and Y are unreal
        public List<architectural_firms> Firms = new List<architectural_firms>()
        {
        new architectural_firms() {ID = 1, X = 51.1, Y = 35.5, Name = "Gensler", Founder = "John Adams", Country = "United States", Projects = new List<string> { "San Francisco International Airport", "Viettel Group Headquarters" }, ContactInfo = "product_librarians@gensler.com"},
        new architectural_firms() {ID = 2, X = 52.3, Y = 34.3, Name = "HDR", Founder = "H.H. Henningson", Country = "Canada", Projects = new List<string> { "Hidalgo County Courthouse", "Multnomah County Courthouse" }, ContactInfo = "(402) 399-1000"},
        new architectural_firms() {ID = 3, X = 53.2, Y = 32.3, Name = "Nikken Sekkei", Founder = "Tadao Kamei", Country = "Japon", Projects = new List<string> { "Osaka Library", "The Sumitomo Building" }, ContactInfo = "global@nikken.jp"},
        new architectural_firms() {ID = 4, X = 49.9, Y = 35.7, Name = "Sweco", Founder = "Gunnar Nordström", Country = "Sweden", Projects = new List<string> { "Aarhus Stadium", "Gamlestaden Travel Centre" }, ContactInfo = "+46 8 695 60 00"},
        };

        // Main Function in Web Service for External use
        [WebMethod]
        public architectural_firms GetNearestArchitecturalFirm(double x, double y)
        {
            // Nearest distance store in Nearest Variable
            // Nearest Firm store in Goal 
            // They are updating over loops
            double Nearest = -1;
            architectural_firms Goal = null;
            foreach (architectural_firms item in Firms)
            {
                double Dis = GetDistance(item.X, item.Y, x, y);
                if ((Dis < Nearest) | (Nearest == -1)) 
                {
                    Nearest = Dis;
                    Goal = item;
                }
            }
            return Goal;
        }

        // Simple Calculator for euclidean Distance
        public double GetDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        }
    }
}
