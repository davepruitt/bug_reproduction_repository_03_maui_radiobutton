namespace RadioButtonBug;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainPageViewModel();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		var vm = BindingContext as MainPageViewModel;
		if (vm != null)
		{
			vm.IsRadioButtonEnabled = !vm.IsRadioButtonEnabled;
		}
    }
}

