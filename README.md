# WPF_Learning
This is WPF learning purpose
01. Abouts Layout in WPF

    Wpf GUI interface starting with Window class that can handle only one child control.
    So if we use single control like Button,TextBox, leble etc. that is ok. 
    
    Example:-
    <Window x:Class="LayoutsInWpf.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:LayoutsInWpf"
        mc:Ignorable="d"
        Title="MainWindow" Height="450" Width="800" Background="Wheat">
  
      <TextBox Width="200px" Height="40px"></TextBox>
      <Button Foreground="White" Background="Red" Width="100px" Height="40px">Button</Button>
  
    </Window>
    
    But in real application need lots of control in the right place.
    than Layouts Comes into to the picture
    Layouts(StackPanel, WrapPanel, DockPanel, CanvalPanel, GridPanel)
