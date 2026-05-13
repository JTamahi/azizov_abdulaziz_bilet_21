using System;
using System.Collections.Generic;

namespace azizov_abdulaziz_bilet_21
{
    class AdCampaign
    {
        public string Audience;
        public double Budget;
        public List<string> Channels = new List<string>();
        public string Schedule;
        public string TargetingOptions;
        public List<string> Metrics = new List<string>();

        public void ShowInfo()
        {
            Console.WriteLine("Аудитория: " + Audience);
            Console.WriteLine("Бюджет: " + Budget + "$");
            Console.WriteLine("Каналы: " + string.Join(", ", Channels));
            Console.WriteLine("Расписание: " + Schedule);
            Console.WriteLine("Таргетинг: " + TargetingOptions);
            Console.WriteLine("Метрики: " + string.Join(", ", Metrics));
            Console.WriteLine();
        }
    }

    class Campaign
    {
        private AdCampaign campaign = new AdCampaign();

        public void SetAudience(string demographics, string location)
        {
            campaign.Audience = demographics + ", " + location;
        }

        public void SetBudget(double amount, string duration)
        {
            campaign.Budget = amount;
        }

        public void AddChannel(string channel)
        {
            campaign.Channels.Add(channel);
        }

        public void SetSchedule(string start, string end)
        {
            campaign.Schedule = "с " + start + " по " + end;
        }

        public void SetTargetingOptions(string options)
        {
            campaign.TargetingOptions = options;
        }

        public void DefineMetrics(string metrics)
        {
            campaign.Metrics.Add(metrics);
        }

        public AdCampaign Build()
        {
            AdCampaign result = campaign;
            campaign = new AdCampaign();
            return result;
        }
    }

    class SocialMediaCampaign
    {
        public static AdCampaign Create()
        {
            Campaign builder = new Campaign();
            builder.SetAudience("18-25 лет", "Алматы");
            builder.SetBudget(1000, "30 дней");
            builder.AddChannel("Instagram");
            builder.AddChannel("TikTok");
            builder.SetSchedule("01.06.2026", "30.06.2026");
            builder.SetTargetingOptions("По интересам");
            builder.DefineMetrics("Клики");
            builder.DefineMetrics("Показы");
            return builder.Build();
        }
    }

    class SearchEngineCampaign
    {
        public static AdCampaign Create()
        {
            Campaign builder = new Campaign();
            builder.SetAudience("Все возрасты", "Казахстан");
            builder.SetBudget(2000, "30 дней");
            builder.AddChannel("Google");
            builder.AddChannel("Yandex");
            builder.SetSchedule("01.06.2026", "30.06.2026");
            builder.SetTargetingOptions("По ключевым словам");
            builder.DefineMetrics("Клики");
            builder.DefineMetrics("Просмотры");
            return builder.Build();
        }
    }

    class EmailMarketingCampaign
    {
        public static AdCampaign Create()
        {
            Campaign builder = new Campaign();
            builder.SetAudience("Постоянные клиенты", "Онлайн");
            builder.SetBudget(500, "14 дней");
            builder.AddChannel("Email");
            builder.SetSchedule("01.06.2026", "14.06.2026");
            builder.SetTargetingOptions("По сегментам");
            builder.DefineMetrics("Открытия");
            builder.DefineMetrics("Клики");
            return builder.Build();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Campaign builder = new Campaign();
            builder.SetAudience("25-35 лет", "Астана");
            builder.SetBudget(1500, "7 дней");
            builder.AddChannel("Instagram");
            builder.AddChannel("Email");
            builder.SetSchedule("10.06.2026", "17.06.2026");
            builder.SetTargetingOptions("По интересам");
            builder.DefineMetrics("Клики");
            builder.DefineMetrics("Показы");
            AdCampaign custom = builder.Build();
            custom.ShowInfo();

            AdCampaign social = SocialMediaCampaign.Create();
            social.ShowInfo();

            AdCampaign search = SearchEngineCampaign.Create();
            search.ShowInfo();

            AdCampaign email = EmailMarketingCampaign.Create();
            email.ShowInfo();
        }
    }
}
