#pragma strict

function Start () {
	
}

function Update () {
// suihei move
transform.rotation *=
Quaternion.AngleAxis(Input.GetAxis("Horizontal") * 30.0 * Time.deltaTime, Vector3(0,0,-1));
// suichok move 
transform.rotation *=
Quaternion.AngleAxis(Input.GetAxis("Vertical") * 30.0 * Time.deltaTime, Vector3(1,0,0));




}
