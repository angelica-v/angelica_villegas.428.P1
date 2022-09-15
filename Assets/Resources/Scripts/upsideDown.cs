using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upsideDown : MonoBehaviour
{
    bool lightCheck;
    string upOrDownCheck;

    Light purpleFrontLight;
    Light purpleBackLight;
    Light blueFrontLight;
    Light blueBackLight;

    Light redFrontLight;
    Light redBackLight;
    Light orangeFrontLight;
    Light orangeBackLight;

    Light orangeLight;
    Light blueLight;
    
    // Start is called before the first frame update
    void Start()
    {
       lightCheck = true;

       // Lighting 1
       purpleFrontLight =  GameObject.Find("Purple Spot Light Front").GetComponent<Light>();
       purpleBackLight =  GameObject.Find("Purple Spot Light Back").GetComponent<Light>();
       blueFrontLight =  GameObject.Find("Blue Spot Light Front").GetComponent<Light>();
       blueBackLight =  GameObject.Find("Blue Spot Light Back").GetComponent<Light>();

       blueLight =  GameObject.Find("Blue Spot Light").GetComponent<Light>();

       // Lighting 2
       redFrontLight =  GameObject.Find("Red Spot Light Front").GetComponent<Light>();
       redBackLight =  GameObject.Find("Red Spot Light Back").GetComponent<Light>();
       orangeFrontLight =  GameObject.Find("Orange Spot Light Front").GetComponent<Light>();
       orangeBackLight =  GameObject.Find("Orange Spot Light Back").GetComponent<Light>();

       orangeLight =  GameObject.Find("Orange Spot Light").GetComponent<Light>();

       redFrontLight.enabled = !redFrontLight.enabled;
       redBackLight.enabled = !redBackLight.enabled;
       orangeFrontLight.enabled = !orangeFrontLight.enabled;
       orangeBackLight.enabled = !orangeBackLight.enabled;
       orangeLight.enabled = !orangeLight.enabled;
    }

    // Update is called once per frame
    void Update()
    {
        float zDegrees = transform.localRotation.eulerAngles.z;

        if((zDegrees > 160 && zDegrees < 200) || (zDegrees < -160 && zDegrees > -200)) {
             if (upOrDownCheck != "down") {
                lightCheck = !lightCheck;

                // Lighting 1
                purpleFrontLight.enabled = !purpleFrontLight.enabled;
                purpleBackLight.enabled = !purpleBackLight.enabled;
                blueFrontLight.enabled = !blueFrontLight.enabled;
                blueBackLight.enabled = !blueBackLight.enabled;
                blueLight.enabled = !blueLight.enabled;

                // Lighting 2
                redFrontLight.enabled = !redFrontLight.enabled;
                redBackLight.enabled = !redBackLight.enabled;
                orangeFrontLight.enabled = !orangeFrontLight.enabled;
                orangeBackLight.enabled = !orangeBackLight.enabled;
                orangeLight.enabled = !orangeLight.enabled;

                upOrDownCheck = "down";
             }
        } else {
            upOrDownCheck = "up";
        }


        Debug.Log("CHECK 2: " + zDegrees.ToString() + "      " + upOrDownCheck + "       " + lightCheck);
    }
}
