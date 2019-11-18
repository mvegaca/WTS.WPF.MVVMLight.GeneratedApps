using System.Windows.Controls;

using MahApps.Metro.Controls;

using MenuBar.Contracts.Views;

namespace MenuBar.Views
{
    public partial class ShellWindow : MetroWindow, IShellWindow
    {
        public ShellWindow()
        {
            InitializeComponent();
        }

        public Frame GetNavigationFrame()
            => shellFrame;

        public Frame GetRightPaneFrame()
            => rightPaneFrame;

        public void ShowWindow()
            => Show();

        public SplitView GetSplitView()
            => splitView;
    }
}
