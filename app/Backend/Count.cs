namespace HP.Documents.resumepage.app.Backend
{
    public class Count
    {
        [JsonProperty ("id")]
        public int Id { get; set; }
        [JsonProperty ("visitorcount")]
        public int count { get; set; }

    }
}