using System.ComponentModel;
using Xamarin.Forms;
using XamarinWithUWP.ViewModels;

namespace XamarinWithUWP.Views
{
	public partial class ItemDetailPage : ContentPage
	{
		public ItemDetailPage()
		{
			InitializeComponent();
			BindingContext = new ItemDetailViewModel();
		}
	}
}