# Interface Test Script

A Unity C# exercise demonstrating interfaces through three shape classes: Trapezium, Circle, and Nonagon. Each class implements a shared `IShape` interface and calculates its own area and perimeter.

## Overview

The `IShape` interface declares two methods:

- `CalculateArea()`
- `CalculatePerimeter()`

These are the only operations common to all three shapes, so they are the only ones declared in the interface. Anything specific to a single shape, such as calculating a radius or finding unknown sides, is implemented directly in that class instead of being forced into the shared interface.

## Classes

**Trapezium**
Holds the top side, bottom side, and height as known values. `CalculateUnknownSides()` fills in the left and right sides before `CalculateArea()` and `CalculatePerimeter()` run.

**Circle**
Holds a radius. `CalculateRadius()` sets it, then area and perimeter are calculated using standard circle formulas.

**Nonagon**
A nine-sided regular polygon. Stores the number of sides and a side length, and calculates area and perimeter using regular polygon formulas. Also includes `CalculateNumberOfSides()`.

## Testing

`InterfaceTestScript` is a MonoBehaviour attached to a GameObject in the scene. Inside `Start()`, it creates one instance of each shape, calls the relevant methods on each, and prints the results to the Unity Console using `Debug.Log()`.

## Project Structure

```
Assets/
  Scripts/
      InterfaceTestScript.cs
```

## How to Run

1. Open the project in Unity.
2. Open Window > General > Console.
3. Press Play.
4. The console will print the calculated area, perimeter, and any additional values for each shape.

##Output

```
Trapezium sides: left 5, right 5
Trapezium area: 30
Trapezium perimeter: 22
Circle radius: 3
Circle area: 28.27433
Circle perimeter: 18.84956
Nonagon area: 98.90918
Nonagon perimeter: 36
Nonagon sides: 9
```
