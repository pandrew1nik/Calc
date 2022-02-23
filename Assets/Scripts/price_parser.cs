using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class price_parser : MonoBehaviour
{
    public static string url = "https://rvgaszbut.com.ua/rates/ricnij-bazova-propozicia-7";
    public static string search = "price__new-rate h3";
    public Text text;
    private void Start()
    {
        
        StartCoroutine(Startc());
    }
    IEnumerator Startc()
    {
        using (WWW www = new WWW(url))
        {
            yield return www;
            int p = url.IndexOf(search);
            if (p >= 0)
        {
            int start = p + search.Length;

            int end = url.IndexOf("</span>", start);
            if(end >= 0)
            {
                string v = url.Substring(start, end - start);
                float value = float.Parse(v);
                Debug.Log(value);
            }
        }
            text.text = www.text;
            Debug.Log(text.text);
        }
    }
}
