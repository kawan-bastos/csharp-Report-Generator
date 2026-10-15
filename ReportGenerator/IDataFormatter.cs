using System;
using System.Collections.Generic;
using System.Text;

namespace ReportGenerator;

internal interface IDataFormatter
{
    string FormatData(string input);
}
