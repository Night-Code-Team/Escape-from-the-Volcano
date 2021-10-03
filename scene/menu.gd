extends Control

var game = "res://scene/Main.tscn";

func _on_Start_pressed():
	get_tree().change_scene(game);


func _on_Quit_pressed():
	get_tree().quit()
