using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainCalc : MonoBehaviour
{
    [SerializeField] public Text OLD;
    [SerializeField] public Text NEW;
    [SerializeField] public Text RESULT;
    [SerializeField] public string old_p;
    [SerializeField] public string new_p;
    private float gaz_price = 7.9900f;
    private float gaz_price_dost = 1.85f;
    private float electricity_price = 1f;
    private float water_price = 1f;

    public void Gaz()
    {
        old_p = OLD.text.ToString();
        new_p = NEW.text.ToString();
        float old = float.Parse(old_p);
        float neww = float.Parse(new_p);
        float gaz  = (neww - old) * gaz_price;
        float gaz_dost = (neww - old) * gaz_price_dost;

        RESULT.text = "До сплати за газ: " + gaz + "\n За доставку: " + gaz_dost;
    }
    

    public void Electricity()
    {
        old_p = OLD.text.ToString();
        new_p = NEW.text.ToString();
        float old = float.Parse(old_p);
        float neww = float.Parse(new_p);
        float electricity  = (neww - old) * electricity_price;

        RESULT.text = "До сплати за електроенергію: " + electricity;
    }

    public void Water()
    {
        old_p = OLD.text.ToString();
        new_p = NEW.text.ToString();
        float old = float.Parse(old_p);
        float neww = float.Parse(new_p);
        float water  = (neww - old) * water_price;

        RESULT.text = "До сплати за водопостачання: " + water;
    }

    public void Other()
    {

    }
}
