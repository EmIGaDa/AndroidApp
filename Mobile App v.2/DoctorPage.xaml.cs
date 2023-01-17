using Mobile_App_v._2.Model;

namespace Mobile_App_v._2;

public partial class DoctorPage : ContentPage
{
	public DoctorPage()
	{
		InitializeComponent();
	}

    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var doctor = (Doctor)BindingContext;
        await App.Database.SaveDoctorAsync(doctor);
        await Navigation.PopAsync();
    }

    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var doctor = (Doctor)BindingContext;
        await App.Database.DeleteDoctorAsync(doctor);
        await Navigation.PopAsync();
    }
}