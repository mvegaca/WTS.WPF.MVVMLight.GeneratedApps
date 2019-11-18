using System;
using System.Windows;
using System.Windows.Controls;

using Fluent;

using MahApps.Metro.Controls;

using Ribbon.Behaviors;
using Ribbon.Contracts.Services;
using Ribbon.Contracts.Views;
using Ribbon.ViewModels;

namespace Ribbon.Views
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
