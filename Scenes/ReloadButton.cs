using Godot;

public partial class ReloadButton : Sprite2D
{
    public override void _Input(InputEvent @event)
    {
        if (@event is not InputEventMouseButton {ButtonIndex: MouseButton.Left}) return;
        
        var inside = GetRect().HasPoint(ToLocal(GetGlobalMousePosition()));
        if (!inside) return;
        
        GetTree().ChangeSceneToFile("res://scenes/game_scene.tscn");
        //GetTree().ChangeSceneToFile("res://scenes/main_menu.tscn");
    }
}
