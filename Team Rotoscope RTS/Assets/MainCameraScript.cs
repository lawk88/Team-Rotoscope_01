//Kellen Fenton
//Berklee College of Music
//Logic and Programming
//Main Camera Script
using UnityEngine;
public class MainCameraScript : MonoBehaviour {

	public float panSpeed = 20f;
	
	public float panBorderThickness = 10f;
	public float Height = 80;

	public float scrollSpeed = 20f;
	public float minY = 20f;
	public float maxY = 120f; 
	void FixedUpdate () {
		Vector3 pos = transform.position;

		if (Input.GetKey("w") || Input.mousePosition.y >=Screen.height - panBorderThickness)
		{
			pos.z += panSpeed * Time.deltaTime; 
		}
			
		if (Input.GetKey("s") || Input.mousePosition.y <= panBorderThickness)
		{
			pos.z -= panSpeed * Time.deltaTime; 
		}
		if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorderThickness)
		{
			pos.x += panSpeed * Time.deltaTime; 
		}
		if (Input.GetKey("a") || Input.mousePosition.x <= panBorderThickness)
		{
			pos.x -= panSpeed * Time.deltaTime; 
	
		}

		float scroll = Input.GetAxis("Mouse ScrollWheel"); 
		pos.y -= scroll * scrollSpeed * 100f * Time.deltaTime;
		pos.y = Mathf.Clamp(pos.y, minY, maxY);

		transform.position = pos;
	}

}
