using System;
using System.Collections.Generic;
using System.Text;

namespace ReportGenerator;
/// <summary>
///  Defines the interface for generating reports.
/// </summary>
/// <remarks>
///  Implementations of this interface are responsible for generating reports based on the provided input data and formatting options.
/// </remarks>
public interface IReportGenerator
{
    /// <summary>
    /// Gets or sets the input data for the report. The input data is represented as a list of dictionaries, where each dictionary represents a record with key-value pairs.
    /// </summary>
    public List<Dictionary<string, string>> Input { get; set; }
    /// <summary>
    /// Gets or sets the title of the report.
    /// </summary>
    public string Title { get; set; }
    /// <summary>
    /// Gets or sets the headline of the report.
    /// </summary>
    public string HeadLine { get; set; }
    /// <summary>
    /// Gets or sets the footer line of the report.
    /// </summary>
    public string FooterLine { get; set; }
    /// <summary>
    /// Generates the report and returns the path to the generated report file.
    /// </summary>
    /// <returns> the path to the generated report file </returns>
    string GenerateReport();
}
