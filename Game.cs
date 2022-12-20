using Godot;
using System;

public class Game : Spatial
{
    
    public override void _Ready()
    {
        Input.MouseMode = Input.MouseModeEnum.Captured;
    }

}
