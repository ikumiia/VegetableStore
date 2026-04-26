using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core;
using Avalonia.Data.Core.Plugins;
using System.Linq;
using Avalonia.Markup.Xaml;
using VegetableStore.ViewModels;
using VegetableStore.Views;

namespace VegetableStore;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
{
    if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
    {

        desktop.MainWindow = new VegetableStore.Views.MainWindow();
    }

    base.OnFrameworkInitializationCompleted();
}
}