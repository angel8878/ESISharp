﻿using ESISharp.Web;

namespace ESISharp.ESIPath.Character
{
    /// <summary>Authenticated Character Asset paths</summary>
    public class CharacterAssets
    {
        protected ESIEve EasyObject;

        internal CharacterAssets(ESIEve EasyEve)
        {
            EasyObject = EasyEve;
        }

        /// <summary>Get All Character's Assets</summary>
        /// <remarks>Requires SSO Authentication, using "read_assets" scope</remarks>
        /// <param name="CharacterID">(Int32) Character ID</param>
        /// <returns>EsiRequest</returns>
        public EsiRequest GetAll(int CharacterID)
        {
            var Path = $"/characters/{CharacterID.ToString()}/assets/";
            return new EsiRequest(EasyObject, Path, EsiWebMethod.AuthGet);
        }
    }
}
