#pragma strict

function Start () {

};
function OnTriggerEnter (col : Collider ) {
 
 Debug.Log(col.gameObject.name);
 if(col.gameObject.name == "Tank"){
  Application.LoadLevel("map2");
 }

}
