using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Discord
{
    public class WindowBase : Window
    {
        public WindowBase()
        {
            
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            this.ControlBoxEventSubscribe();
            this.WindowBaseMoveEventSubscribe();
        }

        private void ControlBoxEventSubscribe()
        {
            Button minimizeButton = GetTemplateChild("WindowMinimizeButton") as Button;
            if (minimizeButton != null)
            {
                minimizeButton.Click += new RoutedEventHandler(delegate (object s, RoutedEventArgs e)
                {
                    this.WindowState = WindowState.Minimized;
                });
            }

            Button maximizeButton = GetTemplateChild("WindowMaximizeButton") as Button;
            if (maximizeButton != null)
            {
                maximizeButton.Click += new RoutedEventHandler(delegate (object s, RoutedEventArgs e)
                {
                    this.WindowState ^= WindowState.Maximized;
                });
            }

            Button closeButton = GetTemplateChild("WindowCloseButton") as Button;
            if (closeButton != null)
            {
                closeButton.Click += new RoutedEventHandler(delegate (object s, RoutedEventArgs e)
                {
                    this.Close();
                });
            }
        }

        private Rect _originWindow;

        private void WindowBaseMoveEventSubscribe()
        {
            Grid DargBar = GetTemplateChild("WindowDragBar") as Grid;
            if (DargBar != null)
            {
                DargBar.MouseLeftButtonDown += new MouseButtonEventHandler(delegate (object s, MouseButtonEventArgs e)
                {
                    if (e.ChangedButton == MouseButton.Left && e.ClickCount == 2)
                    {
                        this.WindowState = this.WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;

                        _originWindow.Width = this.Width;
                        _originWindow.Height = this.Height;
                    }
                    else if (e.LeftButton == MouseButtonState.Pressed)
                    {
                        this.DragMove();
                    }
                });

                DargBar.MouseMove += new MouseEventHandler(delegate (object s, MouseEventArgs e)
                {
                    if (e.LeftButton != MouseButtonState.Pressed)
                    {
                        return;
                    }
                    this.DragMove();
                });
            }
        }
    }
}