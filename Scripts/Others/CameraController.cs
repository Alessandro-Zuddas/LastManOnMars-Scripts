using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour
{
    public Transform target;

    private float startFOV, targetFOV;

    public float zoomSpeed = 1f;

    public Camera mainCamera;

    public static CameraController cameraScript;

    private void Awake()
    {
        cameraScript = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        startFOV = mainCamera.fieldOfView;
        targetFOV = startFOV;

        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = target.position;
        transform.rotation = target.rotation;

        mainCamera.fieldOfView = Mathf.Lerp(mainCamera.fieldOfView, targetFOV, zoomSpeed * Time.deltaTime);
    }

    public void ZoomIn(float newZoom)
    {
        targetFOV = newZoom;

        
    }

    public void ZoomOut()
    {
        targetFOV = startFOV;

       
    }
    
}
