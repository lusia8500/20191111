using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class NextPanel : MonoBehaviour
{

    public GameObject Panel1;
    public GameObject Panel2;
    public GameObject Panel3;
    //public GameObject Panel4;

    public GameObject CurrentTouch;

    // Start is called before the first frame update
    void Start()
    {
        Panel1.SetActive(false);
        Panel2.SetActive(false);
        Panel3.SetActive(false);
        //Panel4.SetActive(false);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))

        {

            RaycastHit hit;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Physics.Raycast(ray, out hit);

            Debug.DrawRay(ray.origin, ray.direction * 10f, Color.red, 5f);

            Debug.Log(hit.collider);


            if (hit.collider.tag =="Box")

            {

                Trigger2();

                

                

            }

        }



        
    }

    public void Trigger1()
    {
        Panel1.SetActive(true);
    }

    public void Trigger2()
    {
        Panel2.SetActive(true);
    }

    public void Trigger3()
    {
        Panel3.SetActive(true);
    }

    //public void Trigger4()
    //{
    //    Panel4.SetActive(true);
    //}

    

   
}
