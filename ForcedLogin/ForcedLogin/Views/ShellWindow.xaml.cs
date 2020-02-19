using System.Windows.Controls;

using ForcedLogin.Contracts.Views;

using MahApps.Metro.Controls;

namespace ForcedLogin.Views
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

        public void CloseWindow()
            => Close();
    }
}
