using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTr : MonoBehaviour
{
    public Camera cam;

    public void ToGaz()
    {
        cam.transform.position = Vector3.Lerp(cam.transform.localPosition, new Vector3(10, 0, -10), 1);
    }

    public void ToElectr()
    {
        cam.transform.position = Vector3.Lerp(cam.transform.localPosition, new Vector3(-10, 0, -10), 1);
    }

    public void ToMain()
    {
        cam.transform.position = Vector3.Lerp(cam.transform.localPosition, new Vector3(0, 0, -10), 1);
    }

}
