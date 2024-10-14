using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCameraMovement : MonoBehaviour
{
    public Transform targetTransform;
    private Camera camera;

    private void Awake()
    {
        camera = Camera.main;
    }

    private void LateUpdate()
    {
        if(targetTransform != null) camera.transform.position = targetTransform.position;
    }
}
