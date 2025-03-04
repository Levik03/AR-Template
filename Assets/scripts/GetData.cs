using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
using UnityEngine.Networking;

public class GetData : MonoBehaviour
{
    public string DataURL;
    // Start is called before the first frame update
    void Start()
    {
        startCroutine(getData());
    }

IEnumerator GetData()
{
    using (UnityWebRequest request = UnityWebRequest.Get(DataURL))
    {
        yeild return request.SendWebRequest();
        
        if (request.result == UnityWebRequest.Result.ConnectionError)
        {
            Debug.LogError(request.error);
            
            }
            else
            {
                string json = request.downloadHandler.text;
                Debug.Log(json);
                }
                
            }
        }
}
