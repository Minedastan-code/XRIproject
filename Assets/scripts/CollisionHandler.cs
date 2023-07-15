
using UnityEngine;
using UnityEngine.SceneManagement;
public class CollisionHandler : MonoBehaviour
{
  
    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Friendly":
                Debug.Log("This is friendly");
            break;
            case "Finish":
                Debug.Log("Congrats you reached the final destination");
                break;
            case "Fuel":
                Debug.Log("You've piked up fuel");
                break;
            default:
                ReloadLevel();
                break;
        }
        void ReloadLevel()
        {
            SceneManager.LoadScene(0);
        }
    }
}
