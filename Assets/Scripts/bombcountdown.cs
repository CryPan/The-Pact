using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering.PostProcessing;

public class bombcountdown : MonoBehaviour
{
    float timeLeft = 300.0f;
    public Text Message;
    public PostProcessVolume volume;

    private Vignette _Vignette;
    float VignetteInts = 0;

    bool turnoffbomb = false; 


    void Start()
    {
        timeLeft = 300.0f;
        bool turnoffbomb = false;
    }
    // Update is called once per frame
    void Update()
    {
       
        Message.text = "" + timeLeft;

        volume.profile.TryGetSettings(out _Vignette);

        _Vignette.intensity.value = VignetteInts;

        Debug.Log("bomb" + timeLeft);
        
        if (turnoffbomb == false) 
        { 
        timeLeft -= Time.deltaTime;

        }


        if (timeLeft < 0)
        {
            StartCoroutine(boombomb());

        }
    }

    public IEnumerator boombomb()
    {

        VignetteInts = 1;
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(0);
    }

    public void wrongwire()
    {
        StartCoroutine(boombomb());
    }

    public void rightwire()
    {
        turnoffbomb = true;
    }

}
