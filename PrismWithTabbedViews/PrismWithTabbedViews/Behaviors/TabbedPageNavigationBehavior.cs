using System;
using Prism.Behaviors;
using Prism.Common;
using Prism.Navigation;
using Xamarin.Forms;

namespace PrismWithTabbedViews.Behaviors
{
    public class TabbedPageNavigationBehavior : BehaviorBase<TabbedPage>
    {
        private Page CurrentPage;

        protected override void OnAttachedTo(TabbedPage bindable)
        {
            bindable.CurrentPageChanged += this.OnCurrentPageChanged;
            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(TabbedPage bindable)
        {
            bindable.CurrentPageChanged -= this.OnCurrentPageChanged;
            base.OnDetachingFrom(bindable);
        }

        private void OnCurrentPageChanged(object sender, EventArgs e)
        {
            var newPage = this.AssociatedObject.CurrentPage;

            if (this.CurrentPage != null)
            {
                var parameters = new NavigationParameters();
                PageUtilities.OnNavigatedFrom(this.CurrentPage, parameters);
                PageUtilities.OnNavigatedTo(newPage, parameters);
            }

            this.CurrentPage = newPage;
        }
    }
}
