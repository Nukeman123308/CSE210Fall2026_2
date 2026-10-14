using System.Formats.Asn1; 
using System.Security.Cryptography.X509Certificates; 

class Circle
{
    private double _radius;

    public Circle()
    {
        _radius = 0.0;
    }

    public Circle(double radius)
    {
        SetRadius(radius);
    }

    public double GetArea()
    {
        double area;
        area = _radius * _radius * 3.14159; 

        return area; 

    }


}