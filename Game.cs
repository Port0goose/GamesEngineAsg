using Godot;
using System;

public class Game : Spatial
{
    private AnimationPlayer animationPlayer;

    private Camera Camera2;

    private Camera Camera;

    public override void _Ready()
    {
        Input.MouseMode = Input.MouseModeEnum.Captured;
        // animationPlayer = GetNode<AnimationPlayer>("AnimationPlayer");
        Camera = GetNode<Camera>($"ATST/PlayerMovement");
        Camera2 = GetNode<Camera>($"ATST/PlayerMovement2");
    }

    public override void _Process(float delta)
    {
        if(Input.IsActionJustPressed("cam1"))
        {
            Camera.Current = true;
        }
        if(Input.IsActionJustPressed("cam2"))
        {
            Camera2.Current = true;
        }

    }

}
