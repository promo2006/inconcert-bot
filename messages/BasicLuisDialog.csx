using System;
using System.Threading.Tasks;

using Microsoft.Bot.Builder.Azure;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;

// For more information about this template visit http://aka.ms/azurebots-csharp-luis
[Serializable]
public class BasicLuisDialog : LuisDialog<object>
{
    public BasicLuisDialog() : base(new LuisService(new LuisModelAttribute(Utils.GetAppSetting("LuisAppId"), Utils.GetAppSetting("LuisAPIKey"))))
    {
    }

    [LuisIntent("None")]
    public async Task NoneIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the none intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }

    // Go to https://luis.ai and create a new intent, then train/publish your luis app.
    // Finally replace "MyIntent" with the name of your newly created intent in the following handler
    [LuisIntent("MyIntent")]
    public async Task MyIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the MyIntent intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }

    [LuisIntent("saludos")]
    public async Task SaludoIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"Hola como estas"); //
        context.Wait(MessageReceived);
    }

    [LuisIntent("saldo")]
    public async Task SaldoIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"Tu quisiste decir: {result}"); //
        context.Wait(MessageReceived);
    }

    [LuisIntent("migracion")]
    public async Task MigracionIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"Tu quisiste decir: {result}"); //
        context.Wait(MessageReceived);
    }
}