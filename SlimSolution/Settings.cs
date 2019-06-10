﻿using SlimSolution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlimSolution
{
    /// <summary>
    /// This class can help you to store settings for your plugin
    /// </summary>
    /// <remarks>
    /// This class must be XML serializable
    /// </remarks>
    public class Settings
    {
        public Settings()
        {
        }
        public string LastUsedOrganizationWebappUrl { get; set; }

        public SerializableKeyValuePair<string, bool>[] _validationSettingsKVPs = new SerializableKeyValuePair<string, bool>[3] 
        {
            new SerializableKeyValuePair<string, bool>("CheckComponents", true),
            new SerializableKeyValuePair<string, bool>("CheckProcesses", true),
            new SerializableKeyValuePair<string, bool>("ALWAYSPUBLISH", true)
        };
        public SerializableKeyValuePair<string, bool>[] ValidationSettings { get => _validationSettingsKVPs; set => _validationSettingsKVPs = value; }
    }

    [Serializable]
    public class SerializableKeyValuePair<TKey, TValue>
    {

        public SerializableKeyValuePair()
        {
        }

        public SerializableKeyValuePair(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }

        public TKey Key { get; set; }
        public TValue Value { get; set; }

    }
}