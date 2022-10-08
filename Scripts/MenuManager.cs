using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public void Exit() {
        Application.Quit();
    }

    public void OpenOwner() {
        Application.OpenURL("https://vk.com/fiftygames");
    }

    public void OpenOwnerTelegram() {
        Application.OpenURL("https://t.me/fifty_games");
    }

    public void OpenGitHub() {
        Application.OpenURL("https://github.com/Payz123/fiftytools");
    }
}
