using Godot;
using System;

public class PlayerMovement : Camera
{

    public float MouseSensitivity = 0.075f;

    public override void _Input(InputEvent inputEvent) {
        if(inputEvent is InputEventMouseMotion) {

            var MouseDelta = inputEvent as InputEventMouseMotion;

            Vector3 currentPitch = RotationDegrees;

            RotationDegrees = currentPitch;

            Vector3 currentTilt = RotationDegrees;//grab current rotation of camera.
            
            //change the current rotation by the relative mouse coor change on the y Axis
            currentTilt.x -= MouseDelta.Relative.y * MouseSensitivity;

            currentTilt.x = Mathf.Clamp(currentTilt.x, -40, 30);

            RotationDegrees = currentTilt;
        }
    }
}
