using System.Windows.Controls;

using Blank.Contracts.Views;

using MahApps.Metro.Controls;

namespace Blank.Views
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
