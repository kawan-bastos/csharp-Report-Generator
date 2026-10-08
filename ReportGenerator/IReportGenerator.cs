using System;
using System.Collections.Generic;
using System.Text;

namespace ReportGenerator;

public interface IReportGenerator
{
    public List<Dictionary<string, string>> Input { get; set; }
    public string Title { get; set; }
    public string HeadLine { get; set; }
    public string FooterLine { get; set; }

}
