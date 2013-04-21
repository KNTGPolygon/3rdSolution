using UnityEngine;
using System.Collections;

public class Trigger1 : MonoBehaviour {
	
	public Material[] material;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
    void OnTriggerEnter(Collider other) {
		if (other.gameObject.name== "Player")
		{
			//gameObject.transform.parent.gameObject.GetComponent<Material>().color = new Color(0.5f, 0.2f, 0.3f);
			gameObject.transform.parent.gameObject.GetComponent<MeshRenderer>().material = material[1];
		}
	}
	
	void OnTriggerExit(Collider other) {
		if (other.gameObject.name== "Player")
		{
			//gameObject.transform.parent.gameObject.GetComponent<Material>().color = new Color(0.5f, 0.2f, 0.3f);
			gameObject.transform.parent.gameObject.GetComponent<MeshRenderer>().material = material[0];
		}
	}
	
}
