using UnityEngine;

public class ConveyorSpawner : MonoBehaviour
{
    public GameObject Conveyor;
    public float spawnRate = 10;
    private float timer = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        } else
        {
            spawnPipe();
            timer = 0;
        }
    }
   void spawnPipe()
    {
        Instantiate(Conveyor, transform.position, transform.rotation);
    }
}
