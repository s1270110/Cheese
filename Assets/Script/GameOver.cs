using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private bool firstPress = false;
    public bool gameOverFlag = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PressTitle()
    {
        Debug.Log("press title");
        if(!firstPress)
        {
            Debug.Log("go title");
            SceneManager.LoadScene("title");
            firstPress = true;
        }
    }

    public void PressContinue(){
        Debug.Log("press continue");
        if(!firstPress){
            Debug.Log("go continue");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            firstPress = true;
        }
    }
}
