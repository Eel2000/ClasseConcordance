using ClasseConcordance.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ClasseConcordance
{
    public static class Constants
    {
        public const string URL_SEND_TO_ONE = "https://napoche-apis.eteyelo.com/Sms/send-Id-sms/";

        public static DbContextOptionsBuilder<Eteyelo_system_ecmContext> stdConfigBuild = null;
        public static DbContextOptionsBuilder<Klasroom_TestContext> klasConfingBuilder = null;
    }
}