using Godot;

public partial class GameScene : Node2D
{
    private Timer timer;
    [Export] private PackedScene rock;
    [Export] private PackedScene restartButton;
    private Sprite2D button;
    private RigidBody2D rBody;
    public override void _Ready()
    {
        timer = GetNode<Timer>("Timer");
        timer.Timeout += OnTimerExpired;

        BugPlayer.PlayerDied += OnPlayerDied;
    }

    private void OnPlayerDied()
    {
        button = restartButton.Instantiate() as Sprite2D;
        
        if (button == null) return;
        
        button.Position = new Vector2(103, 230);
        AddChild(button);
    }
    
    private void OnTimerExpired()
    {
        rBody = rock.Instantiate() as RigidBody2D;
        
        if (rBody == null) return;
        
        rBody.Position = new Vector2(105, 64);
        AddChild(rBody);
    }
}
