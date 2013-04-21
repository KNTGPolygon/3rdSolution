using UnityEngine;
using System.Collections;

public class ColliderController : MonoBehaviour {
	
	public GameObject apple;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerStay(Collider other) {
		if (other.gameObject.name== "Player")
		{
			  if (Input.GetKey(KeyCode.A)) {
			    other.gameObject.transform.position = new Vector3(other.gameObject.transform.position.x - 5, other.gameObject.transform.position.y, other.gameObject.transform.position.z);
			   }
			   if (Input.GetKey(KeyCode.D)) {
			    other.gameObject.transform.position = new Vector3(other.gameObject.transform.position.x + 5, other.gameObject.transform.position.y, other.gameObject.transform.position.z);
			   }
			   if (Input.GetKey(KeyCode.W)) {
			    other.gameObject.transform.position = new Vector3(other.gameObject.transform.position.x, other.gameObject.transform.position.y, other.gameObject.transform.position.z + 5);
			   }
			   if (Input.GetKey(KeyCode.S)) {
			    other.gameObject.transform.position = new Vector3(other.gameObject.transform.position.x, other.gameObject.transform.position.y, other.gameObject.transform.position.z - 5);
			   }
			
			Instantiate(apple, new Vector3(Random.Range(-200,200),0,Random.Range(-100,100)), apple.transform.rotation);
		}
	}
}
