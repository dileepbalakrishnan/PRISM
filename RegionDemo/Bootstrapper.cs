using System.Windows;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.UnityExtensions;
using Microsoft.Practices.Unity;
using ModuleA;

namespace RegionDemo
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();
            Application.Current.MainWindow = (Window) Shell;
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {
            var typeOfModule = typeof(ModuleAModule);
            ModuleCatalog.AddModule(new ModuleInfo
            {
                InitializationMode = InitializationMode.WhenAvailable,
                ModuleType = typeOfModule.AssemblyQualifiedName,
                ModuleName = typeOfModule.Namespace
            });
        }
    }
}