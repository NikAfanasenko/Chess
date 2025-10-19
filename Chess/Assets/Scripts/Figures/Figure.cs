using UnityEngine;

public abstract class Figure
{
    public Material Color { get; protected set; }

    public Vector3 Position { get; protected set; }

    public Figure(Material color, Vector3 position)
    {
        Color = color;
        Position = position;
    }

    public abstract void Move();
}