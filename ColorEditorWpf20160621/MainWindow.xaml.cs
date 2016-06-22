using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;

namespace ColorEditorWpf20160621
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        //BindingSource bindingSource1 = new BindingSource();
        public MainWindow()
        {
            InitializeComponent();

            Rgb rgb = new Rgb();
            rgb.R = 100;
            rgb.G = 20;
            rgb.B = 30;

            Binding bindingR = new Binding();
            bindingR.Source = rgb;
            bindingR.Mode = BindingMode.TwoWay;
            bindingR.Path = new PropertyPath("R");
            this.slider1.SetBinding(Slider.ValueProperty, bindingR);

            // http://point56.blogspot.jp/2009/01/wpfslidertextbox.html
            // http://main.tinyjoker.net/Tech/CSharp/WPF/TextBox%A4%CE%C6%FE%CE%CF%A4%F2%A4%B9%A4%B0%A4%CB%A5%D0%A5%A4%A5%F3%A5%C7%A5%A3%A5%F3%A5%B0%A5%BD%A1%BC%A5%B9%A4%CB%C8%BF%B1%C7%A4%B9%A4%EB.html
            Binding bindingSlider1 = new Binding();
            bindingSlider1.ElementName = "slider1";
            bindingSlider1.Path = new PropertyPath("Value");
            bindingSlider1.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            this.textBox1.SetBinding(TextBox.TextProperty, bindingSlider1);
            // https://code.msdn.microsoft.com/windowsdesktop/XAML-WPF-IME-Windows-WPF-9ef457d7

            Binding bindingG = new Binding();
            bindingG.Source = rgb;
            bindingG.Mode = BindingMode.TwoWay;
            bindingG.Path = new PropertyPath("G");
            this.slider2.SetBinding(Slider.ValueProperty, bindingG);

            Binding bindingSlider2 = new Binding();
            bindingSlider2.ElementName = "slider2";
            bindingSlider2.Path = new PropertyPath("Value");
            bindingSlider2.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            this.textBox2.SetBinding(TextBox.TextProperty, bindingSlider2);

            Binding bindingB = new Binding();
            bindingB.Source = rgb;
            bindingB.Mode = BindingMode.TwoWay;
            bindingB.Path = new PropertyPath("B");
            this.slider3.SetBinding(Slider.ValueProperty, bindingB);

            Binding bindingSlider3 = new Binding();
            bindingSlider3.ElementName = "slider3";
            bindingSlider3.Path = new PropertyPath("Value");
            bindingSlider3.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            this.textBox3.SetBinding(TextBox.TextProperty, bindingSlider3);
        }
    }
}
