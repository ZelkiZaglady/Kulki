using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public Transform sphere;
	
	void Update ()
    {
        Rigidbody rigidbody = sphere.GetComponent<Rigidbody>();

        Vector3 vector = new Vector3(-5f, 3f, 0);
        float velocity = rigidbody.velocity.sqrMagnitude;
        vector = vector * (1f + velocity/15f);

        Vector3 newPosition = sphere.position + vector;

        transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime*2f);
        transform.LookAt(sphere);
	}
}
