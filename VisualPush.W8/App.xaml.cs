using Microsoft.Practices.Prism.StoreApps;
using Microsoft.Practices.Unity;
using System;
using System.Threading.Tasks;
using VisualPush.W8.Services;
using Windows.ApplicationModel.Activation;

namespace VisualPush.W8
{
    sealed partial class App : MvvmAppBase
    {
        private readonly IUnityContainer _container = new UnityContainer();

        public App()
        {
            this.InitializeComponent();
        }

        protected override Task OnLaunchApplication(LaunchActivatedEventArgs args)
        {
            NavigationService.Navigate("Main", null);
			return Task.FromResult<object>(null);
        }

        protected override void OnInitialize(IActivatedEventArgs args)
        {
            _container.RegisterInstance(NavigationService);
            _container.RegisterType<INotificationService, NotificationServiceProxy>(new ContainerControlledLifetimeManager());

        }

        protected override object Resolve(Type type)
        {
            return _container.Resolve(type);
        }
    }
}
