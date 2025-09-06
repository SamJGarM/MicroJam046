using Godot;
using System;

public partial class MainDesk : Control
{
	
	[Export] public PackedScene ComputerScene {get; set;}
	[Export] public PackedScene LandlineScene {get; set;}
	[Export] public PackedScene CellScene {get; set;}
	
	public override void _Ready(){
		GetNode<TextureButton>("ComputerBtn").Pressed += () => ChangeTo(ComputerScene);
		GetNode<TextureButton>("LandlineBtn").Pressed += () => ChangeTo(LandlineScene);
		GetNode<TextureButton>("CellBtn").Pressed += () => ChangeTo(CellScene);
	}
	
	private void ChangeTo(PackedScene scene){
		if(scene == null){
			GD.PushWarning("You have to asing the scene in the inspector my man.");
			return;
		}
		GetTree().ChangeSceneToPacked(scene);
	}
}
