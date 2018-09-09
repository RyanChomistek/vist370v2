using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableElement : MonoBehaviour {

	void Start () {
        transform.LookAt(Camera.main.transform);

        transform.RotateAround(transform.position, transform.up, 180f);
        transform.position = transform.position.normalized * 4;
    }
	
}
