﻿using System.Collections.Generic;
using System.Windows.Controls;
using ChartsTest.BarExamples;
using ChartsTest.Line_Examples;
using ChartsTest.StackedBarExamples;

namespace ChartsTest
{
    //IMPORTANT
    //This class is only to display examples in MainWindow
    //If you want to see the code behind and XAML of an example you should go to that path
    //for example in solution exmplorer go to "Line Examples" folder and open the example you need.
    public static class ExamplesMapper
    {
        public static void Initialize(MainWindow window)
        {
            LineAndAreaAexamples = new List<UserControl>
            {
                new BasicLine(),
                new CustomLine(),
                new ZoomableLine(),
                new BindingLine(),
                new MvvmLine(),
                new PerformanceLine()
            };
            BarExamples = new List<UserControl>
            {
                new BasicBar(),
                new CustomBar(),
                new ZoomableBar(),
                new BindingBar(),
                new MvvmBar()
                //new PerformanceBar()
            };
            StackedBarExamples = new List<UserControl>
            {
                new BasicStackedBar(),
                new CustomStackedBar(),
                new ZoomableStackedBar(),
                new BindingStackedBar(),
                new MvvmStackedBar(),
                //new PerformanceBar()
            };
            window.LineControl.Content = LineAndAreaAexamples.Count > 0 ? LineAndAreaAexamples[0] : null;
            window.BarControl.Content = BarExamples.Count > 0 ? BarExamples[0] : null;
            window.StackedBarControl.Content = StackedBarExamples.Count > 0 ? StackedBarExamples[0] : null;
        }
        public static List<UserControl> LineAndAreaAexamples { get; set; }
        public static List<UserControl> BarExamples { get; set; }
        public static List<UserControl> StackedBarExamples { get; set; }

        public static void Next(this ContentControl control, List<UserControl> list)
        {
            var c = control.Content as UserControl;
            if (c == null) return;
            var i = list.IndexOf(c);
            i++;
            if (i > list.Count - 1) i = 0;
            control.Content = list[i];
        }

        public static void Previous(this ContentControl control, List<UserControl> list)
        {
            var c = control.Content as UserControl;
            if (c == null) return;
            var i = list.IndexOf(c);
            i--;
            if (i < 0) i = list.Count-1;
            control.Content = list[i];
        }
    }
}