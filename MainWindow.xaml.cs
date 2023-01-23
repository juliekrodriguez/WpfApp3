using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        internal User testUser = new User("Julie");
        //ccnn
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            TreeViewItem Item = new TreeViewItem();
            Item.Header = "GroupTest";
            FeedsTree.Items.Add(Item);

            TreeViewItem newChild = new TreeViewItem();
            Feed newFeeder;
            newFeeder = new Feed("http://rss.cnn.com/rss/cnn_topstories.rss", "CNN Feed");
            testUser.AddFeed(newFeeder);
            newChild.Header = "CNN Feed";

            Item.Items.Add(newChild);

        }
    }
}
