﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

namespace MdXaml.ScrollDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            CommandBindings.Add(new CommandBinding(
                NavigationCommands.GoToPage,
                (sender, e) =>
                {
                    var proc = new Process();
                    proc.StartInfo.UseShellExecute = true;
                    proc.StartInfo.FileName = (string)e.Parameter;

                    proc.Start();
                }));
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var tabControl = e.Source as TabControl;
            if (tabControl is null) return;

            var selectedTab = tabControl.SelectedItem as TabItem;
            if (selectedTab is null) return;

            var dataContext = (MainWindowViewModel)DataContext;
            if (dataContext is null) return;

            var selectedTabHeader = (String)selectedTab.Header;

            if (selectedTabHeader == "BindingStyle")
            {
                dataContext.TextView = dataContext.TextXaml;
            }
            else
            {
                dataContext.TextXaml = dataContext.TextView;
            }
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            ScrollViewer.ScrollToHome();
        }
        private void End_Click(object sender, RoutedEventArgs e)
        {
            ScrollViewer.ScrollToEnd();

        }

        public ScrollViewer ScrollViewer
        {
            get
            {
                DependencyObject obj = MdScrlViewer;

                do
                {
                    if (VisualTreeHelper.GetChildrenCount(obj) > 0)
                        obj = VisualTreeHelper.GetChild(obj as Visual, 0);
                    else
                        return null;
                }
                while (!(obj is ScrollViewer));

                return obj as ScrollViewer;
            }
        }
    }
}
