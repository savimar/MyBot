﻿using Newtonsoft.Json;

namespace MyBot.Keyboads
{
    public class KeyboardButton
    {
        [JsonProperty("text")] public string Text { get; set; }

        public KeyboardButton(string text)
        {
            Text = text;
        }
    }
}