using Newtonsoft.Json;
using Ditch.EOS;
using Ditch.Core.Models;
using Ditch.EOS.Models;

namespace Ditch.EOS.Contracts.Eosio.Structs
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Setram
    {
        [JsonProperty("max_ram_size")]
        public ulong MaxRamSize {get; set;}

    }
}
