
using System.Collections.Generic;
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

[UdonBehaviourSyncMode(BehaviourSyncMode.Manual)]
public class CameraController : UdonSharpBehaviour
{
    [SerializeField] private Camera mainCamera;
    [SerializeField] private GameObject[] managedObjects;
    [SerializeField] private UdonBehaviour testUdonObject;

    private void Start()
    {
        mainCamera.enabled = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log("main Camera Toggled!");
            bool isCamActive = mainCamera.enabled;
            mainCamera.enabled = !isCamActive;
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
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

        }
    }
    public override void Interact()
    {
        Debug.Log("Switch Camera");


        testUdonObject.SendCustomEvent("TestFunction");
    }
}
