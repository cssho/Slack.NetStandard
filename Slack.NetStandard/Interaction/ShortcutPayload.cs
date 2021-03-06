﻿using Newtonsoft.Json;

namespace Slack.NetStandard.Interaction
{
    public abstract class ShortcutPayload:InteractionPayload
    {
        [JsonProperty("callback_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CallbackId { get; set; }
    }
}