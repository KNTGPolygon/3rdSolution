using UnityEngine;
using System.Collections;

public class MenuController : MonoBehaviour {
	
	Ray ray;
	bool played = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		ray = Camera.mainCamera.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		
		if (Physics.Raycast(ray, out hit))
		{
			if (!played)
			{
				played = true;
				GameObject.Find("HighlightSound").GetComponent<AudioSource>().Play();
			}
			
			if (hit.transform.name == "NewGame")
			{
				GameObject.Find("NewGame2").GetComponent<MeshRenderer>().renderer.enabled = true;	
			}
			if (hit.transform.name == "LoadGame")
			{
				GameObject.Find("LoadGame2").GetComponent<MeshRenderer>().renderer.enabled = true;	
			}
			if (hit.transform.name == "Options")
			{
				GameObject.Find("Options2").GetComponent<MeshRenderer>().renderer.enabled = true;	
			}
			if (hit.transform.name == "Credits")
			{
				GameObject.Find("Credits2").GetComponent<MeshRenderer>().renderer.enabled = true;	
			}
			if (hit.transform.name == "Exit")
			{
				GameObject.Find("Exit2").GetComponent<MeshRenderer>().renderer.enabled = true;	
			}
		}
		else
		{
			played = false;
			if (GameObject.Find("NewGame2").GetComponent<MeshRenderer>().renderer.enabled)
			{
				GameObject.Find("NewGame2").GetComponent<MeshRenderer>().renderer.enabled = false;	
			}
			if (GameObject.Find("LoadGame2").GetComponent<MeshRenderer>().renderer.enabled)
			{
				GameObject.Find("LoadGame2").GetComponent<MeshRenderer>().renderer.enabled = false;	
			}
			if (GameObject.Find("Options2").GetComponent<MeshRenderer>().renderer.enabled)
			{
				GameObject.Find("Options2").GetComponent<MeshRenderer>().renderer.enabled = false;	
			}
			if (GameObject.Find("Credits2").GetComponent<MeshRenderer>().renderer.enabled)
			{
				GameObject.Find("Credits2").GetComponent<MeshRenderer>().renderer.enabled = false;	
			}
			if (GameObject.Find("Exit2").GetComponent<MeshRenderer>().renderer.enabled)
			{
				GameObject.Find("Exit2").GetComponent<MeshRenderer>().renderer.enabled = false;	
			}
		}
		
		if (Input.GetButtonUp("Fire1"))
		{
			if (Physics.Raycast(ray, out hit))
			{
				GameObject.Find("ClickSound").GetComponent<AudioSource>().Play();
				if ( hit.transform.name == "Exit")
				{
					Application.Quit();
				}
				if (hit.transform.name == "NewGame")
				{
					Application.LoadLevel(1);
				}
			}
		}
		
	}
}
