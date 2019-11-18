using System.Windows.Controls;

using MahApps.Metro.Controls;

using Ribbon.Behaviors;

namespace Ribbon.Contracts.Views
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
