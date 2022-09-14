using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Networking;


public class timeTeller : MonoBehaviour
{
    public GameObject timeTextObject;

    string url = "https://worldtimeapi.org/api/timezone/America/New_York";
    
    // Start is called before the first frame update & every 10 seconds after
    void Start()
    {
    InvokeRepeating("GetDataFromWeb", 0f, 10f);   
    }

    void GetDataFromWeb()
   {

       StartCoroutine(GetRequest(url));
   }
   
    IEnumerator GetRequest(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();


            if (webRequest.result ==  UnityWebRequest.Result.ConnectionError)
            {
                Debug.Log(": Error: " + webRequest.error);
            }
            else
            {
                // print out the time data to make sure it makes sense
                Debug.Log(":\nReceived: " + webRequest.downloadHandler.text);

            	int startTime = webRequest.downloadHandler.text.IndexOf("datetime",0);
                string temp = webRequest.downloadHandler.text.Substring(startTime+22, 5);
                double hour = float.Parse(temp.Substring(0,2));
                string minute = temp.Substring(3,2);

                string amOrPm = "";
                Debug.Log(":\nHour: " + hour);

               if ((hour / 12) >= 1) {
                    amOrPm = "PM";
                } else {
                    amOrPm = "AM";
                }

                double hour12 = hour % 12; 

                if (hour12 == 0){
                    hour12 = 12;
                }

                timeTextObject.GetComponent<TextMeshPro>().text = hour12.ToString()  + ":" + minute + " "  + amOrPm;            
            }
        }
    }
}