using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
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
        t.Rotate(Vector3.up * Input.GetAxis("Horizontal") * speed * Time.deltaTime);
    }
}
