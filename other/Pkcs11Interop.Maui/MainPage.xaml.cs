using Net.Pkcs11Interop.Common;
using Net.Pkcs11Interop.HighLevelAPI;

namespace Pkcs11Interop.Maui;

public partial class MainPage : ContentPage
{
	// int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		/*
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";
		*/

		try
		{
			var libraryPath = "./pkcs11-mock/macos/pkcs11-mock.dylib";
			var factories = new Pkcs11InteropFactories();
			var library = factories.Pkcs11LibraryFactory.LoadPkcs11Library(factories, libraryPath, AppType.MultiThreaded);
			var info = library.GetInfo();

			CounterBtn.Text = info.ManufacturerId;
		}
		catch (Exception ex)
		{
			CounterBtn.Text = ex.Message;
		}

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

