using System;
using Xamarin.Forms;

namespace TabbedPageWithNavigationPage
{
	public class SchedulePageCS : ContentPage
	{
		public SchedulePageCS ()
		{
			var like = new Button {
				Text = "Like",
				VerticalOptions = LayoutOptions.CenterAndExpand
                
			};
            var dislike = new Button
            {
                Text = "Dislike",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

			Title = "Roomies";
			Content = new StackLayout {
				Children =
                {
                    like,
                    dislike
                }
			};
		}

		async void OnUpcomingAppointmentsButtonClicked (object sender, EventArgs e)
		{
			await Navigation.PushAsync (new UpcomingAppointmentsPage ());
		}
	}
}
