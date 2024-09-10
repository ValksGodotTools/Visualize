using Godot;
using System;

namespace Visualize;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Method)]
public class VisualizeAttribute : Attribute
{
    public Vector2 InitialPosition { get; }
    public bool AlwaysUpdate { get; }

    public VisualizeAttribute()
    {
        InitialPosition = Vector2.Zero;
    }

    public VisualizeAttribute(bool alwaysUpdate)
    {
        InitialPosition = Vector2.Zero;
        AlwaysUpdate = alwaysUpdate;
    }

    public VisualizeAttribute(float x, float y)
    {
        InitialPosition = new Vector2(x, y);
    }
}

