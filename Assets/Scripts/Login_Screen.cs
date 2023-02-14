using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login_Screen : MonoBehaviour
{
    [SerializeField] private Button loginButton;
    [SerializeField] private Text loginText;
    [SerializeField] private Text loginPassword;

    private void Awake()
    {
        loginButton.onClick.AddListener(Log);
    }

    private void Log()
    {
        Network_Manager._NETWORK_MANAGER.ConnectToServer(loginText.text.ToString(),loginPassword.text.ToString());
    }

}
