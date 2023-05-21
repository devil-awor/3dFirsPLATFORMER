using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class pampam : MonoBehaviour
{
    public UnityEvent eventa;
   
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            eventa.Invoke();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
