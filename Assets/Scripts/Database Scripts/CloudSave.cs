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

    public static async Task SaveLoops()
    {


        var playerData = new Dictionary<string, object>

            {
                { "Loops", PointManager.LoopPoints3 }
            };


        await CloudSaveService.Instance.Data.Player.SaveAsync(playerData);
    }

    public static async Task SaveTime()
    {


        var playerData = new Dictionary<string, object>

            {
                { "Time", TimeManager.Instance.GetTme() }
            };


        await CloudSaveService.Instance.Data.Player.SaveAsync(playerData);
    }

    public static async Task<Item> LoadData()
    {
        var playerData = await CloudSaveService.Instance.Data.Player.LoadAsync(new HashSet<string> {

            "Player"

        }) ;

        return playerData["Player"];
    }

    public static async Task<Item> LoadLoops()
    {
        var playerData = await CloudSaveService.Instance.Data.Player.LoadAsync(new HashSet<string> {

            "Loops"

        });

        return playerData["Loops"];
    }

    public static async Task<Item> LoadTime()
    {
        var playerData = await CloudSaveService.Instance.Data.Player.LoadAsync(new HashSet<string> {

            "Time"

        });

        return playerData["Time"];
    }
}
    

