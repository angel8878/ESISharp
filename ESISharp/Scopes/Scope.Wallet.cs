﻿namespace ESISharp.Scopes
{
    public partial class Scope
    {
        public static class Wallet
        {
            public static readonly Scope ReadCharacterWallet = new Scope("esi-wallet.read_character_wallet.v1");

            public static readonly Scope ReadCorporationWallet = new Scope("esi-wallet.read_corporation_wallet.v1");

            public static readonly Scope ReadCorporationWallets = new Scope("esi-wallet.read_corporation_wallets.v1");
        }
    }
}
