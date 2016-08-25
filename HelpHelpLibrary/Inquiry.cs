using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelpHelpLibrary
{
    /// <summary>
    /// 問い合わせ
    /// </summary>
    public class Inquiry
    {
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public string SupportMember { get; set; }
        public string OfficeCode { get; set; }
        public string OfficeName { get; set; }
        public string CustomerName { get; set; }
        public string ClientPCInfo { get; set; }
        public string System { get; set; }
        public string Description { get; set; }

        public string How { get; set; }
        public string What { get; set; }
        public string When { get; set; }
        public string Where { get; set; }
        public string Why { get; set; }

    }
}
