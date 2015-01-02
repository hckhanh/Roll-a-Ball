using UnityEngine;
using UnityEngine.UI;

public class PlayerControler : MonoBehaviour
{

    public float speed;
    public Text countText;
    public Text winText;
    private int count;

    // Use this for initialization
    void Start()
    {
        count = 0;
        SetCountText();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rigidbody.AddForce(movement * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PickUp")
        {
            Destroy(other.gameObject);
            count++;
            SetCountText();
            if (count == 15)
                winText.gameObject.SetActive(true);
        }
    }

    private void SetCountText()
    {
        countText.text = "Count: " + count;
    }
}
