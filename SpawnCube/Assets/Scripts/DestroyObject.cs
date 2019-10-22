using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y <= -10)
        {
            DestroyCube();
        }
    }
    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.name == "Destroyer")
        {
            DestroyCube();
        }
    }
    void DestroyCube()
    {
        Destroy(this.gameObject);
    }
}
