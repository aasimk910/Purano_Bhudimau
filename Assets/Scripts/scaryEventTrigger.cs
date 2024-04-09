using UnityEngine;

public class scaryEventTrigger : MonoBehaviour
{
    public GameObject scare;
    public GameObject scare2;
    public AudioSource scareSound;
    public Collider collision;


    void Start()
    {
        scare.SetActive(false); // Deactivate scare object at start
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            scare.SetActive(true);
            scareSound.Play();
            collision.enabled = false; // Optional: Disable collider after trigger
            
        }
    }
}
