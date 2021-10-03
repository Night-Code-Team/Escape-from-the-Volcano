extends Spatial

var road_1 = load("res://scene/Tiles_road/road_1.tscn")
var road_1_hole_1 = load("res://scene/Tiles_road/road_1_hole_1.tscn")
var road_1_hole_2 = load("res://scene/Tiles_road/road_1_hole_2.tscn")
var road_1_hole_3 = load("res://scene/Tiles_road/road_1_hole_3.tscn")
var road_1_lava_1 = load("res://scene/Tiles_road/road_1_lava_1.tscn")
var road_1_stone_1 = load("res://scene/Tiles_road/road_1_stone_1.tscn")
var road_1_crack_1 = load("res://scene/Tiles_road/road_1_crack_1.tscn")
var road_1_crack_2 = load("res://scene/Tiles_road/road_1_crack_2.tscn")
var road_2 = load("res://scene/Tiles_road/road_2.tscn")
var road_2_crack_1 = load("res://scene/Tiles_road/road_2_crack_1.tscn")
var road_2_hole_1 = load("res://scene/Tiles_road/road_2_hole_1.tscn")
var road_2_hole_2 = load("res://scene/Tiles_road/road_2_hole_2.tscn")
var road_3 = load("res://scene/Tiles_road/road_3.tscn")
var road_3_crack_1 = load("res://scene/Tiles_road/road_3_crack_1.tscn")

var grass = load("res://scene/Tiles_env/grass.tscn")
var grass_hole_1 = load("res://scene/Tiles_env/grass_hole_1.tscn")
var grass_house_1 = load("res://scene/Tiles_env/grass_house_1.tscn")
var grass_forest = load("res://scene/Tiles_env/grass_forest.tscn")

var rng = RandomNumberGenerator.new()

var roads = [
	road_1,
	road_1_hole_1,
	road_1_hole_2,
	road_1_hole_3,
	road_1_lava_1,
	road_1_stone_1,
	road_1_crack_1,
	road_1_crack_2,
	road_2,
	road_2_crack_1,
	road_2_hole_1,
	road_2_hole_2,
	road_3,
	road_3_crack_1
]

var env = [
	grass,
	grass_hole_1,
	grass_house_1,
	grass_forest
]

func _ready():
	rng.randomize()
	_init_spawn()
	print(get_child_count())
	pass
	
func _process(delta):
	var score = get_parent().score
	var grid = score / 50
	print(grid)
	#spawn()


func spawn():
	var my_random_number = floor(rng.randf_range(0, 13))
	var new_road = roads[my_random_number].instance()
	new_road.translate(Vector3(0,-0.75,6.4))
	add_child(new_road)

	my_random_number = floor(rng.randf_range(0, 4))
	var new_env1 = env[my_random_number].instance()
	new_env1.translate(Vector3(6.4,-0.75,6.4))
	add_child(new_env1)

	my_random_number = floor(rng.randf_range(0, 4))
	var new_env2 = env[my_random_number].instance()
	new_env2.translate(Vector3(-6.4,-0.75,6.4))
	add_child(new_env2)


func _init_spawn():
	for i in range(100):
		var my_random_number = floor(rng.randf_range(0, 13))
		var new_road = roads[my_random_number].instance()
		new_road.translate(Vector3(0,-0.75,6.4*i))
		add_child(new_road)

		my_random_number = floor(rng.randf_range(0, 4))
		var new_env1 = env[my_random_number].instance()
		new_env1.translate(Vector3(6.4,-0.75,6.4*i))
		add_child(new_env1)

		my_random_number = floor(rng.randf_range(0, 4))
		var new_env2 = env[my_random_number].instance()
		new_env2.translate(Vector3(-6.4,-0.75,6.4*i))
		add_child(new_env2)
