using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    private bool firstPress = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PressPlay()
    {
        Debug.Log("press play");
        if(!firstPress)
        {
            Debug.Log("go next scene");
            SceneManager.LoadScene("play");
            firstPress = true;
        }
    }
}
