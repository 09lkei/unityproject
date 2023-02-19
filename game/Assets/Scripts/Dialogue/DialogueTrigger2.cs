using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogueTrigger2 : MonoBehaviour
{
    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;

    [Header("Scene Index")]
    [SerializeField] private int nextSceneIndex;

    private bool playerInRange;
    private bool dialogueTriggered;

    private void Awake()
    {
        playerInRange = false;
        dialogueTriggered = false;
        visualCue.SetActive(false);
    }

    private void Update()
    {
        if (playerInRange && !DialogueManager.GetInstance().dialogueIsPlaying && !dialogueTriggered)
        {
            visualCue.SetActive(true);
            if (InputManager.GetInstance().GetInteractPressed())
            {
                DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
                dialogueTriggered = true;
            }
        }
        else
        {
            visualCue.SetActive(false);
        }

        if (!DialogueManager.GetInstance().dialogueIsPlaying && dialogueTriggered)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = false;
        }
    }
}
