using UnityEngine;
using System.Collections;

public class CameraControler : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position;
        Debug.Log(transform.position);
	}   
	
	// Update is called once per frame
	void LateUpdate () {
        Debug.Log(player.transform.position);
        transform.position = player.transform.position + offset;
	}
}
