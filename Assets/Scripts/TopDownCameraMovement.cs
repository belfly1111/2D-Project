using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCameraMovement : MonoBehaviour
{
    [SerializeField] Transform TargetTransform;
    private Camera camera;

    private void Awake()
    {
        camera = Camera.main;
    }

    private void LateUpdate()
    {
        camera.transform.position = TargetTransform.position;
    }
}
