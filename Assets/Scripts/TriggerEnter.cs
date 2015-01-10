using UnityEngine;
using System.Collections;

public class TriggerEnter : MonoBehaviour
{

    public MagicRotate magicCube;
    public Animator animator;

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
            //animator.enabled = false;
            StartCoroutine(WaitAndCastMagic());
            //magicCube.ActiveRotate();
        }
    }

    private IEnumerator WaitAndCastMagic()
    {
        //animator.SetTrigger(Animator.StringToHash("FlyUp"));
        animator.SetTrigger("FlyUp");
        yield return new WaitForSeconds(2.0f);
        animator.enabled = false;
        magicCube.ActiveRotate();
    }

}
