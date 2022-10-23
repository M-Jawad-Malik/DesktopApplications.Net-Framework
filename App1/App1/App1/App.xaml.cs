﻿using System;
using Xamarin.Forms;
using App1.Views;
using Xamarin.Forms.Xaml;
using App1.Data;

namespace App1
{
    public partial class App : Application
    {
        static TokenDatabaseController tokenDatabase;
        static UserDatabaseController userDatabase;
        public App()
        {
            InitializeComponent();

            MainPage = new Page1(); 
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
        public static UserDatabaseController UserDatabase
        {
            get
            {
                if(userDatabase==null)
                {
                    userDatabase = new UserDatabaseController();
                }
                return userDatabase;
            }

        }
        public static TokenDatabaseController TokenDatabase
        {
            get
            {
                if (tokenDatabase == null)
                {
                    tokenDatabase = new TokenDatabaseController();
                }
                return tokenDatabase;
            }

        }
    }
}
