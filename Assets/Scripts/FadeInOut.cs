using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FadeInOut : MonoBehaviour
{
    private float speed = 2f;
    private Image image;

    private void Start()
    {
        image = transform.GetComponent<Image>();
        StartCoroutine(BeBright());
    }

    public void PassLevel()
    {
        StartCoroutine(BeDark());
    }

    IEnumerator BeDark()
    {
        while (1 - image.color.a > 0.05f)
        {
            image.color = Color.Lerp(image.color, new Color(0, 0, 0, 1), speed * Time.deltaTime);
            yield return null;
        }
        SceneManager.LoadScene("Game");
    }

    IEnumerator BeBright()
    {
        while (image.color.a > 0.05f)
        {
            image.color = Color.Lerp(image.color, new Color(0, 0, 0, 0), speed * Time.deltaTime);
            yield return null;
        }
    }
}