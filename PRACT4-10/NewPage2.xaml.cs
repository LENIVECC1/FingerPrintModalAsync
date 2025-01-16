namespace PRACT4_10;

public partial class NewPage2 : ContentPage
{
	public NewPage2()
	{
		InitializeComponent();
	}

    async public void Button_Clicked(object sender, EventArgs e)
    {
        string izmentext1 = name.Text; 
        string izmentext2 = firstName.Text;
        string izmentext3 = lastName.Text;
        var firstpage = new NewPage1(izmentext1,izmentext2,izmentext3);
        await Navigation.PushModalAsync(firstpage);
    }

    
}