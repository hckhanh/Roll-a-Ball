using UnityEngine;
using System.Collections;

public class CubeCollider : MonoBehaviour {

    public float hoverForce = 12f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerStay(Collider other)
    {
        other.rigidbody.AddForce(Vector3.up * hoverForce);
    }
}
