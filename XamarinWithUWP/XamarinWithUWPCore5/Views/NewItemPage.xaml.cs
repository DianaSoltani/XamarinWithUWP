using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.Maui.Controls.Xaml;

using XamarinWithUWP.Models;
using XamarinWithUWP.ViewModels;
using Microsoft.Maui.Controls;
using Microsoft.Maui;

namespace XamarinWithUWP.Views
{
	public partial class NewItemPage : ContentPage
	{
		public Item Item { get; set; }

		public NewItemPage()
		{
			InitializeComponent();
			BindingContext = new NewItemViewModel();
		}
	}
}