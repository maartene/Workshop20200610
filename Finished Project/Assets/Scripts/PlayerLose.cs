using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLose : MonoBehaviour
{
    public float minY = -5f;
    public AudioClip loseFX;

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= minY) {
            Debug.Log("You lose!");

            audioSource.PlayOneShot(loseFX);
            Invoke("ReloadScene", loseFX.length);
        }
    }

    void ReloadScene() {
        SceneManager.LoadScene(0);
    }
}
