using Prism.Mvvm;
using Prism.Navigation;

namespace PrismWithTabbedViews.ViewModels
{
    public class ViewModelBase : BindableBase, INavigationAware
    {
        private readonly INavigationService navigationService;

        public ViewModelBase(INavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        private string title;
        public string Title
        {
            get => this.title;
            set => SetProperty(ref this.title, value);
        }

        public virtual void OnNavigatedFrom(NavigationParameters parameters) { }

        public virtual void OnNavigatedTo(NavigationParameters parameters) { }

        public virtual void OnNavigatingTo(NavigationParameters parameters) { }
    }
}
