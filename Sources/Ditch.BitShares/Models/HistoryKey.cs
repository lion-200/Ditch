using Newtonsoft.Json;

namespace Ditch.BitShares.Models
{
    /// <summary>
    /// history_key
    /// libraries\plugins\market_history\include\graphene\market_history\market_history_plugin.hpp
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class HistoryKey
    {

        /// <summary>
        /// API name: base
        /// 
        /// </summary>
        /// <returns>API type: asset_id_type</returns>
        [JsonProperty("base")]
        public AssetIdType Base { get; set; }

        /// <summary>
        /// API name: quote
        /// 
        /// </summary>
        /// <returns>API type: asset_id_type</returns>
        [JsonProperty("quote")]
        public AssetIdType Quote { get; set; }

        /// <summary>
        /// API name: sequence
        /// = 0;
        /// </summary>
        /// <returns>API type: int64_t</returns>
        [JsonProperty("sequence")]
        public long Sequence { get; set; }
    }
}
