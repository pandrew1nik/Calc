using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainCalc : MonoBehaviour
{
    [SerializeField] private Text OLD;
    [SerializeField] private Text NEW;
    [SerializeField] private Text RESULT;
    [SerializeField] private string old_p;
    [SerializeField] private string new_p;
    [SerializeField] private float gaz_price = 7.9900f;
    [SerializeField] private float gaz_price_dost;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Gaz()
    {
        old_p = OLD.text.ToString();
        new_p = NEW.text.ToString();
        var old = float.Parse(old_p);
        var neww = float.Parse(new_p);
        var gaz  = (neww - old) * gaz_price;
        Debug.Log(" ", gaz, ", ", old, ", ", neww);
    }
}
