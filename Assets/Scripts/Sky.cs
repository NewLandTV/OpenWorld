using UnityEngine;

public class Sky : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed = 0.5f;

    private Material skybox;

    private void Awake()
    {
        skybox = RenderSettings.skybox;
    }

    private void Update()
    {
        skybox.SetFloat("_Rotation", rotationSpeed * Time.time);
    }
}
