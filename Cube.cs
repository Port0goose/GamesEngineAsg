using Godot;
using System;

public class Cube : MeshInstance
{
    public float MouseSensitivity = 0.075f;

    KinematicBody player;

    public override void _Ready()
    {
        player = GetNode<KinematicBody>($"../..");
    }

    public override void _Input(InputEvent inputEvent) {
        if(inputEvent is InputEventMouseMotion) {

            var MouseDelta = inputEvent as InputEventMouseMotion;
            // Input.MouseMode(Input.MouseMode.Captured);

            Vector3 currentPitch = player.RotationDegrees;

            currentPitch.y -= MouseDelta.Relative.x * MouseSensitivity;
            // player.SetRotationDegrees(currentPitch);
            player.RotationDegrees = currentPitch;

            Vector3 currentTilt = player.RotationDegrees;//grab current rotation of camera.

            currentTilt.y = Mathf.Clamp(currentTilt.y, 0, 0);

            RotationDegrees = currentTilt;
        }
    }
}
