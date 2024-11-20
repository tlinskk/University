using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Sem.Zvd.Ind.OOP
{
    class CCircle
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

    public CCircle(Graphics graphics, int X, int Y, int radius)
    {
        this.graphics = graphics;
        this.X = X;
        this.Y = Y;
        this.Radius = radius;
        Show(); 
    }

    private void Draw(Pen pen)
    {
        Rectangle rectangle = new Rectangle(X - Radius, Y - Radius, 2 * Radius, 2 * Radius);
        graphics.DrawEllipse(pen, rectangle);
    }

    public void Show()
    {
        Draw(Pens.Red); 
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
