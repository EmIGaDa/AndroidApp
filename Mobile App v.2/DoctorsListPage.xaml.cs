using Mobile_App_v._2.Model;

namespace Mobile_App_v._2;

public partial class DoctorsListPage : ContentPage
{
    public DoctorsListPage()
    {
        InitializeComponent();
    }

    async void OnAddButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DoctorPage
        {
            BindingContext = new Doctor()
        });
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        listView.ItemsSource = await App.Database.GetDoctorAsync();
    }

    async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new DoctorPage
            {
                BindingContext = e.SelectedItem as Doctor
            });
        }


    }

}