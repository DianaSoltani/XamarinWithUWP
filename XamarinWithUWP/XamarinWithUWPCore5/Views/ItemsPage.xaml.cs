﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls.Xaml;
using XamarinWithUWP.Models;
using XamarinWithUWP.ViewModels;
using XamarinWithUWP.Views;
using Microsoft.Maui.Controls;
using Microsoft.Maui;

namespace XamarinWithUWP.Views
{
	public partial class ItemsPage : ContentPage
	{
		ItemsViewModel _viewModel;

		public ItemsPage()
		{
			InitializeComponent();

			BindingContext = _viewModel = new ItemsViewModel();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			_viewModel.OnAppearing();
		}
	}
}