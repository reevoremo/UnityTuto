using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public KeyCode firebutton;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(firebutton))
        {
            Debug.Log("Hey SHoot");
        }
        
    }
}
