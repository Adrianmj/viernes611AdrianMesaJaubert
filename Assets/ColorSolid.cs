using UnityEngine;
using System.Collections;

public class ColorSolid : MonoBehaviour
{
	public GameObject target; //the enemy's target
	void Start () 
	{
		GetComponent<Renderer>().material.color = RandomColour();
	} 
	
	private Color RandomColour()
	{
		float r = Random.value;
		float g = Random.value;
		float b = Random.value;
		
		return new Color(r, g, b);
	}

	void Swap() {
		Vector3 temp = transform.position;
		transform.position = target.transform.position;
		target.transform.position = temp;
	}
	void Update(){
		if (Input.GetKeyDown ("space"))
			Swap ();
		
	}
}