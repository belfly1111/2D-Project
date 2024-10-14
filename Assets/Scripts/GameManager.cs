using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; } // ΩÃ±€≈Ê ¿ŒΩ∫≈œΩ∫

    [Header("Player")]
    [SerializeField] private GameObject[] playerPrefabs;

    [Header("UI")]
    [SerializeField] private GameObject titlePanel;
    [SerializeField] private GameObject characterSelectPanel;
    [SerializeField] private TMP_InputField playerInputNameField;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void JoinRoom()
    {
        if (playerInputNameField.text == null) return;
        else
        {
            titlePanel.SetActive(false);
            characterSelectPanel.SetActive(true);
        }
    }

    public void SelectCharacter(int index)
    {
        titlePanel.SetActive(false);
        characterSelectPanel.SetActive(false);

        GameObject player = Instantiate(playerPrefabs[index], new Vector3(0, 0, -5), Quaternion.identity);

        try
        {
            TMP_Text playerName = player.GetComponentInChildren<TMP_Text>();
            playerName.text = playerInputNameField.text;

            TopDownCameraMovement cameraMovement = Camera.main.GetComponent<TopDownCameraMovement>();
            cameraMovement.targetTransform = player.transform.GetChild(0);
        }
        catch
        {
            return;
        }
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit(); // ∫ÙµÂµ» ∞‘¿”ø°º≠ ¡æ∑·
#endif
    }

}
