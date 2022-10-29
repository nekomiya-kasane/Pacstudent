using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject PauseMenu;

    private bool isTriggered = false;

    // Start is called before the first frame update
    //void Start()
    //{
    //
    //}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape) && SceneManager.GetActiveScene().name == "Game")
        {
#if !RELEASE
            Debug.Log("Trigger " + (isTriggered ? "true" : "false"));
#endif
            PauseMenu.SetActive(isTriggered = !isTriggered);

            Time.timeScale = isTriggered ? 1.0f : 0.0f;
        }
    }
}
