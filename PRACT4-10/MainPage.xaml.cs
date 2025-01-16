using Plugin.Fingerprint.Abstractions;
using Plugin.Fingerprint;

namespace PRACT4_10
{
    public partial class MainPage : ContentPage
    {
        string fdd, ddd, rrr = "";
        public MainPage()
        {
            InitializeComponent();
            //SetCurrentActivityResolver();
        }

        //async public void window1_Click(object sender, EventArgs e)
        //{
        //    await Navigation.PushModalAsync(new NewPage1());
        //}
        //async public void window2_Click(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new NewPage2());
        //}
        //async public void back_Click(object sender, EventArgs e)
        //{
        //    await Navigation.PopModalAsync();
        //}



        public async void Button_Clicked(object sender, EventArgs e)
        {
            var request = new AuthenticationRequestConfiguration("Вы владелец телефона?",
    "Подтвердите себя");
            var result = await CrossFingerprint.Current.AuthenticateAsync(request);
            if (result.Authenticated)
            {
                await Navigation.PushModalAsync(new NewPage1( fdd, ddd ,rrr)); 

            }
            else
            {
                await DisplayAlert("ПРОВАЛ", "U ARE IMPOSTER", "SUS");
            }
        }
    }

}
