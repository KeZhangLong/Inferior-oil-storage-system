using MaterialDesignThemes.Wpf;
using System;
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
using System.Windows.Shapes;

namespace 劣质油仓库系统.View
{
    /// <summary>
    /// LoginView.xaml 的交互逻辑
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private bool IsDarkTheme { get; set; }//定义是否为暗黑模式

        private readonly PaletteHelper paletteHelper = new PaletteHelper();

        private void toggleTheme(object sennder,RoutedEventArgs e)//切换主题的按钮事件
        {
            ITheme theme = paletteHelper.GetTheme();

            if(IsDarkTheme = theme.GetBaseTheme() == BaseTheme.Dark)//如果当前主题为暗黑色
            {
                IsDarkTheme = false;
                theme.SetBaseTheme(Theme.Light);//设置主题色为明亮
            }
            else
            {
                IsDarkTheme=true;
                theme.SetBaseTheme(Theme.Dark);//设置主题色为黑色
            }
            paletteHelper.SetTheme(theme);//成功设置界面主题颜色
        }

        private void exitApp(object sender, RoutedEventArgs e)//退出按钮点击事件
        {
            Application.Current.Shutdown();
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }
    }
}
