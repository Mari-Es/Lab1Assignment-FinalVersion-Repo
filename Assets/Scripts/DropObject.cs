using UnityEngine;

public class DropObject : MonoBehaviour

{
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;  // Disable gravity at the start
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            rb.useGravity = true;  // Enable gravity when "F" key is pressed
        }
    }
}

