using Godot;
using System;

public class ATST : KinematicBody
{
// Declare member variables
    private Vector3 vel;
    private float gravity = 100;
    private float speed = 20;
    private float jump = 20;
    private bool OnGround = true;

    public override void _PhysicsProcess(float delta)
    {
        vel.x = 0;
        vel.z = 0;

        // Handle input and movement
        var input = new Vector3();
        if (Input.IsActionPressed("move_forward"))
            input.x += 1;

        if (Input.IsActionPressed("move_backwards"))
            input.x -= 1;

        if (Input.IsActionPressed("move_left"))
            input.z -= 1;

        if (Input.IsActionPressed("move_right"))
            input.z += 1;

        input = input.Normalized();

        var forward = GlobalTransform.basis.z;
        var right = GlobalTransform.basis.x;

        var relativDir = (forward * input.z + right * input.x);

        vel.x = relativDir.x * speed;
        vel.z = relativDir.z * speed;

        vel.y -= gravity * delta;

        vel = MoveAndSlide(vel, Vector3.Up);

        if(Input.IsActionPressed("jump") && OnGround == true)
        {
            vel.y = jump;
        }
    }
}
