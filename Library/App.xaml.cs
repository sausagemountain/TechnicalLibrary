﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Library
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public MyDbContext DatabaseContext { get; set; } = new MyDbContext(@"data source=.\testdb.sqlite");

        private void App_Exit(object sender, ExitEventArgs e)
        {
            DatabaseContext.SaveChanges();
        }
    }
}
