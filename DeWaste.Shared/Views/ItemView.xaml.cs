﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Microsoft.UI.Xaml.Media.Imaging;
using DeWaste.Models.DataModels;
using DeWaste.Models.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Windows.System;

namespace DeWaste.Views
{
    public sealed partial class ItemView : Page
    {
        ItemViewModel ViewModel;
        IServiceProvider container;

        public ItemView()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            ItemViewParameters parameters = (ItemViewParameters)e.Parameter;
            container = parameters.container;
            DataContext = this;
            ViewModel = container.GetService(typeof(ItemViewModel)) as ItemViewModel;
            if (parameters.item != null)
                ViewModel.SetItem(parameters.item);
        }

        //when clicked on diferent waste cateries
        private void Update_Toggle(object sender, RoutedEventArgs e)
        {            
            int buttonId = int.Parse((sender as Button).Tag.ToString());
            ViewModel.setToggle(buttonId);
        }

        private void WebLauncher(object sender, RoutedEventArgs e)
        {
            string link = (sender as Button).Tag.ToString();
            Launcher.LaunchUriAsync(new Uri(link));
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.SubmitComment();
        }

        private void Delete_Comment(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Comment comment = (Comment)button.DataContext;
            ViewModel.DeleteComment(comment);
        }

        private void Dislike_Comment(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Comment comment = (Comment)button.DataContext;
            ViewModel.DislikeComment(comment);
        }
        
        private void Like_Comment(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Comment comment = (Comment)button.DataContext;
            ViewModel.LikeComment(comment);
        }
    }
}
