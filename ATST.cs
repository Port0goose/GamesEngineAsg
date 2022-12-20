using Godot;
using System;

public class ATST : KinematicBody
{
    //physics
    float moveSpeed = 5;
    float jumpForce = 5;
    float gravity = 12;

    //camera look
    float minLookAngle = -90;
    float maxLookAngle = 90;
    float lookSensitivity = 10;

    //vectors
    Vector3 vel = Vector3.Zero;
    Vector2 mouseDelta = Vector2.Zero;

    //components
    Camera PlayerMovement;

    public override void _Ready()
    {
        PlayerMovement = GetNode<Camera>("PlayerMovement");
    }

    public override void _PhysicsProcess(float delta)
    {
        var input  = new Vector2();

        if(Input.IsActionJustPressed("move_forward"))
        {
            input.y -= 1;
        }

        if(Input.IsActionJustPressed("move_backwards"))
        {
            input.y += 1;
        }

        if(Input.IsActionJustPressed("move_right"))
        {
            input.y += 1;
        }

        if(Input.IsActionJustPressed("move_left"))
        {
            input.y -= 1;
        }
    }

}
