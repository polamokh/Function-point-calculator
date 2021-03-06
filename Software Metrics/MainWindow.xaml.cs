﻿using System;
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
using Software_Metrics.Front_end;

namespace Software_Metrics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public CustomCanvas CurrentCanvas;

        public MainWindow()
        {
            InitializeComponent();
            Window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            FrontEndHelper.SetMainWindow(this);
            InitializeMainWindowCanvas();
        }

        void InitializeMainWindowCanvas()
        {
            CustomCanvas mainWindowCanvas = Front_end.MainWindowCanvas.GetInstance(MainWindowCanvas);
            mainWindowCanvas.SetCanvasDimensions(Window.Width, Window.Height);
            mainWindowCanvas.SetCanvasCoord(0, 0);
            mainWindowCanvas.Show();
        }

        void InitializeUFPCanvas()
        {
            CustomCanvas UFPCanvas = Front_end.UFPCanvas.GetInstance(UfpCanvas);
            UFPCanvas.SetCanvasDimensions(Window.Width, Window.Height);
            UFPCanvas.SetCanvasCoord(0, 0);
            UFPCanvas.Show();
        }

        public void Calculate_Button_Click(object sender, RoutedEventArgs e)
        {
            if(CurrentCanvas != null)
                CurrentCanvas.Hide();
            InitializeUFPCanvas();
        }

        public void InitializeTCFCanvas()
        {
            CustomCanvas TCFCanvas = Front_end.TCFCanvas.GetInstance(tcfCanvas);
            TCFCanvas.SetCanvasDimensions(Window.Width, Window.Height);
            TCFCanvas.SetCanvasCoord(0, 0);
            TCFCanvas.Show();
        }

        public void InitializeResultCanvas()
        {
            CustomCanvas ResultCanvas = Front_end.ResultCanvas.GetInstance(resultCanvas);
            ResultCanvas.SetCanvasDimensions(Window.Width, Window.Height);
            ResultCanvas.SetCanvasCoord(0, 0);
            ResultCanvas.Show();
        }
    }
}
