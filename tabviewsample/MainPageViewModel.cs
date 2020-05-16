using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabviewsample
{
    public class MainPageViewModel
    {
        public ObservableCollection<TabViewItem> Tabs { get; } = new ObservableCollection<TabViewItem>();

        public void TabView_AddTabButtonClick(TabView sender, object args)
        {
            var frame = new Windows.UI.Xaml.Controls.Frame();
            frame.Navigate(typeof(TestPage));
            var tab = new TabViewItem
            {
                Header = "Broken",
                Content = frame
            };
            Tabs.Add(tab);
        }
    }
}
