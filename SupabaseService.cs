using Supabase;

namespace BibliotecaApp
{
    public static class SupabaseService
    {
        
        private const string Url = "https://ltlormgygvjknnvmktje.supabase.co";
        private const string AnonKey = "sb_publishable_nD7Rlg218HEkMCOEUWCw1A_gSbywyqf";

        public static Client Client { get; private set; }

        public static async Task InitializeAsync()
        {
            var options = new SupabaseOptions
            {
                AutoConnectRealtime = false
            };

            Client = new Client(Url, AnonKey, options);
            await Client.InitializeAsync();
        }
    }
}
