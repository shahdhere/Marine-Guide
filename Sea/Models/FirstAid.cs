namespace Sea.Models
{
    public class FirstAid
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        // صورة الكائن الضار
        public string ImageUrl { get; set; }

        // ربط اختياري مع Fish
        public int? FishId { get; set; }
        public Fish Fish { get; set; }
    }
}
