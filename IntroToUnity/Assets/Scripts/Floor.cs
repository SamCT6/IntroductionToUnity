using Unity.VisualScripting;
using UnityEngine;

public class Floor : MonoBehaviour
{
    public bool destroyed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        Debug.Log("OnCollisionEnter2D");
        GameManager.Instance.DecScore(1);

    }

}
