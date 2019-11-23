using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translate : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform t = GetComponent<Transform>();

        Vector3 movement = new Vector3();

        movement.x = Input.GetAxis("Horizontal") * speed;
        movement.x *= Time.deltaTime;

        t.Translate(movement);
    }
}