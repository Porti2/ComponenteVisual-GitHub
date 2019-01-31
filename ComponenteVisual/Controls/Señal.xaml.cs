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

            double radio = (double)e.NewValue; 

            if (radio == 0 || radio <= 0.24)
            {
                s.Calidad.Text = "Mala";
            }
            else if (radio == 0.25 || radio <= 0.49)
            {
                s.Calidad.Text = "Regular";
            }
            else if (radio == 0.49 || radio <= 0.75)
            {
                s.Calidad.Text = "Buena";
            }
            else if (radio == 0.75 || radio <= 1)
            {
                s.Calidad.Text = "Excelente";
            }


            s.Barra1.Offset = (double)e.NewValue;
            s.Barra2.Offset = (double)e.NewValue;
        }
    }
}
