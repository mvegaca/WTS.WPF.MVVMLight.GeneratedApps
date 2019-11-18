using System.Windows.Controls;

using MahApps.Metro.Controls;

using RibbonApp.Behaviors;

namespace RibbonApp.Contracts.Views
{
    public interface IShellWindow
    {
        Frame GetNavigationFrame();

        void ShowWindow();

        Frame GetRightPaneFrame();

        SplitView GetSplitView();

        RibbonTabsBehavior GetRibbonTabsBehavior();
    }
}
