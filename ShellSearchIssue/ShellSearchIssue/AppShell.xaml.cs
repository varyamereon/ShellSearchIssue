using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShellSearchIssue
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        public AppShell() => InitializeComponent();
    }
}
