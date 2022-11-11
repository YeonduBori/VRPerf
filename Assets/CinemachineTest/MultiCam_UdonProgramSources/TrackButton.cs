
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using Cinemachine;

public class TrackButton : UdonSharpBehaviour
{
    public GameObject[] trackers = new GameObject[16];
    public VRCPlayerApi[] playerApis = new VRCPlayerApi[16];
    public CinemachineVirtualCamera[] virtualCameras;
    public bool isTrack = false;

    void Start()
    {

    }

    public override void Interact()
    {
        //Track
        var players = VRCPlayerApi.GetPlayers(playerApis);

        for (int index = 0; index < VRCPlayerApi.GetPlayerCount(); ++index)
        {
            var player = players[index];
            if (player != null)
            {
                Debug.Log($"player Id : {player.playerId}, displayName : {player.displayName}");
            }
        }

        isTrack = true;
    }

    public override void PostLateUpdate()
    {
        base.PostLateUpdate();

        Track();
    }

    public void Track()
    {
        if (!isTrack) return;

        for (int index = 0; index < VRCPlayerApi.GetPlayerCount(); ++index)
        {
            var player = playerApis[index];
            if (player != null)
            {
                Debug.Log($"player Id : {player.playerId}, displayName : {player.displayName}");
                trackers[index].transform.position = player.GetBonePosition(HumanBodyBones.Head);
                trackers[index].transform.rotation = player.GetBoneRotation(HumanBodyBones.Head);
            }
        }
    }

    public void PlayerFace()
    {
        SelectVcam(0);
    }

    public void PlayerFaceDolly()
    {
        SelectVcam(2);
    }

    public void MentorFace()
    {
        SelectVcam(1);
    }

    public void PlayerImpulse()
    {
        SelectVcam(3);
    }

    public void SelectVcam(int inputIndex)
    {
        for (int index = 0; index < virtualCameras.Length; ++index)
        {
            if (index == inputIndex)
            {
                virtualCameras[index].Priority = 20;
            }
            else
            {
                virtualCameras[index].Priority = 10;
            }
        }
    }
}
