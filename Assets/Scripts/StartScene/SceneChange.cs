using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void EnterGameLevelOne()
    {
#if !RELEASE
        Debug.Log("Enter Game Level One.");
#endif
        SceneManager.LoadScene("Game");
    }
}
