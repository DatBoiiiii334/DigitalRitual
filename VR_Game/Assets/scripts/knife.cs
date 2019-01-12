using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knife : MonoBehaviour {

    public bool isKnife;
    public bool isMaggot;

    public GameObject myCyst;

    public void Start()
    {
        //isKnife = false;
        //isMaggot = false;
    }


    private void OnCollisionEnter(Collision collision)
    {

        
            if (collision.gameObject.tag == "Cyst")
            {
                //Destroy(collision.gameObject);
                myCyst.gameObject.SetActive(false);
                Debug.Log("Stabbed");
            }
            
        

        if (isMaggot == true)
        {
            if (collision.gameObject.tag == "Wound")
            {
                //Destroy(collision.gameObject);
                collision.gameObject.SetActive(false);
            }
           
        }

    }//Einde collision
}
