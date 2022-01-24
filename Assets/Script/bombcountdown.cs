using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class bombcountdown : MonoBehaviour
{
    float timeLeft = 300.0f;
    public Text Message; 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        Debug.Log("bomb" + timeLeft);
        
        timeLeft -= Time.deltaTime;

        if (timeLeft < 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
