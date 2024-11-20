using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Sem.Zvd.Ind.OOP
{
    class CTriangle
{
    private Graphics graphics;
    private int _radius;
    public int X { get; set; }
    public int Y { get; set; }
    public int Radius
    {
        get { return _radius; }
        set
        {
            _radius = value >= 200 ? 200 : value;
            _radius = value <= 5 ? 5 : value;
        }
    }

    public CTriangle(Graphics graphics, int X, int Y, int radius)
    {
        this.graphics = graphics;
        this.X = X;
        this.Y = Y;
        this.Radius = radius;
        Show();  
    }

    private void Draw(Pen pen)
    {
        Point[] points = new Point[3];
        double angleStep = 2 * Math.PI / 3;

        for (int i = 0; i < 3; i++)
        {
            points[i] = new Point(
                X + (int)(Radius * Math.Cos(angleStep * i - Math.PI / 2)),
                Y + (int)(Radius * Math.Sin(angleStep * i - Math.PI / 2))
            );
        }

        graphics.DrawPolygon(pen, points);
    }

    public void Show()
    {
        Draw(Pens.Blue);  
    }

    public void Hide()
    {
        Draw(Pens.White); 
    }

    public void Expand(int dR)
    {
        Radius += dR;
        
    }

    public void Collapse(int dR)
    {
        Radius -= dR;
        
    }

    public void Move(int dX, int dY)
    {
        X += dX;
        Y += dY;
        
    }
}

}
