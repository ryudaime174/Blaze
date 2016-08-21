using UnityEngine;
using System.Collections;

public class ballscript : MonoBehaviour {

    public Rigidbody rb;
    Vector3 oldVel;


	// Use this for initialization
	void Start () {

        
        rb.AddForce(100f, 500f, 0);
        rb = GetComponent<Rigidbody>();
	}
	
    void onCollisionEnter (Collision c)
    {
        ContactPoint cp = c.contacts[0];
        //calculate with addition of normal vector

        //calculate with Vector3.Reflect
        rb.velocity = Vector3.Reflect(oldVel, cp.normal);
        //bumper effect to speed up ball
        rb.velocity += cp.normal * 2.0f;
    }

    void FixedUpdate()
    {
        oldVel = rb.velocity;
    }
 

	// Update is called once per frame
	void Update () {
	
	}
}
