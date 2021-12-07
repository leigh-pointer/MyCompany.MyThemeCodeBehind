using Oqtane.Models;
using Oqtane.Themes;

namespace MyCompany.MyThemeCodeBehind
{
    public class ThemeInfo : ITheme
    {
        public Theme Theme => new Theme
        {
            Name = "MyThemeCodeBehind",
            Version = "1.0.0",
            PackageName = "MyCompany.MyThemeCodeBehind"
        };

    }
}
