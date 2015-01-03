using UnityEngine;
using System.Collections;

public class MagicRotate : MonoBehaviour
{

    public Transform target;
    private bool rotateActivated = false;
    public float radius;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rotateActivated)
            UpdateRotate();
    }

    private void UpdateRotate()
    {
        Vector3 relativeVector = (target.position + new Vector3(0, 1.5f, 0)) - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativeVector);

        Quaternion currentRotate = transform.localRotation;

        transform.localRotation = Quaternion.Slerp(currentRotate, rotation, radius * Time.deltaTime);
        transform.Translate(0, 0, 3 * Time.deltaTime);

    }

    public void ActiveRotate()
    {
        rotateActivated = true;
    }
}
