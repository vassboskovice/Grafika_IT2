﻿using System;
using System.Collections.Generic;
using System.IO;
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

namespace Grafika_IT2
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    private Board board;

    public MainWindow()
    {
      InitializeComponent();
      board = new Board();
    }

    private void canvasBoard_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
      board.Add(e.GetPosition(canvasBoard));
      board.Draw(canvasBoard);
    }

    private void ButtonOpen_Click(object sender, RoutedEventArgs e)
    {
      var text = File.ReadAllText("data.csv");
      board.FromString(text);
      board.Draw(canvasBoard);
    }

    private void ButtonSave_Click(object sender, RoutedEventArgs e)
    {
      File.WriteAllText("data.csv", board.ToString());
    }
  }
}
