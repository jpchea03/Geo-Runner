// This script controls the spawning of spikes and spike generator

using UnityEngine;

public class SpikeGenerator : MonoBehaviour
{

    public GameObject spike; // Game object we are spawning

    public float minSpeed; // Minimum spike speed
    public float maxSpeed; // Maximum spike speed
    public float curSpeed; // Current speed of spikes
    public float speedMultiplier; // Rate that speed increases
    
    // Set current speed to min speed and spawn a spike
    void Awake()
    {
        curSpeed = minSpeed;
        GenerateSpike();
    }

    // Method to generate spikes at random intervals
    public void GenerateSpikeRandom()
    {
        float randomWait = Random.Range(0.1f, 1.0f);
        Invoke("GenerateSpike", randomWait);

    }

    // Method to spawn spike
    void GenerateSpike()
    {
        GameObject SpikeIns = Instantiate(spike, transform.position, transform.rotation);
        SpikeIns.GetComponent<SpikeScript>().spikeGenerator = this;

    }

    // Update is called once per frame
    void Update()
    {
        // If current speed has not exceeded maximum...
        if (curSpeed < maxSpeed)
        {
            curSpeed += speedMultiplier; // Increase speed by speed multiplier
        }
    }
}
