using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StreamingApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private StreamingPlatform felulet;
        public MainWindow()
        {
            InitializeComponent();

            felulet = new StreamingPlatform();

            Video elsovideo = new Video("Első videó", 120);
            Movie film = new Movie(elsovideo);
            felulet.AddContent(film);

            List<Video> reszek = new List<Video>();
            reszek.Add(new Video("Első rész", 30));
            reszek.Add(new Video("Második rész", 40));
            reszek.Add(new Video("Harmadik rész", 25));

            Series series = new Series("Egy sorozat", reszek);
            felulet.AddContent(series);

            ShowContents();
        }

        private void ShowContents()
        {
            ContentsListBox.Items.Clear();

            string filterText = FilterTextBox.Text.ToLower();

            foreach (IContent content in felulet.GetContents())
            {
                string title = content.Title.ToLower();

                if (filterText == "" || title.Contains(filterText))
                {
                    ContentsListBox.Items.Add(content);
                }
            }
        }

        private void FilterTextBox_TextChanged( //kis Ai segítség a lentinél is
            object sender,
            TextChangedEventArgs e)
        {
            ShowContents();
        }
        private void LongestButton_Click(object sender, RoutedEventArgs e)
        {
            IContent longestContent = felulet.GetLongestContent();

            if (longestContent == null)
            {
                Eredmenyek.Text = "Nincs tartalom a felületen.";
            }
            else
            {
                Eredmenyek.Text ="Leghosszabb: " +longestContent.Title +" (" +
                    longestContent.Length +" perc)";
            }
        }
    }
}