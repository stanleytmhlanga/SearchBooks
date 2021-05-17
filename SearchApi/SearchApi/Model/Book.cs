using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchApi.Model
{
    [Serializable]
    public partial class Book
    {
        [JsonProperty("cover_i")]
        public long CoverI { get; set; }

        [JsonProperty("has_fulltext")]
        public bool HasFulltext { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("title_suggest")]
        public string TitleSuggest { get; set; }

        [JsonProperty("ia_collection_s")]
        public string IaCollectionS { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("ebook_count_i")]
        public long EbookCountI { get; set; }

        [JsonProperty("edition_count")]
        public long EditionCount { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("public_scan_b")]
        public bool PublicScanB { get; set; }

        [JsonProperty("last_modified_i")]
        public long LastModifiedI { get; set; }

        [JsonProperty("cover_edition_key")]
        public string CoverEditionKey { get; set; }

        [JsonProperty("first_publish_year")]
        public long FirstPublishYear { get; set; }

        [JsonProperty("author_name")]
        public List<string> AuthorName { get; set; }

        [JsonProperty("publish_year")]
        public List<long> PublishYear { get; set; }

        [JsonProperty("author_key")]
        public List<string> AuthorKey { get; set; }

        [JsonProperty("seed")]
        public List<string> Seed { get; set; }

        [JsonProperty("subject")]
        public List<string> Subject { get; set; }

        [JsonProperty("isbn")]
        public List<string> Isbn { get; set; }

        [JsonProperty("edition_key")]
        public List<string> EditionKey { get; set; }

        [JsonProperty("language")]
        public List<string> Language { get; set; }

        [JsonProperty("id_librarything")]
        public List<long> IdLibrarything { get; set; }

        [JsonProperty("lcc")]
        public List<string> Lcc { get; set; }

        [JsonProperty("id_goodreads")]
        public List<long> IdGoodreads { get; set; }

        [JsonProperty("lccn")]
        public List<string> Lccn { get; set; }

        [JsonProperty("publish_place")]
        public List<string> PublishPlace { get; set; }

        [JsonProperty("ia")]
        public List<string> Ia { get; set; }

        [JsonProperty("oclc")]
        public List<long> Oclc { get; set; }

        [JsonProperty("publisher")]
        public List<string> Publisher { get; set; }

        [JsonProperty("text")]
        public List<string> Text { get; set; }

        [JsonProperty("publish_date")]
        public List<string> PublishDate { get; set; }
    }
}

