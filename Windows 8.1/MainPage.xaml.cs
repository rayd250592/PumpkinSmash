using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Graphics.Display;
using Windows.UI.Popups;
using Windows.Storage;
using Windows.Media;



// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace egghunt
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 
    
  

    public sealed partial class MainPage : Page
    {

       int score = 0;
     
       
   
        public MainPage()
        {
            this.InitializeComponent();
            

        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }


        private void Button_GotFocus(object sender, PointerRoutedEventArgs e)
        {

         

        }

        private async void Image_PointerPressed_1(object sender, PointerRoutedEventArgs e)
        {


            
            var bounds = Window.Current.Bounds;

        

            double height = bounds.Height;
            double width = bounds.Width;

            int iheight = Convert.ToInt32(height);
            int iwidth = Convert.ToInt32(width);

            

            Random no = new Random();
            int x = no.Next(iheight, iwidth);
            int y = no.Next(iheight, iwidth);
            int eggs = no.Next(1, 50);

           

          
            
            string sx = Convert.ToString(x);
            string sy = Convert.ToString(y);

            
            TranslateTransform posTransform = new TranslateTransform();
            posTransform.X = (iwidth  - x);
            posTransform.Y = (iheight - y);

            egg.RenderTransform = posTransform;

         




            score++;

           
            result.Text = Convert.ToString(score);

            if (score == 20)
            {


                var messageDialog2 = new MessageDialog("You have smashed all the pumpkins");
                await messageDialog2.ShowAsync();
                score = 0;
                result.Text = Convert.ToString(score);
                

            }

            
            
        }

        public void incriment(int no1)
        {
            
            no1 = no1++;

        }

       


    }
}
