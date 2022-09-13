using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Networking;


public class TimeTeller24 : MonoBehaviour
{
    public GameObject timeTextObject24;

    string url = "https://worldtimeapi.org/api/timezone/Asia/Tokyo";
    
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


                timeTextObject24.GetComponent<TextMeshPro>().text = temp ;
            }
        }
    }
}
