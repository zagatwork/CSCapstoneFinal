using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace CSCapstoneFinal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int TabOneIterationCounter = 0;
        private int TabTwoIterationCounter = 0;
        private int TabThreeIterationCounter = 0;
        private bool haltAll = false;

        public MainWindow()
        {
            InitializeComponent();
        }



        //increasses the thickness of the line the mouse is hovering over aiding the user in being able to see that they are over a line.
        public void Highlight(object sender, MouseEventArgs e)
        {
            Line HighlightLine = new Line();
            HighlightLine = e.Source as Line;
            HighlightLine.StrokeThickness = 5;
        }


        //restores the origional thickness of the line as soon as the user is no longer over the line.
        public void UnHighlight(object sender, MouseEventArgs e)
        {
            Line UnHighlightLine = new Line();
            UnHighlightLine = e.Source as Line;
            UnHighlightLine.StrokeThickness = 2;
        }

        // edgeClickTabOne(object sender, MouseButtonEventArgs e)
        //---------------------------------------------------------------------------------------------------------------------
        // This function detects when a user presses the left mouse button while hovering over a line. This function takes 
        // paramaters of the Line clicked on as well as the click its-self. 
        public void EdgeClickTabOne(object sender, MouseButtonEventArgs e)
        {
            if(haltAll == false)
            {
                haltAll = true;
                Line tempLine = new Line();
                tempLine = e.Source as Line;

                TabOneIterationCounter++;
                confidenceTabOne(TabOneIterationCounter);

                colorVerticesTabOne(tempLine, 1000);
            }
        }
        public void EdgeClickTabTwo(object sender, MouseButtonEventArgs e)
        {
            if (haltAll == false)
            {
                haltAll = true;
                Line tempLine = new Line();
                tempLine = e.Source as Line;

                TabTwoIterationCounter++;
                confidenceTabTwo(TabTwoIterationCounter);

                colorVerticesTabTwo(tempLine, 1000);
            }
        }
        public void EdgeClickTabThree(object sender, MouseButtonEventArgs e)
        {
            if (haltAll == false)
            {
                haltAll = true;
                Line tempLine = new Line();
                tempLine = e.Source as Line;

                TabThreeIterationCounter++;
                confidenceTabThree(TabThreeIterationCounter);

                colorVerticesTabThree(tempLine, 1000);
            }
        }

        // autoRunTabOne(object sender, RoutedEventArgs e)
        //---------------------------------------------------------------------------------------------------------------------
        // This fuction will set up and excecute the auto-run feature of the software. This will default to 100 iterations of 
        // the autorun.
        public void autoRunTabOne(object sender, RoutedEventArgs e)
        {
            if (haltAll == false)
            {
                haltAll = true;
                Slider tempSlider = new Slider();

                tempSlider = tabOneSpeed;

                double delay;
                delay = tempSlider.Value;

                colorVerticesTabOne(delay);
            }

        }
        public void autoRunTabTwo(object sender, RoutedEventArgs e)
        {
            if (haltAll == false)
            {
                haltAll = true;
                Slider tempSlider = new Slider();

                tempSlider = tabTwoSpeed;

                double delay;
                delay = tempSlider.Value;

                colorVerticesTabTwo(delay);
            }

        }
        public void autoRunTabThree(object sender, RoutedEventArgs e)
        {
            if (haltAll == false)
            {
                haltAll = true;
                Slider tempSlider = new Slider();

                tempSlider = tabThreeSpeed;

                double delay;
                delay = tempSlider.Value;

                colorVerticesTabThree(delay);
            }

        }

        // colorVerticesTabOne(Line toColor, double delayTime)
        //---------------------------------------------------------------------------------------------------------------------
        // This function will set up and color the tow vertices attached to the chosen line. It will automatically pause for a
        // second and then revert the colors back to black.
        public async void colorVerticesTabOne(Line toColor, double delayTimeTabOne)
        {
            Ellipse tempEllipse1 = new Ellipse();
            Ellipse tempEllipse2 = new Ellipse();
            SolidColorBrush mySolidColorBrush1 = new SolidColorBrush();
            SolidColorBrush mySolidColorBrush2 = new SolidColorBrush();

            String nameLine = toColor.Name;

            switch (nameLine)
            {
                case "Edge101":
                    tempEllipse1 = Vertex101;
                    tempEllipse2 = Vertex102;
                    break;
                case "Edge102":
                    tempEllipse1 = Vertex102;
                    tempEllipse2 = Vertex103;
                    break;
                case "Edge103":
                    tempEllipse1 = Vertex103;
                    tempEllipse2 = Vertex104;
                    break;
                case "Edge104":
                    tempEllipse1 = Vertex104;
                    tempEllipse2 = Vertex105;
                    break;
                case "Edge105":
                    tempEllipse1 = Vertex105;
                    tempEllipse2 = Vertex101;
                    break;
                case "Edge106":
                    tempEllipse1 = Vertex101;
                    tempEllipse2 = Vertex106;
                    break;
                case "Edge107":
                    tempEllipse1 = Vertex102;
                    tempEllipse2 = Vertex107;
                    break;
                case "Edge108":
                    tempEllipse1 = Vertex103;
                    tempEllipse2 = Vertex108;
                    break;
                case "Edge109":
                    tempEllipse1 = Vertex104;
                    tempEllipse2 = Vertex109;
                    break;
                case "Edge110":
                    tempEllipse1 = Vertex105;
                    tempEllipse2 = Vertex110;
                    break;
                case "Edge111":
                    tempEllipse1 = Vertex106;
                    tempEllipse2 = Vertex107;
                    break;
                case "Edge112":
                    tempEllipse1 = Vertex107;
                    tempEllipse2 = Vertex108;
                    break;
                case "Edge113":
                    tempEllipse1 = Vertex108;
                    tempEllipse2 = Vertex109;
                    break;
                case "Edge114":
                    tempEllipse1 = Vertex110;
                    tempEllipse2 = Vertex109;
                    break;
                case "Edge115":
                    tempEllipse1 = Vertex106;
                    tempEllipse2 = Vertex110;
                    break;
            }

            int temp = new Random().Next(1, 4);

            switch (temp)
            {
                case 1:
                    int temp2 = new Random().Next(2, 4);

                    switch (temp2)
                    {
                        case 2:
                            mySolidColorBrush1.Color = Color.FromArgb(255, 255, 0, 0);
                            mySolidColorBrush2.Color = Color.FromArgb(255, 0, 255, 0);
                            break;
                        case 3:
                            mySolidColorBrush1.Color = Color.FromArgb(255, 255, 0, 0);
                            mySolidColorBrush2.Color = Color.FromArgb(255, 0, 0, 255);
                            break;
                    }
                    break;
                case 2:
                    int temp3 = new Random().Next(2, 4);

                    switch (temp3)
                    {
                        case 2:
                            mySolidColorBrush1.Color = Color.FromArgb(255, 0, 255, 0);
                            mySolidColorBrush2.Color = Color.FromArgb(255, 255, 0, 0);
                            break;
                        case 3:
                            mySolidColorBrush1.Color = Color.FromArgb(255, 0, 255, 0);
                            mySolidColorBrush2.Color = Color.FromArgb(255, 0, 0, 255);
                            break;
                    }
                    break;
                case 3:
                    int temp4 = new Random().Next(2, 4);

                    switch (temp4)
                    {
                        case 2:
                            mySolidColorBrush1.Color = Color.FromArgb(255, 0, 0, 255);
                            mySolidColorBrush2.Color = Color.FromArgb(255, 255, 0, 0);
                            break;
                        case 3:
                            mySolidColorBrush1.Color = Color.FromArgb(255, 0, 0, 255);
                            mySolidColorBrush2.Color = Color.FromArgb(255, 0, 255, 0);
                            break;
                    }
                    break;
            }

            tempEllipse1.Fill = mySolidColorBrush1;
            tempEllipse2.Fill = mySolidColorBrush2;

            int delayTimeXTabOne = (int)delayTimeTabOne;
            await Task.Delay(delayTimeXTabOne);

            SolidColorBrush mySolidColorBrush = new SolidColorBrush();
            mySolidColorBrush.Color = Color.FromArgb(255, 0, 0, 0);

            tempEllipse1.Fill = mySolidColorBrush;
            tempEllipse2.Fill = mySolidColorBrush;
            haltAll = false;
        }
        public async void colorVerticesTabTwo(Line toColor, double delayTimeTabTwo)
        {
            Ellipse tempEllipse1 = new Ellipse();
            Ellipse tempEllipse2 = new Ellipse();
            SolidColorBrush mySolidColorBrush1 = new SolidColorBrush();
            SolidColorBrush mySolidColorBrush2 = new SolidColorBrush();

            String nameLine = toColor.Name;

            switch (nameLine)
            {
                case "Edge201":
                    tempEllipse1 = Vertex201;
                    tempEllipse2 = Vertex202;
                    break;
                case "Edge202":
                    tempEllipse1 = Vertex202;
                    tempEllipse2 = Vertex203;
                    break;
                case "Edge203":
                    tempEllipse1 = Vertex203;
                    tempEllipse2 = Vertex204;
                    break;
                case "Edge204":
                    tempEllipse1 = Vertex204;
                    tempEllipse2 = Vertex205;
                    break;
                case "Edge205":
                    tempEllipse1 = Vertex205;
                    tempEllipse2 = Vertex206;
                    break;
                case "Edge206":
                    tempEllipse1 = Vertex201;
                    tempEllipse2 = Vertex206;
                    break;
                case "Edge207":
                    tempEllipse1 = Vertex201;
                    tempEllipse2 = Vertex203;
                    break;
                case "Edge208":
                    tempEllipse1 = Vertex202;
                    tempEllipse2 = Vertex206;
                    break;
                case "Edge209":
                    tempEllipse1 = Vertex202;
                    tempEllipse2 = Vertex204;
                    break;
                case "Edge210":
                    tempEllipse1 = Vertex203;
                    tempEllipse2 = Vertex205;
                    break;
                case "Edge211":
                    tempEllipse1 = Vertex204;
                    tempEllipse2 = Vertex206;
                    break;
                case "Edge212":
                    tempEllipse1 = Vertex205;
                    tempEllipse2 = Vertex201;
                    break;
            }

            int temp = new Random().Next(1, 4);

            switch (temp)
            {
                case 1:
                    int temp2 = new Random().Next(2, 4);

                    switch (temp2)
                    {
                        case 2:
                            mySolidColorBrush1.Color = Color.FromArgb(255, 255, 0, 0);
                            mySolidColorBrush2.Color = Color.FromArgb(255, 0, 255, 0);
                            break;
                        case 3:
                            mySolidColorBrush1.Color = Color.FromArgb(255, 255, 0, 0);
                            mySolidColorBrush2.Color = Color.FromArgb(255, 0, 0, 255);
                            break;
                    }
                    break;
                case 2:
                    int temp3 = new Random().Next(2, 4);

                    switch (temp3)
                    {
                        case 2:
                            mySolidColorBrush1.Color = Color.FromArgb(255, 0, 255, 0);
                            mySolidColorBrush2.Color = Color.FromArgb(255, 255, 0, 0);
                            break;
                        case 3:
                            mySolidColorBrush1.Color = Color.FromArgb(255, 0, 255, 0);
                            mySolidColorBrush2.Color = Color.FromArgb(255, 0, 0, 255);
                            break;
                    }
                    break;
                case 3:
                    int temp4 = new Random().Next(2, 4);

                    switch (temp4)
                    {
                        case 2:
                            mySolidColorBrush1.Color = Color.FromArgb(255, 0, 0, 255);
                            mySolidColorBrush2.Color = Color.FromArgb(255, 255, 0, 0);
                            break;
                        case 3:
                            mySolidColorBrush1.Color = Color.FromArgb(255, 0, 0, 255);
                            mySolidColorBrush2.Color = Color.FromArgb(255, 0, 255, 0);
                            break;
                    }
                    break;
            }

            tempEllipse1.Fill = mySolidColorBrush1;
            tempEllipse2.Fill = mySolidColorBrush2;

            int delayTimeXTabTwo = (int)delayTimeTabTwo;
            await Task.Delay(delayTimeXTabTwo);

            SolidColorBrush mySolidColorBrush = new SolidColorBrush();
            mySolidColorBrush.Color = Color.FromArgb(255, 0, 0, 0);

            tempEllipse1.Fill = mySolidColorBrush;
            tempEllipse2.Fill = mySolidColorBrush;
            haltAll = false;
        }
        public async void colorVerticesTabThree(Line toColor, double delayTimeTabThree)
        {
            Ellipse tempEllipse1 = new Ellipse();
            Ellipse tempEllipse2 = new Ellipse();
            SolidColorBrush mySolidColorBrush1 = new SolidColorBrush();
            SolidColorBrush mySolidColorBrush2 = new SolidColorBrush();

            String nameLine = toColor.Name;

            switch (nameLine)
            {
                case "Edge301":
                    tempEllipse1 = Vertex301;
                    tempEllipse2 = Vertex302;
                    break;
                case "Edge302":
                    tempEllipse1 = Vertex302;
                    tempEllipse2 = Vertex303;
                    break;
                case "Edge303":
                    tempEllipse1 = Vertex303;
                    tempEllipse2 = Vertex304;
                    break;
                case "Edge304":
                    tempEllipse1 = Vertex304;
                    tempEllipse2 = Vertex305;
                    break;
                case "Edge305":
                    tempEllipse1 = Vertex305;
                    tempEllipse2 = Vertex306;
                    break;
                case "Edge306":
                    tempEllipse1 = Vertex306;
                    tempEllipse2 = Vertex307;
                    break;
                case "Edge307":
                    tempEllipse1 = Vertex307;
                    tempEllipse2 = Vertex308;
                    break;
                case "Edge308":
                    tempEllipse1 = Vertex308;
                    tempEllipse2 = Vertex301;
                    break;
                case "Edge309":
                    tempEllipse1 = Vertex301;
                    tempEllipse2 = Vertex309;
                    break;
                case "Edge310":
                    tempEllipse1 = Vertex302;
                    tempEllipse2 = Vertex309;
                    break;
                case "Edge311":
                    tempEllipse1 = Vertex303;
                    tempEllipse2 = Vertex310;
                    break;
                case "Edge312":
                    tempEllipse1 = Vertex304;
                    tempEllipse2 = Vertex311;
                    break;
                case "Edge313":
                    tempEllipse1 = Vertex305;
                    tempEllipse2 = Vertex312;
                    break;
                case "Edge314":
                    tempEllipse1 = Vertex306;
                    tempEllipse2 = Vertex313;
                    break;
                case "Edge315":
                    tempEllipse1 = Vertex307;
                    tempEllipse2 = Vertex314;
                    break;
                case "Edge316":
                    tempEllipse1 = Vertex308;
                    tempEllipse2 = Vertex315;
                    break;
                case "Edge317":
                    tempEllipse1 = Vertex301;
                    tempEllipse2 = Vertex315;
                    break;
                case "Edge318":
                    tempEllipse1 = Vertex309;
                    tempEllipse2 = Vertex310;
                    break;
                case "Edge319":
                    tempEllipse1 = Vertex310;
                    tempEllipse2 = Vertex311;
                    break;
                case "Edge320":
                    tempEllipse1 = Vertex311;
                    tempEllipse2 = Vertex312;
                    break;
                case "Edge321":
                    tempEllipse1 = Vertex312;
                    tempEllipse2 = Vertex313;
                    break;
                case "Edge322":
                    tempEllipse1 = Vertex313;
                    tempEllipse2 = Vertex314;
                    break;
                case "Edge323":
                    tempEllipse1 = Vertex314;
                    tempEllipse2 = Vertex315;
                    break;
                case "Edge324":
                    tempEllipse1 = Vertex309;
                    tempEllipse2 = Vertex316;
                    break;
                case "Edge325":
                    tempEllipse1 = Vertex311;
                    tempEllipse2 = Vertex316;
                    break;
                case "Edge326":
                    tempEllipse1 = Vertex313;
                    tempEllipse2 = Vertex316;
                    break;
                case "Edge327":
                    tempEllipse1 = Vertex315;
                    tempEllipse2 = Vertex316;
                    break;
            }

            int temp = new Random().Next(1, 4);

            switch (temp)
            {
                case 1:
                    int temp2 = new Random().Next(2, 4);

                    switch (temp2)
                    {
                        case 2:
                            mySolidColorBrush1.Color = Color.FromArgb(255, 255, 0, 0);
                            mySolidColorBrush2.Color = Color.FromArgb(255, 0, 255, 0);
                            break;
                        case 3:
                            mySolidColorBrush1.Color = Color.FromArgb(255, 255, 0, 0);
                            mySolidColorBrush2.Color = Color.FromArgb(255, 0, 0, 255);
                            break;
                    }
                    break;
                case 2:
                    int temp3 = new Random().Next(2, 4);

                    switch (temp3)
                    {
                        case 2:
                            mySolidColorBrush1.Color = Color.FromArgb(255, 0, 255, 0);
                            mySolidColorBrush2.Color = Color.FromArgb(255, 255, 0, 0);
                            break;
                        case 3:
                            mySolidColorBrush1.Color = Color.FromArgb(255, 0, 255, 0);
                            mySolidColorBrush2.Color = Color.FromArgb(255, 0, 0, 255);
                            break;
                    }
                    break;
                case 3:
                    int temp4 = new Random().Next(2, 4);

                    switch (temp4)
                    {
                        case 2:
                            mySolidColorBrush1.Color = Color.FromArgb(255, 0, 0, 255);
                            mySolidColorBrush2.Color = Color.FromArgb(255, 255, 0, 0);
                            break;
                        case 3:
                            mySolidColorBrush1.Color = Color.FromArgb(255, 0, 0, 255);
                            mySolidColorBrush2.Color = Color.FromArgb(255, 0, 255, 0);
                            break;
                    }
                    break;
            }

            tempEllipse1.Fill = mySolidColorBrush1;
            tempEllipse2.Fill = mySolidColorBrush2;

            int delayTimeXTabThree = (int)delayTimeTabThree;
            await Task.Delay(delayTimeXTabThree);

            SolidColorBrush mySolidColorBrush = new SolidColorBrush();
            mySolidColorBrush.Color = Color.FromArgb(255, 0, 0, 0);

            tempEllipse1.Fill = mySolidColorBrush;
            tempEllipse2.Fill = mySolidColorBrush;
            haltAll = false;
        }

        // colorVerticesTabOne(double delayTime)
        //---------------------------------------------------------------------------------------------------------------------
        // This function will set up and color the two vertices attached to the randomly chosen line. It will automatically
        // pause for the given amount of time and then revert the colors back to black. This will repeat 100 times.
        public async void colorVerticesTabOne(double delayTime)
        {
            Ellipse tempEllipse1 = new Ellipse();
            Ellipse tempEllipse2 = new Ellipse();
            SolidColorBrush mySolidColorBrush1 = new SolidColorBrush();
            SolidColorBrush mySolidColorBrush2 = new SolidColorBrush();
            Line xx1 = new Line();

            for (int z = 0; z < 100; z++)
            {
                TabOneIterationCounter++;
                confidenceTabOne(TabOneIterationCounter);

                int x1 = new Random().Next(101, 116);
                switch (x1)
                {
                    case 101:
                        xx1 = Edge101;
                        break;
                    case 102:
                        xx1 = Edge102;
                        break;
                    case 103:
                        xx1 = Edge103;
                        break;
                    case 104:
                        xx1 = Edge104;
                        break;
                    case 105:
                        xx1 = Edge105;
                        break;
                    case 106:
                        xx1 = Edge106;
                        break;
                    case 107:
                        xx1 = Edge107;
                        break;
                    case 108:
                        xx1 = Edge108;
                        break;
                    case 109:
                        xx1 = Edge109;
                        break;
                    case 110:
                        xx1 = Edge110;
                        break;
                    case 111:
                        xx1 = Edge111;
                        break;
                    case 112:
                        xx1 = Edge112;
                        break;
                    case 113:
                        xx1 = Edge113;
                        break;
                    case 114:
                        xx1 = Edge114;
                        break;
                    case 115:
                        xx1 = Edge115;
                        break;
                }

                String nameLine = xx1.Name;

                switch (nameLine)
                {
                    case "Edge101":
                        tempEllipse1 = Vertex101;
                        tempEllipse2 = Vertex102;
                        break;
                    case "Edge102":
                        tempEllipse1 = Vertex102;
                        tempEllipse2 = Vertex103;
                        break;
                    case "Edge103":
                        tempEllipse1 = Vertex103;
                        tempEllipse2 = Vertex104;
                        break;
                    case "Edge104":
                        tempEllipse1 = Vertex104;
                        tempEllipse2 = Vertex105;
                        break;
                    case "Edge105":
                        tempEllipse1 = Vertex105;
                        tempEllipse2 = Vertex101;
                        break;
                    case "Edge106":
                        tempEllipse1 = Vertex101;
                        tempEllipse2 = Vertex106;
                        break;
                    case "Edge107":
                        tempEllipse1 = Vertex102;
                        tempEllipse2 = Vertex107;
                        break;
                    case "Edge108":
                        tempEllipse1 = Vertex103;
                        tempEllipse2 = Vertex108;
                        break;
                    case "Edge109":
                        tempEllipse1 = Vertex104;
                        tempEllipse2 = Vertex109;
                        break;
                    case "Edge110":
                        tempEllipse1 = Vertex105;
                        tempEllipse2 = Vertex110;
                        break;
                    case "Edge111":
                        tempEllipse1 = Vertex106;
                        tempEllipse2 = Vertex107;
                        break;
                    case "Edge112":
                        tempEllipse1 = Vertex107;
                        tempEllipse2 = Vertex108;
                        break;
                    case "Edge113":
                        tempEllipse1 = Vertex108;
                        tempEllipse2 = Vertex109;
                        break;
                    case "Edge114":
                        tempEllipse1 = Vertex110;
                        tempEllipse2 = Vertex109;
                        break;
                    case "Edge115":
                        tempEllipse1 = Vertex106;
                        tempEllipse2 = Vertex110;
                        break;
                }

                int temp = new Random().Next(1, 4);

                switch (temp)
                {
                    case 1:
                        int temp2 = new Random().Next(2, 4);

                        switch (temp2)
                        {
                            case 2:
                                mySolidColorBrush1.Color = Color.FromArgb(255, 255, 0, 0);
                                mySolidColorBrush2.Color = Color.FromArgb(255, 0, 255, 0);
                                break;
                            case 3:
                                mySolidColorBrush1.Color = Color.FromArgb(255, 255, 0, 0);
                                mySolidColorBrush2.Color = Color.FromArgb(255, 0, 0, 255);
                                break;
                        }
                        break;
                    case 2:
                        int temp3 = new Random().Next(2, 4);

                        switch (temp3)
                        {
                            case 2:
                                mySolidColorBrush1.Color = Color.FromArgb(255, 0, 255, 0);
                                mySolidColorBrush2.Color = Color.FromArgb(255, 255, 0, 0);
                                break;
                            case 3:
                                mySolidColorBrush1.Color = Color.FromArgb(255, 0, 255, 0);
                                mySolidColorBrush2.Color = Color.FromArgb(255, 0, 0, 255);
                                break;
                        }
                        break;
                    case 3:
                        int temp4 = new Random().Next(2, 4);

                        switch (temp4)
                        {
                            case 2:
                                mySolidColorBrush1.Color = Color.FromArgb(255, 0, 0, 255);
                                mySolidColorBrush2.Color = Color.FromArgb(255, 255, 0, 0);
                                break;
                            case 3:
                                mySolidColorBrush1.Color = Color.FromArgb(255, 0, 0, 255);
                                mySolidColorBrush2.Color = Color.FromArgb(255, 0, 255, 0);
                                break;
                        }
                        break;
                }

                tempEllipse1.Fill = mySolidColorBrush1;
                tempEllipse2.Fill = mySolidColorBrush2;

                int delayTimeX = (int)delayTime;
                await Task.Delay(delayTimeX);

                SolidColorBrush mySolidColorBrush = new SolidColorBrush();
                mySolidColorBrush.Color = Color.FromArgb(255, 0, 0, 0);

                tempEllipse1.Fill = mySolidColorBrush;
                tempEllipse2.Fill = mySolidColorBrush;
            }
            haltAll = false;
        }
        public async void colorVerticesTabTwo(double delayTime)
        {
            Ellipse tempEllipse1 = new Ellipse();
            Ellipse tempEllipse2 = new Ellipse();
            SolidColorBrush mySolidColorBrush1 = new SolidColorBrush();
            SolidColorBrush mySolidColorBrush2 = new SolidColorBrush();
            Line xx2 = new Line();

            for (int z = 0; z < 100; z++)
            {
                TabTwoIterationCounter++;
                confidenceTabTwo(TabTwoIterationCounter);

                int x2 = new Random().Next(101, 113);
                switch (x2)
                {
                    case 101:
                        xx2 = Edge201;
                        break;
                    case 102:
                        xx2 = Edge202;
                        break;
                    case 103:
                        xx2 = Edge203;
                        break;
                    case 104:
                        xx2 = Edge204;
                        break;
                    case 105:
                        xx2 = Edge205;
                        break;
                    case 106:
                        xx2 = Edge206;
                        break;
                    case 107:
                        xx2 = Edge207;
                        break;
                    case 108:
                        xx2 = Edge208;
                        break;
                    case 109:
                        xx2 = Edge209;
                        break;
                    case 110:
                        xx2 = Edge210;
                        break;
                    case 111:
                        xx2 = Edge211;
                        break;
                    case 112:
                        xx2 = Edge212;
                        break;
                }

                String nameLine = xx2.Name;

                switch (nameLine)
                {
                    case "Edge201":
                        tempEllipse1 = Vertex201;
                        tempEllipse2 = Vertex202;
                        break;
                    case "Edge202":
                        tempEllipse1 = Vertex202;
                        tempEllipse2 = Vertex203;
                        break;
                    case "Edge203":
                        tempEllipse1 = Vertex203;
                        tempEllipse2 = Vertex204;
                        break;
                    case "Edge204":
                        tempEllipse1 = Vertex204;
                        tempEllipse2 = Vertex205;
                        break;
                    case "Edge205":
                        tempEllipse1 = Vertex205;
                        tempEllipse2 = Vertex206;
                        break;
                    case "Edge206":
                        tempEllipse1 = Vertex201;
                        tempEllipse2 = Vertex206;
                        break;
                    case "Edge207":
                        tempEllipse1 = Vertex201;
                        tempEllipse2 = Vertex203;
                        break;
                    case "Edge208":
                        tempEllipse1 = Vertex202;
                        tempEllipse2 = Vertex206;
                        break;
                    case "Edge209":
                        tempEllipse1 = Vertex202;
                        tempEllipse2 = Vertex204;
                        break;
                    case "Edge210":
                        tempEllipse1 = Vertex203;
                        tempEllipse2 = Vertex205;
                        break;
                    case "Edge211":
                        tempEllipse1 = Vertex204;
                        tempEllipse2 = Vertex206;
                        break;
                    case "Edge212":
                        tempEllipse1 = Vertex205;
                        tempEllipse2 = Vertex201;
                        break;
                }

                int temp = new Random().Next(1, 4);

                switch (temp)
                {
                    case 1:
                        int temp2 = new Random().Next(2, 4);

                        switch (temp2)
                        {
                            case 2:
                                mySolidColorBrush1.Color = Color.FromArgb(255, 255, 0, 0);
                                mySolidColorBrush2.Color = Color.FromArgb(255, 0, 255, 0);
                                break;
                            case 3:
                                mySolidColorBrush1.Color = Color.FromArgb(255, 255, 0, 0);
                                mySolidColorBrush2.Color = Color.FromArgb(255, 0, 0, 255);
                                break;
                        }
                        break;
                    case 2:
                        int temp3 = new Random().Next(2, 4);

                        switch (temp3)
                        {
                            case 2:
                                mySolidColorBrush1.Color = Color.FromArgb(255, 0, 255, 0);
                                mySolidColorBrush2.Color = Color.FromArgb(255, 255, 0, 0);
                                break;
                            case 3:
                                mySolidColorBrush1.Color = Color.FromArgb(255, 0, 255, 0);
                                mySolidColorBrush2.Color = Color.FromArgb(255, 0, 0, 255);
                                break;
                        }
                        break;
                    case 3:
                        int temp4 = new Random().Next(2, 4);

                        switch (temp4)
                        {
                            case 2:
                                mySolidColorBrush1.Color = Color.FromArgb(255, 0, 0, 255);
                                mySolidColorBrush2.Color = Color.FromArgb(255, 255, 0, 0);
                                break;
                            case 3:
                                mySolidColorBrush1.Color = Color.FromArgb(255, 0, 0, 255);
                                mySolidColorBrush2.Color = Color.FromArgb(255, 0, 255, 0);
                                break;
                        }
                        break;
                }

                tempEllipse1.Fill = mySolidColorBrush1;
                tempEllipse2.Fill = mySolidColorBrush2;

                int delayTimeX = (int)delayTime;
                await Task.Delay(delayTimeX);

                SolidColorBrush mySolidColorBrush = new SolidColorBrush();
                mySolidColorBrush.Color = Color.FromArgb(255, 0, 0, 0);

                tempEllipse1.Fill = mySolidColorBrush;
                tempEllipse2.Fill = mySolidColorBrush;
            }
            haltAll = false;
        }
        public async void colorVerticesTabThree(double delayTime)
        {
            Ellipse tempEllipse1 = new Ellipse();
            Ellipse tempEllipse2 = new Ellipse();
            SolidColorBrush mySolidColorBrush1 = new SolidColorBrush();
            SolidColorBrush mySolidColorBrush2 = new SolidColorBrush();
            Line xx3 = new Line();

            for (int z = 0; z < 100; z++)
            {
                TabThreeIterationCounter++;
                confidenceTabThree(TabThreeIterationCounter);

                int x3 = new Random().Next(101, 128);
                switch (x3)
                {
                    case 101:
                        xx3 = Edge301;
                        break;
                    case 102:
                        xx3 = Edge302;
                        break;
                    case 103:
                        xx3 = Edge303;
                        break;
                    case 104:
                        xx3 = Edge304;
                        break;
                    case 105:
                        xx3 = Edge305;
                        break;
                    case 106:
                        xx3 = Edge306;
                        break;
                    case 107:
                        xx3 = Edge307;
                        break;
                    case 108:
                        xx3 = Edge308;
                        break;
                    case 109:
                        xx3 = Edge309;
                        break;
                    case 110:
                        xx3 = Edge310;
                        break;
                    case 111:
                        xx3 = Edge311;
                        break;
                    case 112:
                        xx3 = Edge312;
                        break;
                    case 113:
                        xx3 = Edge313;
                        break;
                    case 114:
                        xx3 = Edge314;
                        break;
                    case 115:
                        xx3 = Edge315;
                        break;
                    case 116:
                        xx3 = Edge316;
                        break;
                    case 117:
                        xx3 = Edge317;
                        break;
                    case 118:
                        xx3 = Edge318;
                        break;
                    case 119:
                        xx3 = Edge319;
                        break;
                    case 120:
                        xx3 = Edge320;
                        break;
                    case 121:
                        xx3 = Edge321;
                        break;
                    case 122:
                        xx3 = Edge322;
                        break;
                    case 123:
                        xx3 = Edge323;
                        break;
                    case 124:
                        xx3 = Edge324;
                        break;
                    case 125:
                        xx3 = Edge325;
                        break;
                    case 126:
                        xx3 = Edge326;
                        break;
                    case 127:
                        xx3 = Edge327;
                        break;
                }

                String nameLine = xx3.Name;

                switch (nameLine)
                {
                    case "Edge301":
                        tempEllipse1 = Vertex301;
                        tempEllipse2 = Vertex302;
                        break;
                    case "Edge302":
                        tempEllipse1 = Vertex302;
                        tempEllipse2 = Vertex303;
                        break;
                    case "Edge303":
                        tempEllipse1 = Vertex303;
                        tempEllipse2 = Vertex304;
                        break;
                    case "Edge304":
                        tempEllipse1 = Vertex304;
                        tempEllipse2 = Vertex305;
                        break;
                    case "Edge305":
                        tempEllipse1 = Vertex305;
                        tempEllipse2 = Vertex306;
                        break;
                    case "Edge306":
                        tempEllipse1 = Vertex306;
                        tempEllipse2 = Vertex307;
                        break;
                    case "Edge307":
                        tempEllipse1 = Vertex307;
                        tempEllipse2 = Vertex308;
                        break;
                    case "Edge308":
                        tempEllipse1 = Vertex308;
                        tempEllipse2 = Vertex301;
                        break;
                    case "Edge309":
                        tempEllipse1 = Vertex301;
                        tempEllipse2 = Vertex309;
                        break;
                    case "Edge310":
                        tempEllipse1 = Vertex302;
                        tempEllipse2 = Vertex309;
                        break;
                    case "Edge311":
                        tempEllipse1 = Vertex303;
                        tempEllipse2 = Vertex310;
                        break;
                    case "Edge312":
                        tempEllipse1 = Vertex304;
                        tempEllipse2 = Vertex311;
                        break;
                    case "Edge313":
                        tempEllipse1 = Vertex305;
                        tempEllipse2 = Vertex312;
                        break;
                    case "Edge314":
                        tempEllipse1 = Vertex306;
                        tempEllipse2 = Vertex313;
                        break;
                    case "Edge315":
                        tempEllipse1 = Vertex307;
                        tempEllipse2 = Vertex314;
                        break;
                    case "Edge316":
                        tempEllipse1 = Vertex308;
                        tempEllipse2 = Vertex315;
                        break;
                    case "Edge317":
                        tempEllipse1 = Vertex301;
                        tempEllipse2 = Vertex315;
                        break;
                    case "Edge318":
                        tempEllipse1 = Vertex309;
                        tempEllipse2 = Vertex310;
                        break;
                    case "Edge319":
                        tempEllipse1 = Vertex310;
                        tempEllipse2 = Vertex311;
                        break;
                    case "Edge320":
                        tempEllipse1 = Vertex311;
                        tempEllipse2 = Vertex312;
                        break;
                    case "Edge321":
                        tempEllipse1 = Vertex312;
                        tempEllipse2 = Vertex313;
                        break;
                    case "Edge322":
                        tempEllipse1 = Vertex313;
                        tempEllipse2 = Vertex314;
                        break;
                    case "Edge323":
                        tempEllipse1 = Vertex314;
                        tempEllipse2 = Vertex315;
                        break;
                    case "Edge324":
                        tempEllipse1 = Vertex309;
                        tempEllipse2 = Vertex316;
                        break;
                    case "Edge325":
                        tempEllipse1 = Vertex311;
                        tempEllipse2 = Vertex316;
                        break;
                    case "Edge326":
                        tempEllipse1 = Vertex313;
                        tempEllipse2 = Vertex316;
                        break;
                    case "Edge327":
                        tempEllipse1 = Vertex315;
                        tempEllipse2 = Vertex316;
                        break;
                }

                int temp = new Random().Next(1, 4);

                switch (temp)
                {
                    case 1:
                        int temp2 = new Random().Next(2, 4);

                        switch (temp2)
                        {
                            case 2:
                                mySolidColorBrush1.Color = Color.FromArgb(255, 255, 0, 0);
                                mySolidColorBrush2.Color = Color.FromArgb(255, 0, 255, 0);
                                break;
                            case 3:
                                mySolidColorBrush1.Color = Color.FromArgb(255, 255, 0, 0);
                                mySolidColorBrush2.Color = Color.FromArgb(255, 0, 0, 255);
                                break;
                        }
                        break;
                    case 2:
                        int temp3 = new Random().Next(2, 4);

                        switch (temp3)
                        {
                            case 2:
                                mySolidColorBrush1.Color = Color.FromArgb(255, 0, 255, 0);
                                mySolidColorBrush2.Color = Color.FromArgb(255, 255, 0, 0);
                                break;
                            case 3:
                                mySolidColorBrush1.Color = Color.FromArgb(255, 0, 255, 0);
                                mySolidColorBrush2.Color = Color.FromArgb(255, 0, 0, 255);
                                break;
                        }
                        break;
                    case 3:
                        int temp4 = new Random().Next(2, 4);

                        switch (temp4)
                        {
                            case 2:
                                mySolidColorBrush1.Color = Color.FromArgb(255, 0, 0, 255);
                                mySolidColorBrush2.Color = Color.FromArgb(255, 255, 0, 0);
                                break;
                            case 3:
                                mySolidColorBrush1.Color = Color.FromArgb(255, 0, 0, 255);
                                mySolidColorBrush2.Color = Color.FromArgb(255, 0, 255, 0);
                                break;
                        }
                        break;
                }

                tempEllipse1.Fill = mySolidColorBrush1;
                tempEllipse2.Fill = mySolidColorBrush2;

                int delayTimeX = (int)delayTime;
                await Task.Delay(delayTimeX);

                SolidColorBrush mySolidColorBrush = new SolidColorBrush();
                mySolidColorBrush.Color = Color.FromArgb(255, 0, 0, 0);

                tempEllipse1.Fill = mySolidColorBrush;
                tempEllipse2.Fill = mySolidColorBrush;
            }
            haltAll = false;
        }

        public void confidenceTabOne(int iteration)
        {
            TextBox tabOneIterationTemp = new TextBox();
            TextBox tabOneConfidenceTemp = new TextBox();

            tabOneIterationTemp = TabOneIteration;
            tabOneConfidenceTemp = TabOneConfidence;

            string Iter1 = "" + iteration;
            tabOneIterationTemp.Text = Iter1;

            double temp1 = (1 - Math.Pow(1.00 - 1.00 / 15.00, iteration))*100;
            string Conf1 = temp1 + "%";
            tabOneConfidenceTemp.Text = Conf1;


            return;
        }
        public void confidenceTabTwo(int iteration)
        {
            TextBox tabTwoIterationTemp = new TextBox();
            TextBox tabTwoConfidenceTemp = new TextBox();

            tabTwoIterationTemp = TabTwoIteration;
            tabTwoConfidenceTemp = TabTwoConfidence;

            string Iter2 = "" + iteration;
            tabTwoIterationTemp.Text = Iter2;

            double temp2 = (1 - Math.Pow(1.00 - 1.00 / 15.00, iteration)) * 100;
            string Conf2 = temp2 + "%";
            tabTwoConfidenceTemp.Text = Conf2;


            return;
        }
        public void confidenceTabThree(int iteration)
        {
            TextBox tabThreeIterationTemp = new TextBox();
            TextBox tabThreeConfidenceTemp = new TextBox();

            tabThreeIterationTemp = TabThreeIteration;
            tabThreeConfidenceTemp = TabThreeConfidence;

            string Iter3 = "" + iteration;
            tabThreeIterationTemp.Text = Iter3;

            double temp3 = (1 - Math.Pow(1.00 - 1.00 / 15.00, iteration)) * 100;
            string Conf3 = temp3 + "%";
            tabThreeConfidenceTemp.Text = Conf3;


            return;
        }

        public async void revealTabOne(object sender, RoutedEventArgs e)
        {
            Ellipse tempEllipse1 = new Ellipse();
            Ellipse tempEllipse2 = new Ellipse();
            Ellipse tempEllipse3 = new Ellipse();
            Ellipse tempEllipse4 = new Ellipse();
            Ellipse tempEllipse5 = new Ellipse();
            Ellipse tempEllipse6 = new Ellipse();
            Ellipse tempEllipse7 = new Ellipse();
            Ellipse tempEllipse8 = new Ellipse();
            Ellipse tempEllipse9 = new Ellipse();
            Ellipse tempEllipse10 = new Ellipse();

            tempEllipse1 = Vertex101;
            tempEllipse2 = Vertex102;
            tempEllipse3 = Vertex103;
            tempEllipse4 = Vertex104;
            tempEllipse5 = Vertex105;
            tempEllipse6 = Vertex106;
            tempEllipse7 = Vertex107;
            tempEllipse8 = Vertex108;
            tempEllipse9 = Vertex109;
            tempEllipse10 = Vertex110;

            SolidColorBrush mySolidColorBrushR = new SolidColorBrush();
            SolidColorBrush mySolidColorBrushB = new SolidColorBrush();
            SolidColorBrush mySolidColorBrushG = new SolidColorBrush();
            SolidColorBrush mySolidColorBrushX = new SolidColorBrush();

            mySolidColorBrushR.Color = Color.FromArgb(255, 255, 0, 0);
            mySolidColorBrushG.Color = Color.FromArgb(255, 0, 255, 0);
            mySolidColorBrushB.Color = Color.FromArgb(255, 0, 0, 255);
            mySolidColorBrushX.Color = Color.FromArgb(255, 0, 0, 0);

            tempEllipse1.Fill = mySolidColorBrushB;
            tempEllipse2.Fill = mySolidColorBrushR;
            tempEllipse3.Fill = mySolidColorBrushG;
            tempEllipse4.Fill = mySolidColorBrushB;
            tempEllipse5.Fill = mySolidColorBrushG;
            tempEllipse6.Fill = mySolidColorBrushG;
            tempEllipse7.Fill = mySolidColorBrushB;
            tempEllipse8.Fill = mySolidColorBrushR;
            tempEllipse9.Fill = mySolidColorBrushG;
            tempEllipse10.Fill = mySolidColorBrushR;

            await Task.Delay(10000);

            tempEllipse1.Fill = mySolidColorBrushX;
            tempEllipse2.Fill = mySolidColorBrushX;
            tempEllipse3.Fill = mySolidColorBrushX;
            tempEllipse4.Fill = mySolidColorBrushX;
            tempEllipse5.Fill = mySolidColorBrushX;
            tempEllipse6.Fill = mySolidColorBrushX;
            tempEllipse7.Fill = mySolidColorBrushX;
            tempEllipse8.Fill = mySolidColorBrushX;
            tempEllipse9.Fill = mySolidColorBrushX;
            tempEllipse10.Fill = mySolidColorBrushX;
        }
        public async void revealTabTwo(object sender, RoutedEventArgs e)
        {
            Ellipse tempEllipse1 = new Ellipse();
            Ellipse tempEllipse2 = new Ellipse();
            Ellipse tempEllipse3 = new Ellipse();
            Ellipse tempEllipse4 = new Ellipse();
            Ellipse tempEllipse5 = new Ellipse();
            Ellipse tempEllipse6 = new Ellipse();

            tempEllipse1 = Vertex201;
            tempEllipse2 = Vertex202;
            tempEllipse3 = Vertex203;
            tempEllipse4 = Vertex204;
            tempEllipse5 = Vertex205;
            tempEllipse6 = Vertex206;

            SolidColorBrush mySolidColorBrushR = new SolidColorBrush();
            SolidColorBrush mySolidColorBrushB = new SolidColorBrush();
            SolidColorBrush mySolidColorBrushG = new SolidColorBrush();
            SolidColorBrush mySolidColorBrushX = new SolidColorBrush();

            mySolidColorBrushR.Color = Color.FromArgb(255, 255, 0, 0);
            mySolidColorBrushG.Color = Color.FromArgb(255, 0, 255, 0);
            mySolidColorBrushB.Color = Color.FromArgb(255, 0, 0, 255);
            mySolidColorBrushX.Color = Color.FromArgb(255, 0, 0, 0);

            tempEllipse1.Fill = mySolidColorBrushB;
            tempEllipse2.Fill = mySolidColorBrushR;
            tempEllipse3.Fill = mySolidColorBrushG;
            tempEllipse4.Fill = mySolidColorBrushB;
            tempEllipse5.Fill = mySolidColorBrushR;
            tempEllipse6.Fill = mySolidColorBrushG;

            await Task.Delay(10000);

            tempEllipse1.Fill = mySolidColorBrushX;
            tempEllipse2.Fill = mySolidColorBrushX;
            tempEllipse3.Fill = mySolidColorBrushX;
            tempEllipse4.Fill = mySolidColorBrushX;
            tempEllipse5.Fill = mySolidColorBrushX;
            tempEllipse6.Fill = mySolidColorBrushX;
        }
        public async void revealTabThree(object sender, RoutedEventArgs e)
        {
            Ellipse tempEllipse1 = new Ellipse();
            Ellipse tempEllipse2 = new Ellipse();
            Ellipse tempEllipse3 = new Ellipse();
            Ellipse tempEllipse4 = new Ellipse();
            Ellipse tempEllipse5 = new Ellipse();
            Ellipse tempEllipse6 = new Ellipse();
            Ellipse tempEllipse7 = new Ellipse();
            Ellipse tempEllipse8 = new Ellipse();
            Ellipse tempEllipse9 = new Ellipse();
            Ellipse tempEllipse10 = new Ellipse();
            Ellipse tempEllipse11 = new Ellipse();
            Ellipse tempEllipse12 = new Ellipse();
            Ellipse tempEllipse13 = new Ellipse();
            Ellipse tempEllipse14 = new Ellipse();
            Ellipse tempEllipse15 = new Ellipse();
            Ellipse tempEllipse16 = new Ellipse();

            tempEllipse1 = Vertex301;
            tempEllipse2 = Vertex302;
            tempEllipse3 = Vertex303;
            tempEllipse4 = Vertex304;
            tempEllipse5 = Vertex305;
            tempEllipse6 = Vertex306;
            tempEllipse7 = Vertex307;
            tempEllipse8 = Vertex308;
            tempEllipse9 = Vertex309;
            tempEllipse10 = Vertex310;
            tempEllipse11 = Vertex311;
            tempEllipse12 = Vertex312;
            tempEllipse13 = Vertex313;
            tempEllipse14 = Vertex314;
            tempEllipse15 = Vertex315;
            tempEllipse16 = Vertex316;

            SolidColorBrush mySolidColorBrushR = new SolidColorBrush();
            SolidColorBrush mySolidColorBrushB = new SolidColorBrush();
            SolidColorBrush mySolidColorBrushG = new SolidColorBrush();
            SolidColorBrush mySolidColorBrushX = new SolidColorBrush();

            mySolidColorBrushR.Color = Color.FromArgb(255, 255, 0, 0);
            mySolidColorBrushG.Color = Color.FromArgb(255, 0, 255, 0);
            mySolidColorBrushB.Color = Color.FromArgb(255, 0, 0, 255);
            mySolidColorBrushX.Color = Color.FromArgb(255, 0, 0, 0);

            tempEllipse1.Fill = mySolidColorBrushB;
            tempEllipse2.Fill = mySolidColorBrushR;
            tempEllipse3.Fill = mySolidColorBrushG;
            tempEllipse4.Fill = mySolidColorBrushR;
            tempEllipse5.Fill = mySolidColorBrushB;
            tempEllipse6.Fill = mySolidColorBrushR;
            tempEllipse7.Fill = mySolidColorBrushG;
            tempEllipse8.Fill = mySolidColorBrushR;
            tempEllipse9.Fill = mySolidColorBrushG;
            tempEllipse10.Fill = mySolidColorBrushR;
            tempEllipse11.Fill = mySolidColorBrushG;
            tempEllipse12.Fill = mySolidColorBrushR;
            tempEllipse13.Fill = mySolidColorBrushG;
            tempEllipse14.Fill = mySolidColorBrushR;
            tempEllipse15.Fill = mySolidColorBrushG;
            tempEllipse16.Fill = mySolidColorBrushR;

            await Task.Delay(10000);

            tempEllipse1.Fill = mySolidColorBrushX;
            tempEllipse2.Fill = mySolidColorBrushX;
            tempEllipse3.Fill = mySolidColorBrushX;
            tempEllipse4.Fill = mySolidColorBrushX;
            tempEllipse5.Fill = mySolidColorBrushX;
            tempEllipse6.Fill = mySolidColorBrushX;
            tempEllipse7.Fill = mySolidColorBrushX;
            tempEllipse8.Fill = mySolidColorBrushX;
            tempEllipse9.Fill = mySolidColorBrushX;
            tempEllipse10.Fill = mySolidColorBrushX;
            tempEllipse11.Fill = mySolidColorBrushX;
            tempEllipse12.Fill = mySolidColorBrushX;
            tempEllipse13.Fill = mySolidColorBrushX;
            tempEllipse14.Fill = mySolidColorBrushX;
            tempEllipse15.Fill = mySolidColorBrushX;
            tempEllipse16.Fill = mySolidColorBrushX;
        }
    }
}