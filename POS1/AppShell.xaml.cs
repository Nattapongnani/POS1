using System.Windows.Input;

namespace POS1;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute("Eq1", typeof(NewPage1));
        Routing.RegisterRoute("Eq2", typeof(NewPage1));
        Routing.RegisterRoute("Eq3", typeof(NewPage1));
        Routing.RegisterRoute("Eq4", typeof(NewPage1));

        BindingContext = this;
    }

    public ICommand Eq1Command => new Command(async () => await NavigatedToEq1());
    public ICommand Eq2Command => new Command(async () => await NavigatedToEq2());
    public ICommand Eq3Command => new Command(async () => await NavigatedToEq3());
    public ICommand Eq4Command => new Command(async () => await NavigatedToEq4());

    async Task NavigatedToEq1()
    {
        await Shell.Current.GoToAsync("Eq1");
    }
    async Task NavigatedToEq2()
    {
        await Shell.Current.GoToAsync("Eq2");
    }
    async Task NavigatedToEq3()
    {
        await Shell.Current.GoToAsync("Eq3");
    }
    async Task NavigatedToEq4()
    {
        await Shell.Current.GoToAsync("Eq4");
    }
}
