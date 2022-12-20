using Godot;
using System;

public class PlayerMovement : Camera
{

    public float MouseSensitivity = 0.075f;

    public override void _Input(InputEvent inputEvent) {
        if(inputEvent is InputEventMouseMotion) {

            var MouseDelta = inputEvent as InputEventMouseMotion;
            // Input.MouseMode(Input.MouseMode.Captured);

            Vector3 currentPitch = RotationDegrees;

            currentPitch.y -= MouseDelta.Relative.x * MouseSensitivity;
            // player.SetRotationDegrees(currentPitch);
            RotationDegrees = currentPitch;

            Vector3 currentTilt = RotationDegrees;//grab current rotation of camera.
            
            //change the current rotation by the relative mouse coor change on the y Axis
            currentTilt.x -= MouseDelta.Relative.y * MouseSensitivity;

            currentTilt.x = Mathf.Clamp(currentTilt.x, -90, 90);

            currentTilt.y = Mathf.Clamp(currentTilt.y, -180, 0);

            RotationDegrees = currentTilt;
        }
    }
}
