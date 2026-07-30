namespace Sea.Models
{
    public class Fish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public bool IsEdible { get; set; }
        public bool IsDangerous { get; set; }
        public string Description { get; set; }
        public string Locations { get; set; }
        public string BreedingSeason { get; set; }
        public string Prevention { get; set; }
        public string MaxSize { get; set; }
        public string MaxAge { get; set; }

        // العلاقة
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<FirstAid> FirstAids { get; set; }


    }
}
