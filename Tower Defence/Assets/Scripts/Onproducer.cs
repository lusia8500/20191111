using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Onproducer : MonoBehaviour
{

    public GameObject Panel;
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        Panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Panel.SetActive(false);
        }
    }

    public void Producer()
    {
        Panel.SetActive(true);
    }
}
