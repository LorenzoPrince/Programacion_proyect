using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //llamamos libreria para escenas

public class ball : MonoBehaviour
{

    // Start is called before the first frame update
    public Vector2 initialspeed;
    private Rigidbody2D ballrigibody;
    bool IsMoving;
    public Score sumScore; //hago referencia al otro script
    public int Scores;
    void Start()
    {
        ballrigibody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!IsMoving) //signo de interrogracion es = null
        {
            ballrigibody.velocity = initialspeed;
            IsMoving = true;
        }
        
        if (GameObject.FindGameObjectsWithTag("Brick").Length == 0)
        {
            if (SceneManager.GetActiveScene().name == "Level1")
            {
                NextLevel();
            }
            if (SceneManager.GetActiveScene().name == "Level2")
            {
                NextLevel1();
            }
            if (SceneManager.GetActiveScene().name == "Level3")
            {
                Victory();
            }
        }


    }

    private void OnCollisionEnter2D(Collision2D choque)
    {
        if (choque.gameObject.CompareTag("Brick"))
        {
            Destroy(choque.gameObject);
            sumScore.Contador(Scores);
        }
        if (choque.gameObject.CompareTag("Dead"))
        {
            Gameover(); //llamo a la funcion
        }
    }
    void NextLevel1()

    {
        SceneManager.LoadScene("level3");


    }
    void NextLevel()
 
        {
            SceneManager.LoadScene("level2");
            
           
        }

    void Victory()

        
        {
            SceneManager.LoadScene("Victory");

        }

    void Gameover()
    {
        SceneManager.LoadScene("Gameover"); //pasa a la siguiente escena seleccionada
    }
}
