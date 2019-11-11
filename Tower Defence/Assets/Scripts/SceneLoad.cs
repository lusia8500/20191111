﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    public Slider progressbar;
    public Text loadtext;
    private void Start()
    {
        StartCoroutine(LoadScene());
    }


    IEnumerator LoadScene()
    {
        yield return null;
        AsyncOperation operation = SceneManager.LoadSceneAsync("Tutorial");
        operation.allowSceneActivation = false;

        while(!operation.isDone)
        {
            yield return null;
            if(progressbar.value<1f)
            {
                progressbar.value = Mathf.MoveTowards(progressbar.value, 1f, Time.deltaTime);

            }
            else
            {
                loadtext.text = "Please Touch";
            }

            if(Input.GetMouseButton(0) && progressbar.value >= 1f && operation.progress >= 0.9f)
            {
                operation.allowSceneActivation = true;
            }
        }



    }


}
