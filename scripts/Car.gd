extends KinematicBody

const hardmod = 1
const startvale = 5

const SLIDE = 5

const y_pos = 0

var time = 0
var smalltimer = 0

func _ready():
	pass 

func speed():
	var SPEED = time/hardmod + startvale
	return SPEED

func _physics_process(delta):
	smalltimer += 1
	if smalltimer >= 100:
		smalltimer = 0
		time += 1

		
	var vect = Vector3()
	if Input.is_action_pressed("ui_up"):
		vect.x += 1
	if Input.is_action_pressed("ui_down"):
		vect.x -= 1
				
	vect = vect.normalized()
	vect.z = speed()
	vect.x *= SLIDE
	
	move_and_slide(vect, Vector3(0,1,0))

