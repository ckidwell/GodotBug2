using Godot;
using System;

public partial class BugPlayer : RigidBody2D
{
    public static Action PlayerDied;
    private void OnBodyEntered(RigidBody2D body)
    {
        if (body.Name != "RockRigidBody2D") return;
        
        PlayerDied?.Invoke();
    }
}
