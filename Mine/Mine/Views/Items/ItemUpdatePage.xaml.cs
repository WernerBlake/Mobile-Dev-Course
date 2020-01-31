using System;
using System.ComponentModel;
using Xamarin.Forms;

using Mine.ViewModels;

namespace Mine.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer

    /// <summary>
    /// Item Update Page
    /// </summary>
    [DesignTimeVisible(false)]
    public partial class ItemUpdatePage : ContentPage
    {
        // View Model for Item
        ItemViewModel ViewModel;

        /// <summary>
        /// Constructor that takes and existing data item
        /// </summary>
        public ItemUpdatePage(ItemViewModel data)
        {
            InitializeComponent();

            BindingContext = this.ViewModel = data;
        }

        /// <summary>
        /// Save calls to Update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "Save", ViewModel.Data);
            await Navigation.PopModalAsync();
        }

        /// <summary>
        /// Cancel and close this page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        /// <summary>
        /// Cancel the Create
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Value_OnStepperValueChanged(object senders, ValueChangedEventArgs e)
        {
            ValueValue.Text = String.Format("{0}", e.NewValue);
        }
    }
}