using System.ComponentModel.DataAnnotations.Schema;

namespace Books_API.Models {
    public class Book {

        [Column("id")]
        public long Id { get; set; }
        [Column("writer")]
        public string Writer { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("theme")]
        public string Theme { get; set; }
        [Column("release_year")]
        public int ReleaseYear { get; set; }

        public Book(long id,string writer, string title, string theme, int releaseYear) {
            Id = id;
            Writer = writer;
            Title = title;
            Theme = theme;
            ReleaseYear = releaseYear;
        }
    }
}
