using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class invicibilityframes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis ("Horizontal") = speed = Time.deltaTime;
        float y = Input.GetAxis ("Vertical") = speed = Time.deltaTime;
        float z = gameObject.transform.position.z;

        gameObject.transform.Translate(x, y, z);
    }
    void OndiscCollision
    {
        if(Collision.gameObject.tag == "disc"
        {
                Destroy(Collision.gameObject);
                

        
}
