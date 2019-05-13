
using UnityEngine;

public class CastleGuard1 : MonoBehaviour 
{
    public float speed = 1.5f;

    private Transform target;
    private int wavePointIndex = 0;
    public int rotateCounter = 0;
    public GameObject patlama; // its for level3 made by Berk

    private void Start()
    {
        target = WavePoint.points[0];
    }
    
    void  FixedUpdate()
    {
    
        Vector3 direction = target.position - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.1f) // Distance Check
        {
            
            GetNextWavePoint();

            rotateCounter++;

            if(rotateCounter <= 2 )
            {
                transform.Rotate(0, -90, 0, Space.Self);
            }
            else if(rotateCounter >2  && rotateCounter <=4)
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

    void GetNextWavePoint ()
    {
        if(wavePointIndex >= WavePoint.points.Length - 1)
        {
            EndPath();
            return;
        }
        wavePointIndex++;
        target = WavePoint.points[wavePointIndex];
    }

    void EndPath() // Decreasing the health of our castle by Kuntay Akkoyun.
    {
        PlayerStats.Lives--;
        Destroy(gameObject);
    }

     // when the bullet hit to target its destroyed.
     private void OnTriggerEnter(Collider col) //Created By BERK for bullet
     {
        if(col.tag=="bullet"){
            Destroy(col.gameObject);
            Destroy(gameObject);
            Instantiate(patlama, transform.position, transform.rotation);
            
        }

     }
}
