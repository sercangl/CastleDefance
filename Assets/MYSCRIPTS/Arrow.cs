using UnityEngine;

public class Arrow : MonoBehaviour {
    
    private Transform target;
    public float speed = 12f;
    public int Value = 20;
    public GameObject ImpactEffect;
    public void Seek(Transform _target)
    {
        target = _target;
    }
   


    void Update()
    {
        
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }
        Vector3 direction = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;
        Quaternion rotation = Quaternion.LookRotation(transform.position,Vector3.up);
          transform.rotation = rotation;
        


        if (direction.magnitude <= distanceThisFrame)
        {
            HitTarget();
            return;
        }
        transform.Translate(direction.normalized * distanceThisFrame, Space.World);
    }
    void HitTarget()
    {
        Debug.Log("We hit Something!");
        GameObject EffectInstance = (GameObject)Instantiate(ImpactEffect, transform.position, transform.rotation);
        Destroy(EffectInstance, 2f);
        Destroy(gameObject);
        Destroy(target.gameObject);
        PlayerStats.Money += Value;


    }
}
