using System.ComponentModel.DataAnnotations;

namespace MVCMusicStore.Models
{
    public class Review
    {
        public int ReviewId { get; set; }

        public int AlbumId { get; set; }

        //public virtual Album Album { get; set; }

        public string Contents { get; set; }

        [Display(Name ="Email address")]
        [DataType(DataType.EmailAddress)]
        public string ReviewerEmail { get; set; }
    }
}