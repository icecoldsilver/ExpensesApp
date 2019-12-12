using System;
using System.Collections.Generic;
using ExpenseApp.ViewModels;
using Xamarin.Forms;

namespace ExpenseApp.Views
{
    public partial class ExpensesPage : ContentPage
    {
        ExpensesVM ViewModel;

        public ExpensesPage()
        {
            InitializeComponent();

            ViewModel = Resources["vm"] as ExpensesVM;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            ViewModel.GetExpenses();
        }
    }
}
