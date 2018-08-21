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
    /// Interaction logic for StoryBlock.xaml
    /// </summary>
    public partial class StoryBlock : Window
    {

        public Boolean addMode { set; get; }

        public StoryBlock()
        {
            InitializeComponent();



        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            btnAddUpdate.Content = addMode ? "Add" : "Update";

        }

        private void btnAddUpdate_Click(object sender, RoutedEventArgs e)
        {
            // add or update story block

            var context = new GBDBContext();

            GBStoryBlock storyBlock = new GBStoryBlock() { Text = txtStoryBlock.Text };
            context.GBStoryBlocks.Add(storyBlock);
            context.SaveChanges();

            addMode = false;


        }
    }
}
