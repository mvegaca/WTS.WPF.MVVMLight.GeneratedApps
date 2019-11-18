using System.Windows.Controls;

using MahApps.Metro.Controls;

using NavigationPane.Contracts.Views;

namespace NavigationPane.Views
{
    public partial class ShellWindow : MetroWindow, IShellWindow
    {
        public ShellWindow()
        {
            InitializeComponent();
        }

        public Frame GetNavigationFrame()
            => shellFrame;

        public void ShowWindow()
            => Show();
    }
}
