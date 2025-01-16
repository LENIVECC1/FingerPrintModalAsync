namespace PRACT4_10;

public partial class NewPage1 : ContentPage
{
	public NewPage1(string text1,string text2,string text3)
	{
		InitializeComponent();
        namecopy.Text = text1;
        firstNamecopy.Text = text2;
        lastNamecopy.Text = text3;
	}

    async public void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }

    public async void Button_Clicked_1(object sender, EventArgs e)
    {
       await  Navigation.PushModalAsync(new NewPage2());

    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {
        Application.Current.Quit();
    }
}