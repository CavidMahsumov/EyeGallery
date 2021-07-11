using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Windows;
using static System.Net.Mime.MediaTypeNames;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Images> Imagess { get; set; }
        public Images image { get; set; }
        public int index { get; set; }
        public MainWindow()
        {
            Imagess = new List<Images>
            {
                new Images
                {
                    Name="Mona Lisa",
                     ImagePath="Images/MonaLisa.jpg",
                      Author=" Leonardo Da Vinci,",
                      Price=$"10000$",
                     Date=new DateTime(1999,02,01),

                      Description="Painted between 1503 and 1517, Da Vinci’s alluring portrait has been dogged by two questions since the day it was made: Who’s the subject and why is she smiling? A number of theories for the former have been proffered over the years: That she’s the wife of the Florentine merchant Francesco di Bartolomeo del Giocondo (ergo, the work’s alternative title, La Gioconda); that she's Leonardo’s mother, Caterina, conjured from Leonardo's boyhood memories of her; and finally, that it's a self-portrait in drag. As for that famous smile, its enigmatic quality has driven people crazy for centuries. Whatever the reason, Mona Lisa’s look of preternatural calm comports with the idealized landscape behind her, which dissolves into the distance through Leonardo’s use of atmospheric perspective."
                },
                new Images
                {
                    Name="Girl with a Pearl Earning",
                     ImagePath="Images/Girl with a Pearl Earning.jpg",
                     Author="Johannes Vermeer",
                     Price=$"50000$",
                     Date=new DateTime(1879,02,01),

                     Description="Johannes Vermeer’s 1665 study of a young woman is startlingly real and startlingly modern, almost as if it were a photograph. This gets into the debate over whether or not Vermeer employed a pre-photographic device called a camera obscura to create the image. Leaving that aside, the sitter is unknown, though it’s been speculated that she might have been Vermeer's maid. He portrays her looking over her shoulder, locking her eyes with the viewer as if attempting to establish an intimate connection across the centuries. Technically speaking, Girl isn’t a portrait, but rather an example of the Dutch genre called a tronie—a headshot meant more as still life of facial features than as an attempt to capture a likeness."
                },
                new Images
                {
                    Name="in Grey and Black",
                     ImagePath="Images/in Grey and Black.jpg",
                     Author="James Abbott McNeill Whistler",
                     Price=$"50500$",
                     Date=new DateTime(1786,02,01),

                     Description="Whistler’s Mother, or Arrangement in Grey and Black No. 1, as it’s actually titled, speaks to the artist’s ambition to pursue art for art’s sake. James Abbott McNeill Whistler painted the work in his London studio in 1871, and in it, the formality of portraiture becomes an essay in form. Whistler’s mother Anna is pictured as one of several elements locked into an arrangement of right angles. Her severe expression fits in with the rigidity of the composition, and it’s somewhat ironic to note that despite Whistler’s formalist intentions, the painting became a symbol of motherhood"
                },
                new Images
                {
                    Name="The Arnolfini Portrait",
                     ImagePath="Images/The Arnolfini Portrait.jpg",
                     Author=" Jan van Eyck",
                     Price=$"60500$",
                     Date=new DateTime(1939,02,01),

                     Description="One of the most significant works produced during the Northern Renaissance, this composition is believed to be one of the first paintings executed in oils. A full-length double portrait, it reputedly portrays an Italian merchant and a woman who may or may not be his bride. In 1934, the celebrated art historian Erwin Panofsky proposed that the painting is actually a wedding contract. What can be reliably said is that the piece is one of the first depictions of an interior using orthogonal perspective to create a sense of space that seems contiguous with the viewer’s own; it feels like a painting you could step into"

                },
                 new Images
                {
                    Name="The Harvest",
                     ImagePath="Images/The Harvest.jpg",
                    Author="Pieter Bruegel the Elder ",
                     Price=$"3040$",
                     Date=new DateTime(1945,02,01),

                    Description="Bruegel’s fanfare for the common man is considered one of the defining works of Western art. This composition was one of six created on the theme of the seasons. The time is probably early September. A group of peasants on the left cut and bundle ripened wheat, while the on the right, another group takes their midday meal. One figure is sacked out under a tree with his pants unbuttoned. This attention to detail continues throughout the painting as a procession of ever-granular observations receding into space. It was extraordinary for a time when landscapes served mostly as backdrops for religious paintings."
                },

                 new Images
                {
                    Name=" A Sunday Afternoon on the Island of La Grande Jatte",
                     ImagePath="Images/Georges.jpg"
                    ,
                     Author="Georges Seurat",
                     Price=$"30200$",
                     Date=new DateTime(1982,02,01),

                     Description="Georges Seurat’s masterpiece, evoking the Paris of La Belle Epoque, is actually depicting a working-class suburban scene well outside the city’s center. Seurat often made this milieu his subject, which differed from the bourgeois portrayals of his Impressionist contemporaries. Seurat abjured the capture-the-moment approach of Manet, Monet and Degas, going instead for the sense of timeless permanence found in Greek sculpture. And that is exactly what you get in this frieze-like processional of figures whose stillness is in keeping with Seurat’s aim of creating a classical landscape in modern form"
                },
                 new Images
                {
                    Name="Wanderer above the Sea of Fog",
                     ImagePath="Images/Caspar.jpg",
                     Author=" Caspar David Friedrich",
                     Price=$"50000$",
                     Date=new DateTime(1928,11,20),

                     Description="The worship of nature, or more precisely, the feeling of awe it inspired, was a signature of the Romantic style in art, and there is no better example on that score than this image of a hiker in the mountains, pausing on a rocky outcrop to take in his surroundings. His back is turned towards the viewer as if he were too enthralled with the landscape to turn around, but his pose offers a kind of over-the-shoulder view that draws us into vista as if we were seeing it through his eyes."
                },
                 new Images
                {
                    Name="Nighthawks",
                     ImagePath="Images/Edward.jpg",
                     Author="Edward Hopper",
                     Price=$"8010$",
                     Date=new DateTime(1921,05,12),

                     Description="An iconic depiction of urban isolation, Nighthawks depicts a quarter of characters at night inside a greasy spoon with an expansive wraparound window that almost takes up the entire facade of the diner. Its brightly lit interior—the only source of illumination for the scene—floods the sidewalk and the surrounding buildings, which are otherwise dark. The restaurant's glass exterior creates a display-case effect that heightens the sense that the subjects (three customers and a counterman) are alone together. It's a study of alienation as the figures studiously ignore each other while losing themselves in a state of reverie or exhaustion. The diner was based on a long-demolished one in Hopper's Greenwich Village neighborhood, and some art historians have suggested that the painting as a whole may have been inspired by Vincent van Gogh’s Café Terrace at Night, which was on exhibit at a gallery Hopper frequented at same time he painted Nighthawks Also of note: The redheaded woman on the far right is the artist's wife Jo, who frequently modeled for him."
                },
                 new Images
                {
                    Name="The Arnolfini Portrait",
                     ImagePath="Images/image.jpg",
                     Author="Jan van Eyck",
                     Price=$"52000$",
                     Date=new DateTime(1926,03,11),

                     Description="One of the most significant works produced during the Northern Renaissance, this composition is believed to be one of the first paintings executed in oils. A full-length double portrait, it reputedly portrays an Italian merchant and a woman who may or may not be his bride. In 1934, the celebrated art historian Erwin Panofsky proposed that the painting is actually a wedding contract. What can be reliably said is that the piece is one of the first depictions of an interior using orthogonal perspective to create a sense of space that seems contiguous with the viewer’s own; it feels like a painting you could step into."
                },
                new Images
                {
                    Name="Nude Descending a Staircase",
                     ImagePath="Images/mARCEL.jpg",
                     Author="Marcel Duchamp",
                     Price=$"42400$",
                     Date=new DateTime(1999,02,14),

                     Description="One of the most significant works produced during the Northern Renaissance, this composition is believed to be one of the first paintings executed in oils. A full-length double portrait, it reputedly portrays an Italian merchant and a woman who may or may not be his bride. In 1934, the celebrated art historian Erwin Panofsky proposed that the painting is actually a wedding contract. What can be reliably said is that the piece is one of the first depictions of an interior using orthogonal perspective to create a sense of space that seems contiguous with the viewer’s own; it feels like a painting you could step into."
                },

            };
            this.DataContext = this;

            InitializeComponent();
        }

        private void Listbox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if(Listbox.SelectedItem is Images item){
                SecondPage secondPage = new SecondPage();
               secondPage.image = item;
                secondPage.index = Listbox.SelectedIndex;
                secondPage.copyImage = Imagess;
                secondPage.nametextblock.Text = item.Name;
                secondPage.MainImage.Source = new BitmapImage(new Uri(item.ImagePath, UriKind.RelativeOrAbsolute));
                secondPage.Pricetextbloxk.Text = item.Price;
                secondPage.Authortextbloxk.Text = item.Author;
                secondPage.DateTextblock.Text = item.Date.ToString();
                secondPage.Descriptiontextblock.Text = item.Description;
                secondPage.ShowDialog();

            }
        }
           

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["ButtonFS"] = 50.0;
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            this.Resources["ButtonFS"] = 250.0;
             
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {

            this.Resources["ButtonFS"] = 150.0;
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            AboutWindow aboutWindow = new AboutWindow();
            aboutWindow.ShowDialog();
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            Close();
        }
        protected override void OnSourceInitialized(EventArgs e)
        {
            IconHelper.RemoveIcon(this);
        }



        public static class IconHelper
        {
            [DllImport("user32.dll")]
            static extern int GetWindowLong(IntPtr hwnd, int index);



            [DllImport("user32.dll")]
            static extern int SetWindowLong(IntPtr hwnd, int index, int newStyle);



            [DllImport("user32.dll")]
            static extern bool SetWindowPos(IntPtr hwnd, IntPtr hwndInsertAfter,
            int x, int y, int width, int height, uint flags);



            [DllImport("user32.dll")]
            static extern IntPtr SendMessage(IntPtr hwnd, uint msg,
            IntPtr wParam, IntPtr lParam);
            const int GWL_EXSTYLE = -20;
            const int WS_EX_DLGMODALFRAME = 0x0001;
            const int SWP_NOSIZE = 0x0001;
            const int SWP_NOMOVE = 0x0002;
            const int SWP_NOZORDER = 0x0004;
            const int SWP_FRAMECHANGED = 0x0020;
            const uint WM_SETICON = 0x0080;
            public static void RemoveIcon(Window window)
            {
                IntPtr hwnd = new WindowInteropHelper(window).Handle;
                int extendedStyle = GetWindowLong(hwnd, GWL_EXSTYLE);
                SetWindowLong(hwnd, GWL_EXSTYLE, extendedStyle | WS_EX_DLGMODALFRAME);
                SetWindowPos(hwnd, IntPtr.Zero, 0, 0, 0, 0, SWP_NOMOVE |
                SWP_NOSIZE | SWP_NOZORDER | SWP_FRAMECHANGED);
            }
        }
    }
}
