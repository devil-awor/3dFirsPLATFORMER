using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ModelSwither : MonoBehaviour
{
      public KeyCode Key;
    public UnityEvent OnSwitch;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(Key))
        {
            OnSwitch.Invoke();
        }
    }
}
