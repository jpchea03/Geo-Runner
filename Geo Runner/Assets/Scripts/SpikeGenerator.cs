using UnityEngine;

public class SpikeGenerator : MonoBehaviour
{

    public GameObject spike;

    public float minSpeed;
    public float maxSpeed;
    public float curSpeed;
    public float speedMultiplier;
    
    void Awake()
    {
        curSpeed = minSpeed;
        GenerateSpike();
    }

    public void GenerateSpike()
    {
        GameObject SpikeIns = Instantiate(spike, transform.position, transform.rotation);
        SpikeIns.GetComponent<SpikeScript>().spikeGenerator = this;

    }

    // Update is called once per frame
    void Update()
    {
        if (curSpeed < maxSpeed)
        {
            curSpeed += speedMultiplier;
        }
    }
}
