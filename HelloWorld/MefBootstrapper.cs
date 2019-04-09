using System.ComponentModel.Composition.Hosting;
using System.Threading;
using System.Windows;
using Microsoft.Practices.Prism.MefExtensions;

namespace HelloWorld
{
    internal class MEFBootstrapper : MefBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.GetExportedValue<Shell>();
        }

        protected override void ConfigureAggregateCatalog()
        {
            base.ConfigureAggregateCatalog();
            AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(MEFBootstrapper).Assembly));
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();
            Application.Current.MainWindow = (Window) Shell;
            Application.Current.MainWindow.Show();
        }
    }
}