// This script controls the behavior of the spikes

using UnityEngine;

public class SpikeScript : MonoBehaviour
{
    public SpikeGenerator spikeGenerator; // Custom spike generator object

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * spikeGenerator.curSpeed * Time.deltaTime); // Move spike left at current speed every frame
    }

    // Method that controls the spike spawn behavior
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // If spike hits the next line...
        if (collision.gameObject.CompareTag("nextLine"))
        {
            spikeGenerator.GenerateSpikeRandom(); // Spawn spike
        }

        // If spike hits finish line
        if (collision.gameObject.CompareTag("Finish"))
        {
            Destroy(this.gameObject); // Destroy spike
        }
    }
}
