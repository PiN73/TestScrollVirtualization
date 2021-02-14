using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace TestScrollVirtualization
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MyButton.Click += (s, e) =>
            {
                MyButton.Visibility = Visibility.Collapsed;
                MyItemsControl.ItemsSource = Enumerable
                    .Range(0, 10000)
                    .Select(i => $"Item {i}")
                    .ToArray();
            };
        }
    }
}
