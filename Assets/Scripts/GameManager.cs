using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Camera mainCamera;

    [SerializeField]
    private GameObject player;
    [SerializeField]
    private GameObject titleUI;

    private void Awake()
    {
        mainCamera = Camera.main;
    }

    private IEnumerator Start()
    {
        while (!Input.anyKeyDown)
        {
            yield return null;
        }

        mainCamera.gameObject.SetActive(false);
        titleUI.SetActive(false);
        player.SetActive(true);
    }
}
