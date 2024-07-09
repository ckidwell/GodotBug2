using Godot;
using System;

public partial class SpriteButton2D : Sprite2D
{
    public override void _Input(InputEvent @event)
    {
        if (@event is InputEventMouseButton {ButtonIndex: MouseButton.Left})
        {
            GetTree().ChangeSceneToFile("res://scenes/game_scene.tscn");
        }
    }
}
