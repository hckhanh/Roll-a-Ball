using UnityEngine;
using System.Collections;

public class TriggerEnter : MonoBehaviour
{

    public MagicRotate magicCube;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            magicCube.ActiveRotate();
        }
    }

}
