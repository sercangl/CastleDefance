
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Target : MonoBehaviour {


    public float health = 50f;
    //public int score;
    //public Text scoreText;  
    public ScoreController sc;
    public void Start()
    {
        sc = GameObject.Find("GM").GetComponent<ScoreController>();
    }
    public void TakeDamage(float amount)
    {

        health -= amount;

        if(health <= 0f)
        {
            Die();
        }



    }


    void Die()

    {
        //        score += 10;
        //      scoreText.text = score.ToString();7

        Destroy(gameObject);
        sc.increaseScore();

        if(tag == "Castle")
        {
            SceneManager.LoadScene(6);
        }

    }

}
