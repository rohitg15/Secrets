﻿using System;
using Models;
using System.Collections.Generic;


namespace Dal
{
    public interface IStorage
    {
        Secret ReadSecret(string secretId);
        void WriteSecret(Secret secret, bool overwrite=false);
        List<Secret> ListSecrets();
        void DeleteSecret(string secretId);

        string GetProviderName();
    }
}
