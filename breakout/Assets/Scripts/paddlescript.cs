using UnityEngine;
using System.Collections;

public class paddlescript : MonoBehaviour {

    public Collider paddle;
    public Collider ball;

    // Use this for initialization
    void Start ()
    {

	}



    // Update is called once per frame
    void Update ()
    {

        transform.Translate(10f * Time.deltaTime * Input.GetAxis("Horizontal"), 0, 0);
	
	}
}
