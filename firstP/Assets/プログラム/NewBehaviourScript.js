#pragma strict

function Update () {
// suihei move
transform.rotation *=
Quaternion.AngleAxis(Input.GetAxis("Horizontal") * 50.0 * Time.deltaTime, Vector3(0,0,-1));
// suichok move 
transform.rotation *=
Quaternion.AngleAxis(Input.GetAxis("Vertical") * 50.0 * Time.deltaTime, Vector3(1,0,0));

if (Input.GetKey(KeyCode.Escape)) {
Application.Quit();
}


}
