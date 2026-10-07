using System;
using System.Collections.Generic;
using System.Text;

namespace ReportGeneratorLibrary;

public class ReportGenerator
{
    public List<Dictionary<string, string>> Input { get; set; }
    
    public ReportGenerator(List<Dictionary<string, string>> input)
    {
        Input = input;
    }

    public string GenerateReport()
    {
        if (Input == null || Input.Count == 0)
            throw new Exception("Input de dados invalido");

        StringBuilder report = new StringBuilder();
        
        string header = string.Join(";", Input.First().Keys);
        report.AppendLine(header);

        foreach (var record in Input)
        {
            string line = string.Join(";", record.Values);
            report.AppendLine(line);
        }

        File.WriteAllText("report.csv", report.ToString());
        
        return Path.GetFullPath("report.csv");
    }
}
