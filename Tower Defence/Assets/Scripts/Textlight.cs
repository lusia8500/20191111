using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Textlight : MonoBehaviour
{

    public Text txtTest;
    bool isHide = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isHide)
        {
            Color color = txtTest.color;
            color.a = color.a - Time.deltaTime;
            if(color.a<0)
            {
                color.a = 0.0f;
                isHide = false;
            }

            txtTest.color = color;
        }

        else
        {
            Color color = txtTest.color;
            color.a = color.a + Time.deltaTime;

            if(color.a>1)
            {
                color.a = 1.0f;
                isHide = true;

            }
            txtTest.color = color;
        }
    }
}
