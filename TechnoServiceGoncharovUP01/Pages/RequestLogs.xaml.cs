﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TechnoServiceGoncharovUP01.Pages
{
    /// <summary>
    /// Interaction logic for RequestLogs.xaml
    /// </summary>
    public partial class RequestLogs : Page
    {
        public RequestLogs()
        {
            InitializeComponent();

            DGRequestLogs.ItemsSource = Entities.GetContext().RequestLog.ToList();
        }
    }
}
