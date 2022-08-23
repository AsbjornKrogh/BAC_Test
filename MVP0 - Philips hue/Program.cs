// See https://aka.ms/new-console-template for more information
using Q42.HueApi.Interfaces;
using Q42.HueApi.Models;
using Q42.HueApi;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;


//Small change

//string clientId = "kxPSbKeg2EHRJ37UImXnHqSjjhmUip8z";
//string clientSecret = "AmfvvEOqa36AuXBB";
//string appId = "thelightproject";
//var callbackUri = new Uri("https://oauth.pstmn.io/v1/browser-callback");

//IRemoteAuthenticationClient authClient = new RemoteAuthenticationClient(clientId, clientSecret, appId);


//var accessToken = await authClient.GetToken("zbUfAO6D");
//IRemoteHueClient client = new RemoteHueClient(authClient.GetValidToken);
//var bridges = await client.GetBridgesAsync();


//var localHueApi = new LocalHueApi("192.168.87.158:443", "AiXIqDaYqvvLbjTGGDgYx-G7HbhPiOep4yyhlY8E");



//var lights = await localHueApi.GetLightsAsync();
//var id = lights.Data.Last().Id; //Pick a light

//var req = new UpdateLight()
//   .TurnOn();
//var result = await localHueApi.UpdateLightAsync(id, req);


//Console.WriteLine("Hello, World!");
////await ProcessRepositories();


//ILocalHueClient client = new LocalHueClient("192.168.87.158:443");
//client.UseHttps = true;

//client.Initialize("AiXIqDaYqvvLbjTGGDgYx-G7HbhPiOep4yyhlY8E");


//var command = new LightCommand();
////Blink once
//command.Alert = Alert.Once;
//client.SendCommandAsync(command);


////ILocalHueClient client = new LocalHueClient("192.168.87.158:443");
//Make sure the user has pressed the button on the bridge before calling RegisterAsync
//It will throw an LinkButtonNotPressedException if the user did not press the button

//for (int i = 16; i > 0; i--)
//{
//   Console.WriteLine(i);
//   Thread.Sleep(1000);
//}
//var appKey = await client.RegisterAsync("TheLightProject", "AskLenovoVS");
//Save the app key for later use


//IBridgeLocator locator = new HttpBridgeLocator(); //Or: LocalNetworkScanBridgeLocator, MdnsBridgeLocator, MUdpBasedBridgeLocator
//var bridges = await locator.LocateBridgesAsync(TimeSpan.FromSeconds(5));

////Advanced Bridge Discovery options:
//bridges = await HueBridgeDiscovery.CompleteDiscoveryAsync(TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(30));
//bridges = await HueBridgeDiscovery.FastDiscoveryWithNetworkScanFallbackAsync(TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(30));
//bridges = await HueBridgeDiscovery.CompleteDiscoveryAsync(TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(30));


HttpWebRequest myReq =
   (HttpWebRequest)WebRequest.Create("https://discovery.meethue.com/");

WebResponse respons = myReq.GetResponse();

Console.WriteLine(respons);


//ILocalHueClient client = new LocalHueClient("192.168.87.158:443");
////Make sure the user has pressed the button on the bridge before calling RegisterAsync
////It will throw an LinkButtonNotPressedException if the user did not press the button


//var appKey = await client.RegisterAsync("mypersonalappname", "mydevicename");
////Save the app key for later use

static async Task ProcessRepositories()
{
   HttpClient client = new HttpClient();
   //client.DefaultRequestHeaders.Accept.Clear();
   //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
   //client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

   var stringTask = client.GetStringAsync("https://discovery.meethue.com/");

   var msg = await stringTask;
   Console.Write(msg);
}