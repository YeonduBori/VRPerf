
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class FollowLocalplayer : UdonSharpBehaviour
{
    private VRCPlayerApi playerLocal;
    private void Start()
    {
        playerLocal = Networking.LocalPlayer;
    }
    public override void PostLateUpdate()
    {
        VRCPlayerApi.TrackingData headData = playerLocal.GetTrackingData(VRCPlayerApi.TrackingDataType.Head);
        transform.SetPositionAndRotation(headData.position, headData.rotation);
    }


    ///<Summary>
    ///This is Wrapping Function
    ///public, void, no parameter
    public void TestFunction()
    {
        Debug.Log("Get Custom Event Listener");
    }
}
