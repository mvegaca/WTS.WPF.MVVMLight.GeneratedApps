using System;
using System.Windows;
using System.Windows.Controls;

using Fluent;

using MahApps.Metro.Controls;

using RibbonApp.Behaviors;
using RibbonApp.Contracts.Services;
using RibbonApp.Contracts.Views;
using RibbonApp.ViewModels;

namespace RibbonApp.Views
{
    public partial class ShellWindow : MetroWindow, IShellWindow
    {
        private RibbonTitleBar _titleBar;

        public ShellWindow(IPageService pageService)
        {
            InitializeComponent();
            navigationBehavior.Initialize(pageService);
        }

        public Frame GetNavigationFrame()
            => shellFrame;

        public RibbonTabsBehavior GetRibbonTabsBehavior()
            => tabsBehavior;

        public Frame GetRightPaneFrame()
            => rightPaneFrame;

        public SplitView GetSplitView()
            => splitView;

        public void ShowWindow()
            => Show();

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var window = sender as MetroWindow;
            _titleBar = window.FindChild<RibbonTitleBar>("RibbonTitleBar");
            _titleBar.InvalidateArrange();
            _titleBar.UpdateLayout();
        }
    }
}
