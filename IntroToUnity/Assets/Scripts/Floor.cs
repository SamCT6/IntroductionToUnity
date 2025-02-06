using Unity.VisualScripting;
using UnityEngine;

public class Floor : MonoBehaviour
{
    public bool destroyed;

    private AudioSource audioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        destroyed = false;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!destroyed){
            Destroy(collision.gameObject);
            destroyed = true;
        }
        audioSource.Play();
        Debug.Log("OnCollisionEnter2D");
        GameManager.Instance.DecScore(1);

    }

}
