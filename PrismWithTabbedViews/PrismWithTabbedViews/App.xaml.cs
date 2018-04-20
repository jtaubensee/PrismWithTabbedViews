using PrismWithTabbedViews.ViewModels;
using PrismWithTabbedViews.Views;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace PrismWithTabbedViews
{
    public partial class App : PrismApplication
	{
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            await this.NavigationService.NavigateAsync(nameof(MainTabbedPage));
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainTabbedPage>();
            containerRegistry.RegisterForNavigation<TabbedPage1, TabbedPage1ViewModel>();
            containerRegistry.RegisterForNavigation<TabbedPage2, TabbedPage2ViewModel>();
        }
    }
}
