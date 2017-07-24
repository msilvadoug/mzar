using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbscript : MonoBehaviour, IVirtualButtonEventHandler {

	private GameObject vbButtonObject;
	public GameObject Cube;
	private GameObject Player;

	// Use this for initialization
	void Start () {

		vbButtonObject = GameObject.Find ("actionButton");
		vbButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
	
	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb){


			
		Destroy(Player, 5f);


		Debug.Log ("Ta funfando");
	}

	public void OnButtonReleased (VirtualButtonAbstractBehaviour vb) {
	
	}
}
