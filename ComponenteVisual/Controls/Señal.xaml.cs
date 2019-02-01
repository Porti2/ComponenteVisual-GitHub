using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Control de usuario está documentada en https://go.microsoft.com/fwlink/?LinkId=234236

namespace ComponenteVisual.Controls
{
    public sealed partial class Señal : UserControl
    {
        public static double radio;

        public Señal()
        {
            this.InitializeComponent();
        }

        public double Radio

        {
            get { return (double)GetValue(RadioProperty); }
            set
            {
                SetValue(RadioProperty, value);

            }
        }

        public static readonly DependencyProperty RadioProperty =
            DependencyProperty.Register("Radio", typeof(double), typeof(Señal), new PropertyMetadata(null, Cambio));

        private static void Cambio(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var s = d as Señal;

            radio = (double)e.NewValue;
            string rojo = "#C00E0E";

            if (radio == 0 || radio <= 0.24)
            {
                s.Calidad.Text = "Señal Mala";
                s.Barra1.Fill = new SolidColorBrush(Colors.Red);
                s.Barra2.Fill = new SolidColorBrush(Colors.DimGray);
                s.Barra3.Fill = new SolidColorBrush(Colors.DimGray);
                s.Barra4.Fill = new SolidColorBrush(Colors.DimGray);
            }
            else if (radio == 0.25 || radio <= 0.49)
            {
                s.Calidad.Text = "Señal Regular";
                s.Barra1.Fill = new SolidColorBrush(Colors.Yellow);
                s.Barra2.Fill = new SolidColorBrush(Colors.Yellow);
                s.Barra3.Fill = new SolidColorBrush(Colors.DimGray);
                s.Barra4.Fill = new SolidColorBrush(Colors.DimGray);
            }
            else if (radio == 0.49 || radio <= 0.75)
            {
                s.Calidad.Text = "Señal Buena";
                s.Barra1.Fill = new SolidColorBrush(Colors.Orange);
                s.Barra2.Fill = new SolidColorBrush(Colors.Orange);
                s.Barra3.Fill = new SolidColorBrush(Colors.Orange);
                s.Barra4.Fill = new SolidColorBrush(Colors.DimGray);
            }
            else if (radio == 0.75 || radio <= 1)
            {
                s.Calidad.Text = "Señal Excelente";
                s.Barra1.Fill = new SolidColorBrush(Colors.Green);
                s.Barra2.Fill = new SolidColorBrush(Colors.Green);
                s.Barra3.Fill = new SolidColorBrush(Colors.Green);
                s.Barra4.Fill = new SolidColorBrush(Colors.Green);
            }
        }
    }
}

