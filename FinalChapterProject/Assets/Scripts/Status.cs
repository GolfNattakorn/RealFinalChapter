using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Status : MonoBehaviour
{
    public Registration registration;
   
    public Text textYourname;


    // Start is called before the first frame update
    void Start()
    {
        NameStatus();
 
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    private void NameStatus()
    {
        if (registration.yourname == registration.yourName.text)
        {
            textYourname.text = registration.yourname;
            Debug.Log("NameCorrect");
        }
    }



}
