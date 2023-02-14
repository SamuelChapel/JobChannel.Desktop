using BLL.Extensions;
using JobChannelDesktop.Extensions;
using Microsoft.Extensions.DependencyInjection;
using ServiceCollection = Microsoft.Extensions.DependencyInjection.ServiceCollection;

namespace JobChannelDesktop;

internal static class Program
{
    public static IServiceProvider? ServiceProvider { get; private set; }
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        var services = new ServiceCollection();

        services.AddApplicationServices();
        services.AddBLLServices();

        ApplicationConfiguration.Initialize();

        using ServiceProvider serviceProvider = services.BuildServiceProvider();
        ServiceProvider = serviceProvider;

        Application.Run(serviceProvider.GetService<FormJobChannel>());
    }
}