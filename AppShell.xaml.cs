using System.ComponentModel;
using System.Globalization;

namespace MaApp;

public partial class AppShell : Shell, INotifyPropertyChanged
{
	public AppShell()
	{
		InitializeComponent();
        
    }

    // this is set after user logged in (according to the current user's permissions on different modules
    public Dictionary<string, int> Permissions { get; set; } 

}


public class PermissionsToVisibility : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo info)
    {
        if (value == null || (value as Dictionary<string, int>).Count == 0) return false;
        Dictionary<string, int> perms = value as Dictionary<string, int>;
        string module = parameter as string;
        if (perms.ContainsKey(module))
            return perms[module] > 0;
        else
            return false;
    }
    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();
}
