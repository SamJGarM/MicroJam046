using Godot;
using System;

public partial class StartMenu : Control
{
	public override void _Ready(){
		GetNode<Button>("%StartBtn").Pressed += _Play; 
		GetNode<Button>("%QuitBtn").Pressed += _Quit;
	}
	private void _Play(){	
		GetTree().ChangeSceneToFile("res://Scenes/MainScene/Main.tscn");
	}
	
	private void _Quit(){
		GetTree().Quit();
	}
}
