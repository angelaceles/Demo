﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new NavigationPage(new Page1());
            //MainPage = new TabbedPage1();
            MainPage = new Caroucel();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
