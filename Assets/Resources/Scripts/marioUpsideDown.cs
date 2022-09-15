using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class marioUpsideDown : MonoBehaviour
{
    bool lightingSetting;
    string lastUporDown;

    Light flagSpotLight;
    Light directionalLight;
    Light redDirectionalLight;
    Light yellowLight1;
    Light yellowLight2;
    
    // Start is called before the first frame update
    void Start()
    {
        lightingSetting = true;

        // Lighting 1
        flagSpotLight =  GameObject.Find("Flag Spot Light").GetComponent<Light>();
        directionalLight =  GameObject.Find("Directional Light").GetComponent<Light>();

        // Lighting 2
        redDirectionalLight =  GameObject.Find("Red Directional Light").GetComponent<Light>();
        yellowLight1 =  GameObject.Find("Yellow Spot Light").GetComponent<Light>();
        yellowLight2 =  GameObject.Find("Yellow Spot Light 2").GetComponent<Light>();

        // turns off any lights in lighting 2
        yellowLight1.enabled = !yellowLight1.enabled;
        yellowLight2.enabled = !yellowLight2.enabled;
        redDirectionalLight.enabled = !redDirectionalLight.enabled;
    }

    // Update is called once per frame
    void Update()
    {
        // gets angle of cube
        float angleZ = transform.localRotation.eulerAngles.z;
        
        if((angleZ > 160 && angleZ < 200) || (angleZ < -160 && angleZ > -200)) {
            if (lastUporDown != "down") {
                lightingSetting = !lightingSetting;

                // lighting 1
                flagSpotLight.enabled = !flagSpotLight.enabled;
                directionalLight.enabled = !directionalLight.enabled;

                // lighting 2 
                redDirectionalLight.enabled = !redDirectionalLight.enabled;
                yellowLight1.enabled = !yellowLight1.enabled;
                yellowLight2.enabled = !yellowLight2.enabled;

                // to track status
                lastUporDown = "down";
            }
            
        } else {
            lastUporDown = "up";
        }
        Debug.Log("CHECK: " + angleZ.ToString() + "      " + lastUporDown + "       " + lightingSetting);
    }
}
