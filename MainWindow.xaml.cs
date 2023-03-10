using System;
using System.Collections.Generic;
using System.IO;
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
        string p;
        string c;

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

        //feeds button
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(FeedsTree.SelectedItem != null)
            {
                //stuff
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // 1 child, 1 parent example
            string userIn = Microsoft.VisualBasic.Interaction.InputBox("nickname/name of parent item", "Collections", "Default Text");
            TreeViewItem parent = new TreeViewItem();
            parent.Header = userIn;
            FeedsTree.Items.Add(parent);
            p = userIn;

            string userChild = Microsoft.VisualBasic.Interaction.InputBox("nickname/name of child item", "Collections", "Default Text");
            TreeViewItem child = new TreeViewItem();
            child.Header = userChild;
            parent.Items.Add(child);
            c = userChild;

        }

        //saveing tree view to txtfile
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string path = @"c:\temp\MyTest.txt";

            if (!File.Exists(path))
            {
                // Create a file to write to.
                string createText = "Made new file" + Environment.NewLine;
                File.WriteAllText(path, createText);
            }


            string appendText = "parent: " + p  + "child: " + c + Environment.NewLine;
            File.AppendAllText(path, appendText);

            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);

        }
    }
}
