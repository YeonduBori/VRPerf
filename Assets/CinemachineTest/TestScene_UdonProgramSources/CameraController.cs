
using System.Collections.Generic;
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class CameraController : UdonSharpBehaviour
{
    public GameObject mainCamera;
    public GameObject[] managedObjects;
    public UdonBehaviour testUdonObject;



    public override void Interact()
    {
        Debug.Log("Switch Camera");

        if (!mainCamera.activeSelf)
        {
            mainCamera.SetActive(true);
        }

        if (managedObjects.Length >= 2)
        {
            if (managedObjects[0].activeSelf)
            {
                managedObjects[0].SetActive(false);
                managedObjects[1].SetActive(true);
            }
            else
            {
                managedObjects[0].SetActive(true);
                managedObjects[1].SetActive(false);
            }
        }

        testUdonObject.SendCustomEvent("TestFunction");
    }
}
