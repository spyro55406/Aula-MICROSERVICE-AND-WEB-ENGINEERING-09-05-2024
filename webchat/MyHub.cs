using Microsoft.AspNetCore.SignalR;

namespace webchat
{
    public class MyHub : Hub
    {
        public async Task EnviarMensagem(string mensagem)
        {
            await Clients.All.SendAsync("ReceberMensagem", mensagem);
        }
    }
}
