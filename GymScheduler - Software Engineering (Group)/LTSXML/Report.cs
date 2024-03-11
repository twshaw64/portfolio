using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LTSXML
{
    public class Report
    {
        #region Private Member Variables
        private DateTime m_ReportDate;
        private string m_Username;
        private string m_ReportDescription;
        private int mReportID;
        private bool mResolved;
        #endregion

        #region Fields
        public bool Resolved
        {
            get { return mResolved; }
            set { mResolved = value; }
        }
        public DateTime ReportDate
        {
            get
            {
                return m_ReportDate;
            }
            set
            {
                m_ReportDate = value;
            }
        }
        public string Username
        {
            get
            {
                return m_Username;
            }
            set
            {
                m_Username = value;
            }
        }
        public string ReportDescription
        {
            get
            {
                return m_ReportDescription;
            }
            set
            {
                m_ReportDescription = value;
            }
        }
        public int ReportID
        {
            get
            {
                return mReportID;
            }
            set
            {
                mReportID = value;
            }
        }
        #endregion

        #region Overrides
        public override string ToString()
        {
            return ReportDate.ToShortDateString() + ": " + ReportDescription + ". Reported by: " + Username;
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Return a new instance of the Report Object
        /// </summary>
        public Report(DateTime pReportDate, string pUsername, string pReportDescription, bool pResolved):this(NextID, pReportDate, pUsername, pReportDescription, pResolved)
        {
        }

        /// <summary>
        /// Private constructor to allow the report ID to be set when loading from file
        /// </summary>
        private Report(int pReportID, DateTime pReportDate, string pUsername, string pReportDescription, bool pResolved)
        {
            ReportID = pReportID;
            ReportDate = pReportDate;
            Username = pUsername;
            ReportDescription = pReportDescription;
            Resolved = pResolved;
        }
        #endregion

        #region XML

        #region Load
        /// <summary>
        /// Return a Report object populated with data from the file system
        /// </summary>
        /// <param name="pReportID">The ID of the report to retreive</param>
        /// <exception cref="ReportException"></exception>
        public static Report Load(int pReportID)
        {
            string filename = StorageLocation.Reports;
            XDocument reportsFile = XDocument.Load(filename);
            foreach (XElement element in reportsFile.Root.Elements("report"))
            {
                if (element.Element("reportID").Value == pReportID.ToString()) return Compose(element);
            }
            throw new ReportException("Report not found");
        }

        /// <summary>
        /// Return a list of all the report objects stored in the file system
        /// </summary>
        public static List<Report> LoadReports()
        {
            string filename = StorageLocation.Reports;
            XDocument reportsFile = XDocument.Load(filename);
            List<Report> output = new List<Report>();
            foreach (XElement element in reportsFile.Root.Elements("report"))
            {
                output.Add(Compose(element));
            }
            return output;
        }

        /// <summary>
        /// Return a new Report object populated from the information in the supplied XML element
        /// </summary>
        /// <param name="pElement">XML element to construct the object from</param>
        private static Report Compose(XElement pElement)
        {
            int reportID = int.Parse(pElement.Element("reportID").Value);
            DateTime reportDate = DateTime.Parse(pElement.Element("date").Value);
            string reportingUsername = pElement.Element("reportingUsername").Value;
            string description = pElement.Element("description").Value;
            bool resolved = bool.Parse(pElement.Element("resolved").Value);
            return new Report(Report.NextID, reportDate, reportingUsername, description, resolved);
        }
        #endregion

        #region Save
        /// <summary>
        /// Save the report to the report file and update if the record already exists
        /// </summary>
        public void Save()
        {
            string filename = StorageLocation.Reports;
            XDocument reportFile = XDocument.Load(filename);
            if (Exists())
            {
                foreach (XElement element in reportFile.Root.Elements("report"))
                {
                    if (element.Element("reportID").Value == ReportID.ToString())
                    {
                        element.Remove();
                        reportFile.Root.Add(Compose());
                        reportFile.Save(filename);
                        return;
                    }
                }
            }
            else
            {
                reportFile.Root.Add(Compose());
                reportFile.Save(filename);
            }
        }

        /// <summary>
        /// Check if a record with this reportID already exists in the file system 
        /// </summary>
        private bool Exists()
        {
            XDocument reportsFile = XDocument.Load(StorageLocation.Reports);
            List<XElement> reportList = reportsFile.Root.Elements("report").ToList();
            foreach (XElement element in reportList)
            {
                if (element.Element("reportID").Value == ReportID.ToString())
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Compose a new XML element from the object
        /// </summary>
        private XElement Compose()
        {
            return new XElement("report",
                new XElement("reportID", ReportID.ToString()),
                new XElement("date", ReportDate.ToShortDateString()),
                new XElement("reportingParty", Username),
                new XElement("description", ReportDescription),
                new XElement("resolved", Resolved));
        }

        #endregion

        #region NextID
        /// <summary>
        /// The next ID number to be used for a new report, also increments the Next ID number
        /// </summary>
        public static int NextID
        {
            get
            {
                string filename = StorageLocation.Reports;
                XDocument reportsFile = XDocument.Load(filename);
                int output = int.Parse(reportsFile.Root.Element("nextID").Value);
                IncrementNextID(output);
                return output;
            }
        }
        /// <summary>
        /// Increment and save the next ID number
        /// </summary>
        private static void IncrementNextID(int pOriginal)
        {
            string filename = StorageLocation.Reports;
            XDocument reportsFile = XDocument.Load(filename);
            string newID = (pOriginal + 1).ToString();
            reportsFile.Root.Element("nextID").Value = newID;
            reportsFile.Save(filename);
        }

        #endregion
        #endregion

       
    }
}
