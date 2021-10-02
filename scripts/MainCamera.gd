extends KinematicBody

const hardmod = 1
const startvale = 5

var time = 0
var smalltimer = 0

func speed():
	var SPEED = time/hardmod + startvale
	return SPEED

func _physics_process(delta):
	smalltimer += 1
	if smalltimer >= 100:
		smalltimer = 0
		time += 1

	var vect = Vector3()
				
	vect = vect.normalized()
	vect.z = speed()
	
	move_and_slide(vect, Vector3(0,1,0))

