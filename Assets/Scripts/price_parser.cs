using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class price_parser : MonoBehaviour
{
    public string url = "https://bankchart.com.ua/spravochniki/indikatory_rynka/tarify_na_gas/39";
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
            text.text = www.text;
            Debug.Log(text.text);
        }
    }
}
