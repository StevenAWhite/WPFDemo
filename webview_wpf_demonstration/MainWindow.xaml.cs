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
using System.IO;

using Path = System.IO.Path;

namespace webview_wpf_demonstration
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GoogleHomepage.Source = new Uri("https://google.com");
            string filename = "index.html";
            if (File.Exists(filename)){
                filename = Path.GetFullPath(filename);
                LocalFiles.Source = new Uri($"file://{filename}");
            } else
            {
                throw new FileNotFoundException("Unable to locate index.html.");
            }
        }
    }
}
