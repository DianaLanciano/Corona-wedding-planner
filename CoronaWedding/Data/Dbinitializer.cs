using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoronaWedding.Models;
using Microsoft.EntityFrameworkCore;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace CoronaWedding.Data
{
    public static class Dbinitializer
    {

        public static void initialize(WeddingCoronaContext context)
        {
            context.Database.EnsureCreated();
            if (context.Account.Any())
            {
                return;
            }
            var directoryPath = AppContext.BaseDirectory.Substring(0, AppContext.BaseDirectory.IndexOf("bin", StringComparison.Ordinal));


            /**********************************for Catering*****************************/
            string Path = directoryPath + "Data\\dataDocJson\\cateringData.json";
            var myJsonString = File.ReadAllText(Path);
            var caterings = JsonConvert.DeserializeObject<List<Catering>>(myJsonString);
            foreach (Catering l in caterings)
            {
                context.Catering.Add(l);
            }
            context.SaveChanges();

            /**********************************for location*****************************/
            Path = directoryPath + "Data\\dataDocJson\\locationData.json";
            myJsonString = File.ReadAllText(Path);
            var locations = JsonConvert.DeserializeObject<List<Location>>(myJsonString);
            foreach (Location l in locations)
            {
                context.Location.Add(l);
            }
            context.SaveChanges();

            /**********************************for Music*****************************/
            Path = directoryPath + "Data\\dataDocJson\\musicData.json";
            myJsonString = File.ReadAllText(Path);
            var music = JsonConvert.DeserializeObject<List<Music>>(myJsonString);
            foreach(Music l in music)
            {
                context.Music.Add(l);
            }
            context.SaveChanges();
            /**********************************for photo*****************************/
            Path = directoryPath + "Data\\dataDocJson\\photoData.json";
            myJsonString = File.ReadAllText(Path);
            var photos = JsonConvert.DeserializeObject<List<Photographer>>(myJsonString);
            foreach (Photographer l in photos)
            {
                context.Photographer.Add(l);
            }
            context.SaveChanges();


            /**********************************for Account*****************************/
             Path = directoryPath + "Data\\dataDocJson\\accountsData.json";
             myJsonString = File.ReadAllText(Path);
            var accounts = JsonConvert.DeserializeObject<List<Account>>(myJsonString);
            foreach (Account l in accounts)
            {
                context.Account.Add(l);
            }
            context.SaveChanges();


        }
    }
}
