using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QLBX.FormChucNangCuaHL
{
    /// <summary>
    /// Interaction logic for UCVeXe.xaml
    /// </summary>
    public partial class UCVeXe : UserControl
    {
        public UCVeXe()
        {
            InitializeComponent();
            createSD(" ", frist);
            createSD(" ", second);
        }
        #region tao so do xe
        void taobutton(string caption, int row, int column, Grid parent)
        {
            ToggleButton button = new ToggleButton();
            button.Content = caption;
            button.Tag = caption;
            Style style = this.FindResource("MaterialDesignActionToggleButton") as Style;
            button.Style = style;
            ToolTip abc = new ToolTip();
            abc.Content = "MaterialDesignActionAccentToggleButton";
            //Color xanh = new Color.FromArgb(#FF00FF);

            BrushConverter bc = new BrushConverter();
            Brush brush;
            brush = (Brush)bc.ConvertFrom("#00bcd4");

            button.Background = brush;
            button.ToolTip = abc;
            //button.Margin = new Thickness(5, 5, 5, 5);
            parent.Children.Add(button);
           // button.Click += Button_Click;
            Grid.SetRow(button, row);
            Grid.SetColumn(button, column);
        }

        void createSD(string cap, Grid grid)
        {
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 7; j++)
                {
                    if (i % 2 == 0)
                    {
                        taobutton(cap, i, j, grid);
                    }
                    if (i % 2 != 0 && j == 0)
                        taobutton(cap, i, j, grid);
                }
        }
        #endregion
    }
}
