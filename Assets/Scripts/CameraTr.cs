using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTr : MonoBehaviour
{
    public Camera cam;

    public void TransformCam()
    {
        if (this.gameObject.name == "Gaz") cam.gameObject.transform.position = new Vector3(10, 0, 10);
        if (this.gameObject.name == "Electricity") cam.gameObject.transform.position = new Vector3(-10, 0, 10);
    }

}
