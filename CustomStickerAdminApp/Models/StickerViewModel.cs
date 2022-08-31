
namespace CustomStickerAdminApp.Models {

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    public class StickerViewModel {
        
        private string name;

        // public StickerViewModel() { }

        public StickerViewModel(Sticker sticker) {
            this.Id = sticker.Id;
            this.ImageUri = sticker.ImageUri;
            this.Name = sticker.Name;
            this.Keywords = string.Join(", ", sticker.Keywords ?? Enumerable.Empty<string>());
            this.Index = sticker.Index;
        }

        public string Id { get; set; }

        [Display(Name = "Image")]
        public Uri ImageUri { get; set; }

        public string Name {
            get { return this.name; }
            set { this.name = value?.Trim(); }
        }

        public string Keywords { get; set; }

        public int Index { get; set; }

        public List<string> GetKeywordsList() {
            return this.Keywords?.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim())
                .Distinct(StringComparer.InvariantCultureIgnoreCase)
                .ToList();
        }

    }
}