using static System.Console;
using System.Globalization;

CultureInfo globalization = CultureInfo.CurrentCulture;
CultureInfo localization = CultureInfo.CurrentUICulture;
WriteLine("The current globalization culture is {0}: {1}",
    arg0:globalization,arg1:globalization.DisplayName);