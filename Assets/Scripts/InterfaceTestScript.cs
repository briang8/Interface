using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceTestScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Trapezium trapezium = new Trapezium();
        trapezium.CalculateUnknownSides();
        trapezium.CalculateArea();
        trapezium.CalculatePerimeter();

        Circle circle = new Circle();
        circle.CalculateRadius();
        circle.CalculateArea();
        circle.CalculatePerimeter();

        Nonagon nonagon = new Nonagon();
        nonagon.CalculateArea();
        nonagon.CalculatePerimeter();
        Debug.Log("Nonagon sides: " + nonagon.CalculateNumberOfSides());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public interface IShape
{
    void CalculateArea();
    void CalculatePerimeter();
}

public class Trapezium : IShape
{
    public float topSide = 4f;
    public float bottomSide = 8f;
    public float height = 5f;
    public float leftSide;
    public float rightSide;

    public void CalculateUnknownSides()
    {
        leftSide = 5f;
        rightSide = 5f;
        Debug.Log("Trapezium sides: left " + leftSide + ", right " + rightSide);
    }

    public void CalculateArea()
    {
        float area = ((topSide + bottomSide) / 2) * height;
        Debug.Log("Trapezium area: " + area);
    }

    public void CalculatePerimeter()
    {
        float perimeter = topSide + bottomSide + leftSide + rightSide;
        Debug.Log("Trapezium perimeter: " + perimeter);
    }
}

public class Circle : IShape
{
    public float radius;

    public void CalculateArea()
    {
        float area = Mathf.PI * radius * radius;
        Debug.Log("Circle area: " + area);
    }

    public void CalculateRadius()
    {
        radius = 3f;
        Debug.Log("Circle radius: " + radius);
    }

    public void CalculatePerimeter()
    {
        float perimeter = 2 * Mathf.PI * radius;
        Debug.Log("Circle perimeter: " + perimeter);
    }
}

public class Nonagon : IShape
{
    int numberOfSides = 9;
    public float sideLength = 4f;

    public void CalculateArea()
    {
        float area = (numberOfSides * sideLength * sideLength) / (4 * Mathf.Tan(Mathf.PI / numberOfSides));
        Debug.Log("Nonagon area: " + area);
    }

    public void CalculatePerimeter()
    {
        float perimeter = numberOfSides * sideLength;
        Debug.Log("Nonagon perimeter: " + perimeter);
    }

    public int CalculateNumberOfSides()
    {
        return numberOfSides;
    }
}