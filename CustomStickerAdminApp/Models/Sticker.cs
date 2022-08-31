
namespace CustomStickerAdminApp.Models {
    
    using System;
    using System.Collections.Generic;

    public class Sticker {
        public string Id { get; set; }

        public Uri ImageUri { get; set; }

        public string Name { get; set; }

        public IList<string> Keywords { get; set; }

        public int Index { get; set; }

    }
}