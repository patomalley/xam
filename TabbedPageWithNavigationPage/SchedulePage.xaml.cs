using System;
using Xamarin.Forms;

namespace TabbedPageWithNavigationPage
{
	public partial class SchedulePage : ContentPage
	{
		public SchedulePage ()
		{

            var like = new Button
            {
                Text = "Like",
                VerticalOptions = LayoutOptions.EndAndExpand,
                HorizontalOptions = LayoutOptions.Start
                

            };
            var dislike = new Button
            {
                Text = "Dislike",
                
            };

            Title = "Roomies";
            var buttonRow = new StackLayout
            {

                Children =
                {
                    dislike,
                    like
                },

                Orientation = StackOrientation.Horizontal,
                VerticalOptions = LayoutOptions.EndAndExpand,
                HorizontalOptions = LayoutOptions.Center

            };
            Content = new StackLayout
            {
                Children =
                {
                   buttonRow
                }
            };
        }

		async void OnUpcomingAppointmentsButtonClicked (object sender, EventArgs e)
		{
			await Navigation.PushAsync (new UpcomingAppointmentsPage ());
		}
	}
}

