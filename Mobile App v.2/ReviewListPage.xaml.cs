using Mobile_App_v._2.Model;

namespace Mobile_App_v._2;

public partial class ReviewListPage : ContentPage
{
	public ReviewListPage()
	{
		InitializeComponent();
	}

    async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new ReviewPage
            {
                BindingContext = e.SelectedItem as Review
            });
        }


    }

    async void OnAddButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ReviewPage
        {
            BindingContext = new Review()
        });
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        listView.ItemsSource = await App.Database.GetReviewAsync();
    }

}