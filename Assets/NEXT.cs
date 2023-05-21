using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NEXT : MonoBehaviour
{
   public int level;

    public void Next()  
    {
        SceneManager.LoadScene(level);
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

