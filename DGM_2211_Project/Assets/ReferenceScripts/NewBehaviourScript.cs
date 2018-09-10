




public bool Crouch;
 
public void Update()
{
 
if(Input.GetButtonDown("Crouch"))
{
//Only apply  to collider(CharacterController)
 
transform.localScale -= new Vector3(0,0.5F,0);
Crouch = true;
}
else
{
//Get Back to same position?
Crouch = false;
}
}