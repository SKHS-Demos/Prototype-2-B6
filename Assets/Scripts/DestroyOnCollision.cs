using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // OnTriggerEnter is called on a collision (if isTrigger)
    private void OnTriggerEnter(Collider other) {
       Destroy(gameObject);
       Destroy(other.gameObject);
    }
}
