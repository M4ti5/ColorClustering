using ColorClustering;
using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace GUIColorClustering {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        private String pathImage;

        public MainWindow () {
            InitializeComponent();
        }

        private void ImportButton_Click (object sender , RoutedEventArgs e) {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Title = "Select an image";
            openFile.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";

            if (openFile.ShowDialog() == true) {
                importImage.Source = new BitmapImage(new Uri(openFile.FileName));

                pathImage = openFile.FileName;

                runBotton.IsEnabled = true; //To be runable

                //Fill correctly the image
                if (importImage.Source.Height > importImage.Source.Width) {
                    importImage.Stretch = Stretch.UniformToFill;
                } else {
                    importImage.Stretch = Stretch.Uniform;
                }

                // Hide the rectangle
                if (importImage.Source != null) {
                    importRectangle.Fill = null;
                }
            }

        }


        private void RunButton_Click (object sender , RoutedEventArgs e) {

            runBotton.IsEnabled = false;

            Image myImage = new Image(pathImage);

            if (DBScanTab.IsSelected) {
                DBScan dBScan = new(myImage , int.Parse(minimalSizeofGroupTextBox.Text) , int.Parse(distanceTextBox.Text));
                exportImage.Source = ImageTools.BitmapToImageSource(dBScan.Draw());
            } else {
                KMeans kMeans = new KMeans(myImage , (byte)int.Parse(numberClustersTextBox.Text) , int.Parse(numberInterationsTextBox.Text) , distanceMethod.SelectedItem.ToString());

                exportImage.Source = ImageTools.BitmapToImageSource(kMeans.Draw());
            }
            

            //Fill correctly the image
            if (exportImage.Source.Height > exportImage.Source.Width) {
                exportImage.Stretch = Stretch.UniformToFill;
            } else {
                exportImage.Stretch = Stretch.Uniform;
            }

            //Hide the rectangle
            if (exportImage.Source != null) {
                exportRectangle.Fill = null;
            }

            runBotton.IsEnabled = true;
        }


        private void ExportButton_Click (object sender , RoutedEventArgs e) {

        }

        private void numberClustersTextBoxChanged (object sender , System.Windows.Controls.TextChangedEventArgs e) {
            if (numberClustersTextBox.Text != "") {

                if (int.Parse(numberClustersTextBox.Text) <= 0) {
                    numberClustersTextBox.Text = "1";
                } else if (int.Parse(numberClustersTextBox.Text) > 255) {
                    numberClustersTextBox.Text = "255";
                }
            }
        }

        private void numberInterationsTextBoxChanged (object sender , System.Windows.Controls.TextChangedEventArgs e) {
            if (numberInterationsTextBox.Text != "") {
                if (int.Parse(numberInterationsTextBox.Text) <= 0) {
                    numberInterationsTextBox.Text = "1";
                } else if (int.Parse(numberInterationsTextBox.Text) > 500) {
                    numberInterationsTextBox.Text = "500";
                }
            }
        }

        private void minimalSizeofGroupTextBoxChanged (object sender , System.Windows.Controls.TextChangedEventArgs e) {
            if (minimalSizeofGroupTextBox.Text != "") {

                if (int.Parse(minimalSizeofGroupTextBox.Text) <= 0) {
                    minimalSizeofGroupTextBox.Text = "1";
                } else if (int.Parse(minimalSizeofGroupTextBox.Text) > 1000) {
                    minimalSizeofGroupTextBox.Text = "999";
                }
            }
        }

        private void distanceTextBoxChanged (object sender , System.Windows.Controls.TextChangedEventArgs e) {
            if (distanceTextBox.Text != "") {
                if (int.Parse(distanceTextBox.Text) <= 0) {
                    distanceTextBox.Text = "1";
                } else if (int.Parse(distanceTextBox.Text) > 362) {
                    distanceTextBox.Text = "361";
                }
            }
        }

        private void ComboBox_SelectionChanged (object sender , System.Windows.Controls.SelectionChangedEventArgs e) {

        }
    }
}
