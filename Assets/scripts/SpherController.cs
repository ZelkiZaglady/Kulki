using UnityEngine;
using System.Collections;

public class SpherController : MonoBehaviour {

    int layer = 0;

    Rigidbody rigidbody;

    void Start() {

        rigidbody = transform.GetComponent<Rigidbody>(); //fizyka kuli

    }

	void Update () {
        
        changePosition();
        changeLayer();

    }

    void changeLayer() {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            bool isSomething = Physics.Raycast(transform.position, Vector3.right, 10f);

            if (!isSomething) {

                layer = 1;
            
            }

        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {

            bool isSomething = Physics.Raycast(transform.position, Vector3.left, 10f);

            if (!isSomething)
            {

                layer = 0;

            }

        }

        float delta = (layer * 2f - 2f) - rigidbody.position.x;
        Vector3 velocity = rigidbody.velocity;
        velocity.x = delta *2f - 0.5f;
        rigidbody.velocity = velocity;

    }

    void changePosition() {

        Vector3 direction = Vector3.zero;
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {

            direction = -Vector3.left;

        }

        if (Input.GetKey(KeyCode.RightArrow))
        {

            direction = Vector3.left;

        }

        rigidbody.AddTorque(direction * 20f);

    }

}
