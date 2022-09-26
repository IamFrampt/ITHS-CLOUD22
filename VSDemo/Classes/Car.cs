using System.Diagnostics;
using System.Drawing;
using System.Reflection;

public class Car
{
    public string Model;
    public int Price = 125000;
    public string Color;

    public Car()
    {

    }
    public Car(string model)
    {
        this.Model = model;

    }
    public Car(string model, int price)
    {
        this.Model = model;
        this.Price = price;

    }

    public Car(string model, int price, string color)
    {
        this.Model = model;
        this.Price = price;
        this.Color = color;

    }
    public void WhatCar()
    {
        Console.WriteLine($"This is a {this.Model} that cost {this.Price} and it's {this.Color}.");
    }

    public int HalfPrice()
    {
        return this.Price /= 2;
    }
}