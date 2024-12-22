using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemanagerscript : MonoBehaviour
{
    public void SwitchScene(int num)
    {
        SceneManager.LoadScene(num);
    }
}