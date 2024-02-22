using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Grafika_IT2
{
  public class Board
  {
    private List<Point> points;

    public Board()
    {
      points = new List<Point>();
    }

    public void Clear()
    {
      points.Clear();
    }

    public void Add(Point point)
    {
      points.Add(point);
    }

    public void Draw(Canvas canvas)
    {
      canvas.Children.Clear();
      foreach (var point in points)
      {
        Ellipse ellipse = new Ellipse();
        ellipse.Width = 25;
        ellipse.Height = 25;
        ellipse.Fill = Brushes.Blue;
        Canvas.SetLeft(ellipse, point.X);
        Canvas.SetTop(ellipse, point.Y);
        canvas.Children.Add(ellipse);
      }
    }
  }
}
