using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class Thow : MonoBehaviour
{

    private Rigidbody rb;
    public Vector3 rb2;
    public int x;
    public int y;
    public int z;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = new Vector3(x,y,z);
        }
        */
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            // Get movement of the finger since last frame
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;

            rb.velocity = new Vector3(0,9,0);
            rb.AddTorque(transform.up * -touchDeltaPosition.x * 120);
            
            rb.AddTorque(transform.right * touchDeltaPosition.y * 80);
        }
        
    }
}
