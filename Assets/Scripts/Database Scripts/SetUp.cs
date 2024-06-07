using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.Services.Authentication;
using Unity.Services.CloudSave.Models;
using Unity.Services.Core;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SetUp : MonoBehaviour
{
    // Start is called before the first frame update

    private async void Start()
    {
        await UnityServices.InitializeAsync();
       
            if (!AuthenticationService.Instance.IsSignedIn)
            {
            try
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                
            }

            catch
            {

                Debug.Log("new user not loaded");
            }// HighScoreScript.startdata();
            }
        }
       
       
}

