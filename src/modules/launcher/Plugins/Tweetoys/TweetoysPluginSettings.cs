﻿// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;

namespace Tweetoys
{
    public class TweetoysPluginSettings
    {
        public ExecutionShell Shell { get; set; } = ExecutionShell.RunCommand;

        // not overriding Win+R
        // crutkas we need to earn the right for Win+R override
        public bool ReplaceWinR { get; set; }

        public bool LeaveShellOpen { get; set; }

        public bool RunAsAdministrator { get; set; }

        public string CONSUMERKEY { get; set; }

        public string CONSUMERSECRET { get; set; }

        public string ACCESSTOKEN { get; set; }

        public string ACCESSTOKENSECRET { get; set; }

        public Dictionary<string, int> Count { get; } = new Dictionary<string, int>();

        public void AddCmdHistory(string cmdName)
        {
            if (Count.ContainsKey(cmdName))
            {
                Count[cmdName] += 1;
            }
            else
            {
                Count.Add(cmdName, 1);
            }
        }
    }

    public enum ExecutionShell
    {
        Cmd = 0,
        Powershell = 1,
        RunCommand = 2,
    }
}
