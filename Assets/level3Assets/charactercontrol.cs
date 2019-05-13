using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charactercontrol : MonoBehaviour {

    float horizontal;
    float vertical;
    Vector3 vec;
    GameObject head;
    int speed = 5;
    float headrot;
    public GameObject target;
    RaycastHit hit;
    public GameObject bullet;
    //float minX=1.28f, maxX=8.9f; 
    //float minZ=4.85f, maxZ=8.9f;
    float shottimer = 0;
    float shotperiod = 0.3f;

    AudioSource au;





	void Start () {

        vec = new Vector3(); // so i dont need to assign vector3 again
        head = transform.Find("kafa").gameObject;

        au = GetComponent<AudioSource>();
		
	}
	
	
	void Update () {

        characterControl();
        drRay();

        if(Input.GetMouseButton(0) && Time.time>shottimer){
            shottimer = Time.time + shotperiod; //its kind of timer. we have to wait 0.3 to shot.
            Instantiate(bullet,target.transform.position,Quaternion.identity); // instantiate bullet
            au.Play();
        }

		
	}

    void drRay(){
    
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0)); // drawing ray on middle of camera


        if(Physics.Raycast(ray,out hit)){
            Debug.Log("temas var" + hit.transform.name); // its for check
        }
        else{
            Debug.Log("temas yook"); // its for check
        }


        Debug.DrawRay(ray.origin, ray.GetPoint(1000)); // i draw 1000 ray from origin to distance
        Debug.DrawLine(target.transform.position, hit.point); //its line that is between target and hit
        Debug.Log(hit.point);

    }


    void characterControl(){

        //character position
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        vec.Set(horizontal, 0, vertical);
        transform.Translate(vec * Time.deltaTime * -speed);
        //transform.position = new Vector3(Mathf.Clamp(transform.position.x, minX, maxX), 0.0f, Mathf.Clamp(transform.position.z, minZ, maxZ));

        //character rotate
        transform.Rotate(0, Input.GetAxis("Mouse X")*Time.deltaTime*150, 0); //150 speed
        headrot += Input.GetAxis("Mouse Y")*Time.deltaTime*150;
        headrot = Mathf.Clamp(headrot, -70, 70); // limited for rotate of head

        head.transform.eulerAngles = new Vector3(headrot, transform.eulerAngles.y, 0); // we have to vector3 for eulerangles because its variable


    }

    public Vector3 getposition(){

        return (hit.point - target.transform.position).normalized; // nesne ile target pozisyonu arasindaki mesafe
    }


}
