extends Label

func _process(delta):
	var score = get_parent().get_parent().get_parent().get_parent().score / 100
	text = str(score)
