using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerManaer : MonoBehaviour
{
    public static bool isGameOver;
    public GameObject GameOverScreen;

    private void Awake()
    {
        isGameOver = false ;
    }
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            GameOverScreen.SetActive(true);
        }   
    }

    public void ReplayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
