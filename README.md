# "Godotv4.2.2.stable.mono.official [15073afe3]" Bug

## Reproduction Steps:
1. Clone project
2. Open in Godot 4.2.2.stable.mono
3. Run game
4. Press Play
5. Wait for rock to crush bug
6. Press Reload button  (This freshly loads the game_scene)
7. Wait for rock to crush bug
8. Notice Object Disposed Exception error thrown:

`E 0:00:11:0202   GodotObject.base.cs:73 @ nint Godot.GodotObject.GetPtr(Godot.GodotObject): System.ObjectDisposedException: Cannot access a disposed object.
Object name: 'GameScene'.
  <C# Error>     System.ObjectDisposedException
  <C# Source>    /root/godot/modules/mono/glue/GodotSharp/GodotSharp/Core/GodotObject.base.cs:73 @ nint Godot.GodotObject.GetPtr(Godot.GodotObject)
  <Stack Trace>  GodotObject.base.cs:73 @ nint Godot.GodotObject.GetPtr(Godot.GodotObject)
                 Node.cs:689 @ void Godot.Node.AddChild(Godot.Node, bool, Godot.Node+InternalMode)
                 GameScene.cs:25 @ void GameScene.OnPlayerDied()
                 BugPlayer.cs:11 @ void BugPlayer.OnBodyEntered(Godot.RigidBody2D)
                 BugPlayer_ScriptMethods.generated.cs:34 @ bool BugPlayer.InvokeGodotClassMethod(Godot.NativeInterop.godot_string_name&, Godot.NativeInterop.NativeVariantPtrArgs, Godot.NativeInterop.godot_variant&)
                 CSharpInstanceBridge.cs:24 @ Godot.NativeInterop.godot_bool Godot.Bridge.CSharpInstanceBridge.Call(nint, Godot.NativeInterop.godot_string_name*, Godot.NativeInterop.godot_variant**, int, Godot.NativeInterop.godot_variant_call_error*, Godot.NativeInterop.godot_variant*)`

** Expected Result: **  Reloading a scene should Free/QueueFree any used resources and they should not be stuck in disposing in a freshly loaded scene.
