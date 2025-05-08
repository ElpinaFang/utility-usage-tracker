using UtilityTracker.API.Models;

namespace UtilityTracker.API.Data
{
    public static class DataSeeder
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.MeterReadings.Any())
            {
                context.MeterReadings.AddRange(
                    new MeterReading { UserId = "user1", ReadingDate = DateTime.Now.AddDays(-2), Electricity = 12.5, Water = 3.2 },
                    new MeterReading { UserId = "user1", ReadingDate = DateTime.Now.AddDays(-1), Electricity = 13.1, Water = 3.4 },
                    new MeterReading { UserId = "user2", ReadingDate = DateTime.Now, Electricity = 10.8, Water = 2.9 }
                );
                context.SaveChanges();
            }
        }
    }
}