using UnityEngine;

public class WordCollision : MonoBehaviour
{
    //public GameManager gameManager;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "OutOfBounds")
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
