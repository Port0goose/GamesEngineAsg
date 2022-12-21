using Godot;
using System;

public class ATST : KinematicBody
{
    // Declare member variables
    private Vector3 vel;
    private float gravity = 100;
    private float speed = 2;
    private float jump = 25;
    private bool OnGround = true;
    private AnimationPlayer animationPlayer;

    public override void _PhysicsProcess(float delta)
    {
        vel.x = 0;
        vel.z = 0;

        // Handle input and movement
        var input = new Vector3();
        if (Input.IsActionPressed("move_forward"))
        {
            input.x += 1;
            animationPlayer.Play("Legs");
        }

        if (Input.IsActionPressed("move_backwards"))
        {
            input.x -= 1;
            animationPlayer.Play("Back");
        }

        input = input.Normalized();

        var forward = GlobalTransform.basis.z;
        var right = GlobalTransform.basis.x;

        var relativDir = (forward * input.z + right * input.x);

        vel.x = relativDir.x * speed;
        vel.z = relativDir.z * speed;

        vel.y -= gravity * delta;

        vel = MoveAndSlide(vel, Vector3.Up);

        if(Input.IsActionJustPressed("jump") && OnGround == true)
        {
            vel.y = jump;
        }

        animationPlayer = GetNode<AnimationPlayer>("AnimationPlayer");
    }

    public void PlayAnimation(string Legs)
    {
        //forward leg movement
        animationPlayer.Play(Legs);
    }

        public void PlayAnimation2(string Back)
    {
        //backwards leg movement
        animationPlayer.Play(Back);
    }
}
