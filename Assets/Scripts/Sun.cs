using UnityEngine;

public class Sun : MonoBehaviour
{
    [SerializeField]
    private Material dayMaterial;
    [SerializeField]
    private Material nightMaterial;

    private bool day = true;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F5))
        {
            RenderSettings.skybox = (day = !day) ? dayMaterial : nightMaterial;
        }
    }
}
