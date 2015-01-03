using UnityEngine;
using System.Collections;

public class RotateFollow : MonoBehaviour
{

    public Transform target;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 relativeVector = transform.position - target.position;
        transform.rotation = Quaternion.LookRotation(relativeVector);
    }

}
