using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoomIn : MonoBehaviour
{
    public Collider bola;
    public CameraController cameraController;
    public float Length;

    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            cameraController.FollowTarget(bola.transform, Length);
        }
    }        
}
