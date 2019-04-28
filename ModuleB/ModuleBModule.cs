using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using ModuleA;

namespace ModuleB
{
    public class ModuleBModule : IModule
    {
        private readonly IUnityContainer _container;
        private readonly IRegionManager _regionManager;

        public ModuleBModule(IUnityContainer container, IRegionManager regionManager)
        {
            _regionManager = regionManager;
            _container = container;
        }
        public void Initialize()
        {
            //_regionManager.RegisterViewWithRegion("ToolbarRegion", typeof(ToolbarView));
            IRegion toolbarRegion = _regionManager.Regions["ToolbarRegion"];
            toolbarRegion.Add(_container.Resolve<ToolbarView>());
            toolbarRegion.Add(_container.Resolve<ToolbarView>());
            toolbarRegion.Add(_container.Resolve<ToolbarView>());
            toolbarRegion.Add(_container.Resolve<ToolbarView>());
            toolbarRegion.Add(_container.Resolve<ToolbarView>());
            _regionManager.RegisterViewWithRegion("ContentRegion", typeof(ContentView));
        }
    }
}