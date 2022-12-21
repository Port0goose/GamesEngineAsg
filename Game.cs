using Godot;
using System;

public class Game : Spatial
{
    private AnimationPlayer animationPlayer;

    public override void _Ready()
    {
        Input.MouseMode = Input.MouseModeEnum.Captured;
        // animationPlayer = GetNode<AnimationPlayer>("AnimationPlayer");
    }

    // public void PlayAnimation(string ATST)
    // {
    //     animationPlayer.Play(ATST);
    // }

}
