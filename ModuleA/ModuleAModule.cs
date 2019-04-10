using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;

namespace ModuleA
{
    public class ModuleAModule : IModule
    {
        private IUnityContainer _container;
        private IRegionManager _regionManager;

        public ModuleAModule(IUnityContainer container, IRegionManager regionManager)
        {
            _regionManager = regionManager;
            _container = container;
        }
        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("ToolbarRegion", typeof(ToolbarView));
            _regionManager.RegisterViewWithRegion("ContentRegion", typeof(ContentView));
        }
    }
}