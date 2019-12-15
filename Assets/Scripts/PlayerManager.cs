using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float directionalForce = 1500f;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("d"))
        {
            rigidbody.AddForce(directionalForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            rigidbody.AddForce(-directionalForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("w"))
        {
            rigidbody.AddForce(0, 0, directionalForce * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            rigidbody.AddForce(0, 0, -directionalForce * Time.deltaTime);
        }
    }
}
