using Mine.Models;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace Mine.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    /// <summary>
    /// Menu Page
    /// </summary>
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }

        // List of Menu Items
        List<HomeMenuItemModel> menuItems;

        /// <summary>
        /// Constructor
        /// Load the Menu Items
        /// Setup Item Selected call
        /// </summary>
        public MenuPage()
        {
            InitializeComponent();

            // Establish the Menu List
            menuItems = new List<HomeMenuItemModel>
            {
                new HomeMenuItemModel {Id = MenuItemEnum.Items, Title="Items" },
                new HomeMenuItemModel {Id = MenuItemEnum.About, Title="About" }
            };

            // Register the ListView for the Menu and the Item Selected call back
            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                // Menu choice was selected, evaluate it
                if (e.SelectedItem == null)
                {
                    return;
                }

                var id = (int)((HomeMenuItemModel)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}