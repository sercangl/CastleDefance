using UnityEngine;

public class GuardScript : MonoBehaviour
{
    public float speed = 5f;

    private Transform[] targets;
    private int wavePointIndex = 0;
    public int rotateCounter = 0;
    

    private void Start()
    {
        targets = GameObject.Find("WavePoints").GetComponent<Points>().points;
    }

    void FixedUpdate()
    {
        Vector3 direction = targets[wavePointIndex].position - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, targets[wavePointIndex].position) <= 0.1f) // Distance Check
        {

            GetNextWavePoint();

            rotateCounter++;

            if (rotateCounter <= 2)
            {
                transform.Rotate(0, -90, 0, Space.Self);
            }
            else if (rotateCounter > 2 && rotateCounter <= 4)
            {
                transform.Rotate(0, 90, 0, Space.Self);
            }
            else
            {
                transform.Rotate(0, -90, 0, Space.Self);
                rotateCounter = 1;

            }
        }
    }

    void GetNextWavePoint()
    {
        if (wavePointIndex >= targets.Length - 1)
        {
          //  Destroy(gameObject);
            return;
        }
        wavePointIndex++;
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.GetComponent<PlayerScript>().hp--;

        }
    }
}
