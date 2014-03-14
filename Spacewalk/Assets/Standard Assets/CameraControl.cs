using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

	public Transform target;
	public Transform cam;
	bool derp=true;

	// Use this for initialization
	void Start () {
	
	}

	void Update(){
		if (Input.GetKey (KeyCode.K)){
			derp=!derp;
		}
		
		if(derp){
		transform.rotation=Quaternion.Slerp(transform.rotation, cam.rotation, Time.deltaTime);
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(derp){
		//transform.Rotate(Vector3.up);
		//transform.Translate(Vector3.forward * 0.01f);
		if (Input.GetKey (KeyCode.W)) {
			transform.Rotate(Vector3.left*.5f);

			}
		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate(Vector3.down*.5f);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.Rotate(Vector3.right*.5f);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Rotate(Vector3.up*.5f);
		}
		if (Input.GetKey ("space")){
			rigidbody.AddForce(target.forward*10);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Rotate(new Vector3(0,0,.5f));
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Rotate(new Vector3(0,0,-.5f));
		}
		
		if (Input.GetKey (KeyCode.F)) {
			rigidbody.angularDrag=.6f;
			rigidbody.drag=.6f;
		}else{
			rigidbody.drag=0;
			rigidbody.angularDrag=0;
		}
	}
	}

}
