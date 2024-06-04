using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.Services.CloudSave;
using Unity.Services.CloudSave.Models;
using UnityEngine;

public static class CloudSave 
{
    public static async Task SaveData()
    {

       
        var playerData = new Dictionary<string, object>

            {
                { "Player", PointManager.points  }
            } ;


        await CloudSaveService.Instance.Data.Player.SaveAsync(playerData);
    }

    public static async Task<Item> LoadData()
    {
        var playerData = await CloudSaveService.Instance.Data.Player.LoadAsync(new HashSet<string> {

            "Player"

        }) ;

        return playerData["Player"];
    }
}
    

