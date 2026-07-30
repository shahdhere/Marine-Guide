using Microsoft.EntityFrameworkCore;
using Sea.Models;
using System.Reflection.Emit;
namespace Sea.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<Fish> Fish { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<FirstAid> FirstAids { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
        new Category
        {
            Id = 1,
            Name = "Fish",
            Description = "جميع الأسماك البحرية الموجودة في المياه السعودية",
            ImageUrl = "/images/fish-category.jpg"
        },
        new Category
        {
            Id = 2,
            Name = "Dangerous",
            Description = "الكائنات البحرية الضارة أو السامة التي يجب الحذر منها",
            ImageUrl = "/images/dangerous-category.jpg"
        }
    );

            modelBuilder.Entity<Fish>().HasData(

                new Fish
                {
                    Id = 1,
                    Name = "Red Sea Grouper (الهامور)",
                    ImageUrl = "/images/Grouper.jpg",
                    IsEdible = true,
                    IsDangerous = false,
                    Description = "من أشهر أسماك البحر الأحمر ويؤكل بكثرة.",
                    Locations = "Red Sea & Arabian Gulf",
                    BreedingSeason = "Summer",
                    Prevention = "No risk",
                    MaxSize = "1 meter",
                    MaxAge = "20 years",
                    CategoryId = 1
                },

                new Fish
                {
                    Id = 2,
                    Name = "Kingfish (الكنعد)",
                    ImageUrl = "/images/Kingfish.jpg",
                    IsEdible = true,
                    IsDangerous = false,
                    Description = "سمكة سريعة ومهمة اقتصاديًا في السعودية.",
                    Locations = "Red Sea & Arabian Gulf",
                    BreedingSeason = "Spring",
                    Prevention = "No risk",
                    MaxSize = "2 meters",
                    MaxAge = "20 years",
                    CategoryId = 1
                },

                new Fish
                {
                    Id = 3,
                    Name = "Barracuda (الباراكودا)",
                    ImageUrl = "/images/Barracuda.jpg",
                    IsEdible = false,
                    IsDangerous = true,
                    Description = "مفترس بحري سريع وقد يكون خطير.",
                    Locations = "Red Sea",
                    BreedingSeason = "Summer",
                    Prevention = "Avoid swimming near it",
                    MaxSize = "1.5 meters",
                    MaxAge = "14 years",
                    CategoryId = 2
                },

                new Fish
                {
                    Id = 4,
                    Name = "Lionfish (سمكة الأسد)",
                    ImageUrl = "/images/Lionfish.jpg",
                    IsEdible = false,
                    IsDangerous = true,
                    Description = "سمكة سامة ذات أشواك خطيرة.",
                    Locations = "Red Sea",
                    BreedingSeason = "All year",
                    Prevention = "Do not touch",
                    MaxSize = "40 cm",
                    MaxAge = "10 years",
                    CategoryId = 2
                },

                new Fish
                {
                    Id = 5,
                    Name = "Stonefish (سمكة الحجر)",
                    ImageUrl = "/images/Stonefish.jpg",
                    IsEdible = false,
                    IsDangerous = true,
                    Description = "أخطر سمكة سامة في العالم.",
                    Locations = "Red Sea",
                    BreedingSeason = "Spring",
                    Prevention = "Avoid stepping on rocks",
                    MaxSize = "50 cm",
                    MaxAge = "10 years",
                    CategoryId = 2
                },


                new Fish
                {
                    Id = 6,
                    Name = "Hamour (هامور الخليج)",
                    ImageUrl = "/images/Hamour.jpg",
                    IsEdible = true,
                    IsDangerous = false,
                    Description = "من أشهر أسماك الخليج العربي.",
                    Locations = "Arabian Gulf",
                    BreedingSeason = "Winter",
                    Prevention = "No risk",
                    MaxSize = "1.2 meters",
                    MaxAge = "15 years",
                    CategoryId = 1
                },

                new Fish
                {
                    Id = 7,
                    Name = "Pufferfish (سمكة النفاخ)",
                    ImageUrl = "/images/Pufferfish.jpg",
                    IsEdible = false,
                    IsDangerous = true,
                    Description = "سمكة سامة جدًا تحتوي على سم قاتل.",
                    Locations = "Red Sea & Arabian Gulf",
                    BreedingSeason = "Summer",
                    Prevention = "Do not eat or touch",
                    MaxSize = "60 cm",
                    MaxAge = "10 years",
                    CategoryId = 2
                },

                new Fish
                {
                    Id = 8,
                    Name = "Mackerel (الماكريل)",
                    ImageUrl = "/images/mackerel.jpg",
                    IsEdible = true,
                    IsDangerous = false,
                    Description = "سمكة سريعة تعيش في أسراب.",
                    Locations = "Arabian Gulf",
                    BreedingSeason = "Spring",
                    Prevention = "No risk",
                    MaxSize = "50 cm",
                    MaxAge = "10 years",
                    CategoryId = 1
                },
                new Fish
                {
                    Id = 9,
                    Name = "Shark (القرش)",
                    ImageUrl = "/images/Shark.jpg",
                    IsEdible = false,
                    IsDangerous = true,
                    Description = "من أشهر المفترسات البحرية في العالم.",
                    Locations = "Red Sea",
                    BreedingSeason = "Summer",
                    Prevention = "Avoid deep water swimming",
                    MaxSize = "6 meters",
                    MaxAge = "30 years",
                    CategoryId = 2
                },

new Fish
{
    Id = 10,
    Name = "Sardine (السردين)",
    ImageUrl = "/images/Sardine.jpg",
    IsEdible = true,
    IsDangerous = false,
    Description = "سمكة صغيرة تعيش في مجموعات كبيرة.",
    Locations = "Arabian Gulf",
    BreedingSeason = "Spring",
    Prevention = "No risk",
    MaxSize = "30 cm",
    MaxAge = "5 years",
    CategoryId = 1
},

new Fish
{
    Id = 11,
    Name = "Parrotfish (سمكة الببغاء)",
    ImageUrl = "/images/Parrotfish.jpg",
    IsEdible = true,
    IsDangerous = false,
    Description = "سمكة ملونة تعيش قرب الشعاب المرجانية.",
    Locations = "Red Sea",
    BreedingSeason = "Summer",
    Prevention = "No risk",
    MaxSize = "1 meter",
    MaxAge = "7 years",
    CategoryId = 1
},

new Fish
{
    Id = 12,
    Name = "Clownfish (سمكة المهرج)",
    ImageUrl = "/images/Clownfish.jpg",
    IsEdible = false,
    IsDangerous = false,
    Description = "سمكة صغيرة تعيش بين شقائق النعمان البحرية.",
    Locations = "Red Sea",
    BreedingSeason = "All year",
    Prevention = "No risk",
    MaxSize = "15 cm",
    MaxAge = "6 years",
    CategoryId = 1
},


new Fish
{
    Id = 13,
    Name = "Sea Turtle (السلحفاة البحرية)",
    ImageUrl = "/images/Turtle.jpg",
    IsEdible = false,
    IsDangerous = false,
    Description = "كائن بحري يعيش لفترات طويلة.",
    Locations = "Red Sea & Arabian Gulf",
    BreedingSeason = "Summer",
    Prevention = "Protected species",
    MaxSize = "1.5 meters",
    MaxAge = "80 years",
    CategoryId = 1
},

new Fish
{
    Id = 14,
    Name = "Jellyfish (قنديل البحر)",
    ImageUrl = "/images/Jellyfish.jpg",
    IsEdible = false,
    IsDangerous = true,
    Description = "كائن بحري لاسع قد يسبب ألم شديد.",
    Locations = "Red Sea",
    BreedingSeason = "Summer",
    Prevention = "Avoid touching",
    MaxSize = "40 cm",
    MaxAge = "1 year",
    CategoryId = 2
},

new Fish
{
    Id = 15,
    Name = "Cuttlefish (الحبار)",
    ImageUrl = "/images/Cuttlefish.jpg",
    IsEdible = true,
    IsDangerous = false,
    Description = "رخوي بحري سريع الحركة ويستخدم الحبر للدفاع.",
    Locations = "Arabian Gulf",
    BreedingSeason = "Spring",
    Prevention = "No risk",
    MaxSize = "50 cm",
    MaxAge = "2 years",
    CategoryId = 1
},

new Fish
{
    Id = 16,
    Name = "Blue Crab (السلطعون الأزرق)",
    ImageUrl = "/images/Crab.jpg",
    IsEdible = true,
    IsDangerous = false,
    Description = "من القشريات البحرية المنتشرة بالخليج.",
    Locations = "Arabian Gulf",
    BreedingSeason = "Summer",
    Prevention = "Watch for claws",
    MaxSize = "25 cm",
    MaxAge = "4 years",
    CategoryId = 1
},
new Fish
{
    Id = 17,
    Name = "Emperor Fish (الشعري)",
    ImageUrl = "/images/emperor.jpg",
    IsEdible = true,
    IsDangerous = false,
    Description = "Popular food fish in Saudi Arabia.",
    Locations = "Red Sea & Arabian Gulf",
    BreedingSeason = "Spring",
    Prevention = "No risk",
    MaxSize = "80 cm",
    MaxAge = "15 years",
    CategoryId = 1
},

new Fish
{
    Id = 18,
    Name = "Rabbitfish (الصافي)",
    ImageUrl = "/images/Rabbitfish.jpg",
    IsEdible = true,
    IsDangerous = false,
    Description = "Common reef fish.",
    Locations = "Red Sea",
    BreedingSeason = "Summer",
    Prevention = "No risk",
    MaxSize = "40 cm",
    MaxAge = "8 years",
    CategoryId = 1
},

new Fish
{
    Id = 19,
    Name = "Tilapia (البلطي)",
    ImageUrl = "/images/Tilapia.jpg",
    IsEdible = true,
    IsDangerous = false,
    Description = "Widely consumed fish.",
    Locations = "Saudi coastal waters",
    BreedingSeason = "Summer",
    Prevention = "No risk",
    MaxSize = "60 cm",
    MaxAge = "10 years",
    CategoryId = 1
},
new Fish
{
    Id = 20,
    Name = "Moray Eel (ثعبان البحر)",
    ImageUrl = "/images/MorayEel.jpg",
    IsEdible = false,
    IsDangerous = true,
    Description = "Can bite when threatened.",
    Locations = "Red Sea",
    BreedingSeason = "All year",
    Prevention = "Keep your distance",
    MaxSize = "2 meters",
    MaxAge = "30 years",
    CategoryId = 2
},

new Fish
{
    Id = 21,
    Name = "Sea Snake (ثعبان البحر السام)",
    ImageUrl = "/images/SeaSnake.jpg",
    IsEdible = false,
    IsDangerous = true,
    Description = "Highly venomous marine snake.",
    Locations = "Red Sea",
    BreedingSeason = "Summer",
    Prevention = "Never touch it",
    MaxSize = "1.5 meters",
    MaxAge = "10 years",
    CategoryId = 2
},
new Fish
{
    Id = 22,
    Name = "Stingray (اللخمة)",
    ImageUrl = "/images/Stingray.jpg",
    IsEdible = false,
    IsDangerous = true,
    Description = "A marine ray with a venomous tail spine that can cause serious injuries.",
    Locations = "Red Sea & Arabian Gulf",
    BreedingSeason = "Spring",
    Prevention = "Shuffle your feet while walking in shallow water and avoid touching it.",
    MaxSize = "2 meters",
    MaxAge = "20 years",
    CategoryId = 2
},
new Fish
{
    Id = 23,
    Name = "Octopus (الأخطبوط)",
    ImageUrl = "/images/Octopus.jpg",
    IsEdible = true,
    IsDangerous = false,
    Description = "A smart marine creature with eight arms. It can change color and shape for protection.",
    Locations = "Red Sea & Arabian Gulf",
    BreedingSeason = "Spring",
    Prevention = "Avoid touching wild octopus as some species can be venomous.",
    MaxSize = "1.5 meters",
    MaxAge = "5 years",
    CategoryId = 1
},

new Fish
{
    Id = 24,
    Name = "Squid (الحبار)",
    ImageUrl = "/images/Squid.jpg",
    IsEdible = true,
    IsDangerous = false,
    Description = "A fast-moving marine animal that uses ink as a defense mechanism.",
    Locations = "Red Sea & Arabian Gulf",
    BreedingSeason = "Spring",
    Prevention = "No major risk",
    MaxSize = "1 meter",
    MaxAge = "2 years",
    CategoryId = 1
},

new Fish
{
    Id = 25,
    Name = "Lobster (جراد البحر)",
    ImageUrl = "/images/Lobster.jpg",
    IsEdible = true,
    IsDangerous = false,
    Description = "A marine crustacean with a hard shell and strong claws.",
    Locations = "Red Sea",
    BreedingSeason = "Summer",
    Prevention = "Be careful of claws when handling.",
    MaxSize = "60 cm",
    MaxAge = "50 years",
    CategoryId = 1
},

new Fish
{
    Id = 26,
    Name = "Shrimp (الروبيان)",
    ImageUrl = "/images/Shrimp.jpg",
    IsEdible = true,
    IsDangerous = false,
    Description = "A common seafood crustacean found in coastal waters.",
    Locations = "Red Sea & Arabian Gulf",
    BreedingSeason = "All year",
    Prevention = "No risk",
    MaxSize = "25 cm",
    MaxAge = "6 years",
    CategoryId = 1
},

new Fish
{
    Id = 27,
    Name = "Sea Urchin (قنفذ البحر)",
    ImageUrl = "/images/SeaUrchin.jpg",
    IsEdible = false,
    IsDangerous = true,
    Description = "A marine animal covered with sharp spines that can cause injuries.",
    Locations = "Red Sea",
    BreedingSeason = "Summer",
    Prevention = "Avoid stepping on it and do not touch with bare hands.",
    MaxSize = "15 cm",
    MaxAge = "20 years",
    CategoryId = 2
},

new Fish
{
    Id = 28,
    Name = "Starfish (نجم البحر)",
    ImageUrl = "/images/Starfish.jpg",
    IsEdible = false,
    IsDangerous = false,
    Description = "A marine animal with a star-shaped body that lives on the seabed.",
    Locations = "Red Sea",
    BreedingSeason = "Spring",
    Prevention = "Do not remove from water.",
    MaxSize = "30 cm",
    MaxAge = "35 years",
    CategoryId = 1
},

new Fish
{
    Id = 29,
    Name = "Dolphin (الدلفين)",
    ImageUrl = "/images/Dolphin.jpg",
    IsEdible = false,
    IsDangerous = false,
    Description = "An intelligent marine mammal known for its social behavior.",
    Locations = "Red Sea",
    BreedingSeason = "All year",
    Prevention = "Do not disturb or approach wild dolphins.",
    MaxSize = "4 meters",
    MaxAge = "60 years",
    CategoryId = 1
},

new Fish
{
    Id = 30,
    Name = "Whale (الحوت)",
    ImageUrl = "/images/Whale.jpg",
    IsEdible = false,
    IsDangerous = false,
    Description = "A large marine mammal found in deep ocean waters.",
    Locations = "Red Sea",
    BreedingSeason = "Winter",
    Prevention = "Keep distance from wild whales.",
    MaxSize = "15 meters",
    MaxAge = "70 years",
    CategoryId = 1
},

new Fish
{
    Id = 31,
    Name = "Sea Cucumber (خيار البحر)",
    ImageUrl = "/images/SeaCucumber.jpg",
    IsEdible = false,
    IsDangerous = false,
    Description = "A marine animal that helps clean the ocean floor.",
    Locations = "Red Sea",
    BreedingSeason = "Summer",
    Prevention = "Avoid collecting protected species.",
    MaxSize = "40 cm",
    MaxAge = "10 years",
    CategoryId = 1
},

new Fish
{
    Id = 32,
    Name = "Coral (الشعاب المرجانية)",
    ImageUrl = "/images/Coral.jpg",
    IsEdible = false,
    IsDangerous = false,
    Description = "Marine ecosystem that provides shelter for many sea creatures.",
    Locations = "Red Sea",
    BreedingSeason = "All year",
    Prevention = "Do not touch or damage coral reefs.",
    MaxSize = "Several meters",
    MaxAge = "Hundreds of years",
    CategoryId = 1
},

new Fish
{
    Id = 33,
    Name = "Sea Anemone (شقائق النعمان البحرية)",
    ImageUrl = "/images/SeaAnemon.jpg",
    IsEdible = false,
    IsDangerous = true,
    Description = "A marine animal with stinging tentacles that may irritate skin.",
    Locations = "Red Sea",
    BreedingSeason = "All year",
    Prevention = "Avoid touching tentacles.",
    MaxSize = "50 cm",
    MaxAge = "50 years",
    CategoryId = 2
},

new Fish
{
    Id = 34,
    Name = "Fire Coral (المرجان الناري)",
    ImageUrl = "/images/FireCoral.jpg",
    IsEdible = false,
    IsDangerous = true,
    Description = "A marine organism that can cause painful skin irritation.",
    Locations = "Red Sea",
    BreedingSeason = "Summer",
    Prevention = "Do not touch underwater.",
    MaxSize = "1 meter",
    MaxAge = "Many years",
    CategoryId = 2
},

new Fish
{
    Id = 35,
    Name = "Cone Snail (حلزون البحر المخروطي)",
    ImageUrl = "/images/ConeSnail.jpg",
    IsEdible = false,
    IsDangerous = true,
    Description = "A venomous marine snail that can inject dangerous toxins.",
    Locations = "Red Sea",
    BreedingSeason = "Summer",
    Prevention = "Never pick up shells with living creatures inside.",
    MaxSize = "20 cm",
    MaxAge = "10 years",
    CategoryId = 2
},

new Fish
{
    Id = 36,
    Name = "Blue-Ringed Octopus (الأخطبوط ذو الحلقات الزرقاء)",
    ImageUrl = "/images/Blue-RingedOctopus.jpg",
    IsEdible = false,
    IsDangerous = true,
    Description = "A highly venomous octopus with a dangerous bite.",
    Locations = "Warm coastal waters",
    BreedingSeason = "Spring",
    Prevention = "Never touch it.",
    MaxSize = "20 cm",
    MaxAge = "2 years",
    CategoryId = 2
}

);

            modelBuilder.Entity<FirstAid>()
    .HasOne(x => x.Fish)
    .WithMany(x => x.FirstAids)
    .HasForeignKey(x => x.FishId)
    .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<FirstAid>().HasData(

new FirstAid
     {
         Id = 1,
         FishId = 3,
         ImageUrl = "/images/Barracuda.jpg",
         Title = "Barracuda Bite",
         Description = "Wash the wound with clean water, stop bleeding, and seek medical help immediately."
     },

     new FirstAid
     {
         Id = 2,
         FishId = 4,
         ImageUrl = "/images/Lionfish.jpg",
         Title = "Lionfish Sting",
         Description = "Place the injured area in hot water for 30-90 minutes and go to the hospital."
     },

     new FirstAid
     {
         Id = 3,
         FishId = 5,
         ImageUrl = "/images/Stonefish.jpg",
         Title = "Stonefish Sting",
         Description = "Call emergency services immediately and soak the wound in hot water."
     },

     new FirstAid
     {
         Id = 4,
         FishId = 7,
         ImageUrl = "/images/Pufferfish.jpg",
         Title = "Pufferfish Poisoning",
         Description = "Call emergency services immediately. Do not wait for symptoms."
     },

     new FirstAid
     {
         Id = 8,
         FishId = 14,
         ImageUrl = "/images/Jellyfish.jpg",
         Title = "Jellyfish Sting",
         Description = "Rinse with seawater and use vinegar if available. Do not rub the skin."
     },
     new FirstAid
     {
         Id = 9,
         FishId = 20,
         ImageUrl = "/images/MorayEel.jpg",
         Title = "Moray Eel Bite",
         Description = "Wash the wound with clean water, control bleeding, cover it with a sterile dressing, and seek medical attention to prevent infection."
     },

new FirstAid
{
    Id = 10,
    FishId = 21,
    ImageUrl = "/images/SeaSnake.jpg",
    Title = "Sea Snake Bite",
    Description = "Keep the victim calm and still, immobilize the affected limb, and seek emergency medical care immediately. Do not cut the wound or try to suck out the venom."
},

new FirstAid
{
    Id = 11,
    FishId = 22,
    ImageUrl = "/images/Stingray.jpg",
    Title = "Stingray Injury",
    Description = "Control bleeding, soak the injured area in hot (not boiling) water for 30–90 minutes, clean the wound, and seek medical attention immediately."
},
new FirstAid
{
    Id = 12,
    FishId = 27,
    ImageUrl = "/images/SeaUrchin.jpg",
    Title = "Sea Urchin Injury",
    Description = "Remove visible spines carefully, wash the area, soak in warm water to reduce pain, and seek medical help if spines remain."
},

new FirstAid
{
    Id = 13,
    FishId = 33,
    ImageUrl = "/images/SeaAnemon.jpg",
    Title = "Sea Anemone Sting",
    Description = "Rinse the affected area with seawater, remove tentacles carefully, and seek medical advice if irritation continues."
},

new FirstAid
{
    Id = 14,
    FishId = 34,
    ImageUrl = "/images/FireCoral.jpg",
    Title = "Fire Coral Contact",
    Description = "Rinse with seawater, avoid rubbing the skin, and treat irritation with appropriate first aid."
},

new FirstAid
{
    Id = 15,
    FishId = 35,
    ImageUrl = "/images/ConeSnail.jpg",
    Title = "Cone Snail Sting",
    Description = "Do not touch the animal. Immobilize the affected area and seek emergency medical care immediately."
},

new FirstAid
{
    Id = 16,
    FishId = 36,
    ImageUrl = "/images/Blue-RingedOctopus.jpg",
    Title = "Blue-Ringed Octopus Bite",
    Description = "Seek emergency medical help immediately. Keep the victim still and monitor breathing."
}

 );
        }
    }
}