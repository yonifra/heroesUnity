using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float directionalForce = 1500f;
    public float jumpingForce = 2500f;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rigidbody.AddForce(directionalForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rigidbody.AddForce(-directionalForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.W))
        {
            rigidbody.AddForce(0, 0, directionalForce * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rigidbody.AddForce(0, 0, -directionalForce * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            rigidbody.AddForce(0, jumpingForce * Time.deltaTime, 0);
        }
    }
}
