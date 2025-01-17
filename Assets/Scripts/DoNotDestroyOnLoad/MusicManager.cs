using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private void Awake()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.Play();
        DontDestroyOnLoad(this.gameObject);
    }

    private void Update()
    {
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("GameMusic");
        if (musicObj.Length > 1)
        {
            Destroy(musicObj[1]);
        }
    }
}