
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using Cinemachine;

public class ActiveObject : UdonSharpBehaviour
{
    public GameObject DollyCamObject;
    //public Transform playerTracker;
    //private CinemachineVirtualCamera dollyCam;

    public override void Interact()
    {
        DollyCamObject.SetActive(true);
    }
}
