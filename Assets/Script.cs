using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{

    public float speed;
    public float rotationSpeed;

    // Use this for initialization
    void Start()
    {
        speed = 10.0f;
        rotationSpeed = 100.0f;
    }

    // Update is called once per frame
    void Update()
    {
        float vTranslation = Input.GetAxis("Vertical") * speed;
        float hTranslation = Input.GetAxis("Horizontal") * speed;
        float hrotation = Input.GetAxis("Mouse X") * rotationSpeed;
		float vrotation = Input.GetAxis("Mouse Y") * rotationSpeed;


        vTranslation *= Time.deltaTime;
        hTranslation *= Time.deltaTime;
        hrotation *= Time.deltaTime;
		vrotation *= Time.deltaTime;

        transform.Translate(hTranslation, 0, vTranslation);
        transform.Rotate(vrotation, hrotation, 0);
    }

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "yellowBrick") {
			Destroy (other.gameObject);
		}
	}
}
