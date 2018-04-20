using PrismWithTabbedViews.Views;
using Prism.Navigation;

namespace PrismWithTabbedViews.ViewModels
{
    public class TabbedPage1ViewModel : ViewModelBase
    {
        public TabbedPage1ViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            this.Title = nameof(TabbedPage1);
        }

        private double counterValue = 0;
        public double CounterValue
        {
            get => this.counterValue;
            set => SetProperty(ref this.counterValue, value);
        }

        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            base.OnNavigatingTo(parameters);
            if (parameters.TryGetValue<double>(nameof(this.CounterValue), out var newCounterValue))
            {
                this.CounterValue = newCounterValue;
            }
        }

        public override void OnNavigatedFrom(NavigationParameters parameters)
        {
            base.OnNavigatedFrom(parameters);
            parameters.Add(nameof(this.CounterValue), this.CounterValue);
        }
    }
}
