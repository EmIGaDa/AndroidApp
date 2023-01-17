using Mobile_App_v._2.Model;

namespace Mobile_App_v._2;

public partial class ReviewPage : ContentPage
{
	public ReviewPage()
	{
		InitializeComponent();
	}

    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var review = (Review)BindingContext;
        review.DoctorID = 0;
        await App.Database.SaveReviewAsync(review);
        await Navigation.PopAsync();
    }
    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var review = (Review)BindingContext;
        await App.Database.DeleteReviewAsync(review);
        await Navigation.PopAsync();
    }
}