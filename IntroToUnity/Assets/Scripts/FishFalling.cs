using UnityEngine;

public class FishFalling : MonoBehaviour
{
    public GameObject Fish;
    private float spawnLimitXLeft = 0;
    private float spawnLimitXRight = 13;
    private float spawnPosY = 13;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("FishFall", 2, 1);
    }

    // Update is called once per frame
    void Update()
    {
      if (transform.position.y < -3){
        Destroy(gameObject);
        }
    }
    void FishFall() {
         Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        // instantiate ball at random spawn location
        Instantiate(Fish, spawnPos, Fish.transform.rotation);
        //https://discussions.unity.com/t/invokerepeating-for-random-ball-spawn/229007
}

}
    