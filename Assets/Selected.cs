using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selected : MonoBehaviour {
	[SerializeField]
	public Material[] materials;
	public Renderer rend;

	private int index = 1;

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();
		rend.enabled = true;
		
	}
	
	// Update is called once per frame
	void OnMouseDown() {
		if(Input.GetMouseButtonDown (0)) {
			index += 1;
			if(index == materials.Length+1) {
				index = 1; 
			}
			rend.sharedMaterial = materials[index-1];
		}
		
	}
}
