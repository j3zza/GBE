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

namespace GameBookEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public class Person
        {
            public string firstName { get; set; }
            public string lastName { get; set; }


        }



        public List<Person> People = new List<Person>();




        public MainWindow()
        {
            InitializeComponent();

            this.Title = "GameBookEditor v1.0";


            var context = new GBDBContext();

            GBStoryBlock storyBlock = context.GBStoryBlocks.Where(b => b.Id.Equals(1)).FirstOrDefault();


            //cboStoryBlocks.ItemsSource = context.GBStoryBlocks;

            People.Add(new Person{ firstName = "fred", lastName = "smith" });
            People.Add(new Person { firstName = "bill", lastName = "jones" });


            cboStoryBlocks.ItemsSource = People;







        }

        private void btnNewStoryBlock_Click(object sender, RoutedEventArgs e)
        {

            StoryBlock frmStoryBlock = new StoryBlock();
            frmStoryBlock.addMode = true;
            frmStoryBlock.Show();



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {




        }
    }
}
