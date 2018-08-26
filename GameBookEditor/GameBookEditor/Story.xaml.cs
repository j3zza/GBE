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
using System.Windows.Shapes;

namespace GameBookEditor
{
    /// <summary>
    /// Interaction logic for Story.xaml
    /// </summary>
    public partial class Story : Window
    {
        public Boolean addMode { set; get; }

        public Story()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            btnAddUpdate.Content = addMode ? "Add" : "Update";

        }


        private void btnAddUpdate_Click(object sender, RoutedEventArgs e)
        {
            var context = new GBDBContext();

            GBStory story = new GBStory() { Title = txtTitle.Text };
            context.GBStory.Add(story);
            context.SaveChanges();

            addMode = false;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
