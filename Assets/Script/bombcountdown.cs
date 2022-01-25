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



    // Update is called once per frame
    void Update()
    {

        volume.profile.TryGetSettings(out _Vignette);

        _Vignette.intensity.value = VignetteInts;

        Debug.Log("bomb" + timeLeft);
        
        timeLeft -= Time.deltaTime;

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
}
