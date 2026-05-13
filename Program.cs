using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace azizov_abdulaziz_bilet_21
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class AdCampaign
    {
        // Audience
        public int demographics { set; get; }
        public string location { set; get; }

        // Budget
        public int amount {  set; get; }
        public DateTime duration { set; get; }

        // Channels
        public string channel { set; get; }

        // Schedule
        public int start { set; get; }
        public int end { set; get; }

        // TargetingOption
        public string options { set; get; }

        // Metrics
        public string metrics { set; get; }
    }

    class Campaigh : AdCampaign
    {
        public void SetAudience(int demographics, string location)
        {
            this.demographics = demographics;
            this.location = location;
        }

        public void SetBudget(int amount, DateTime duration)
        {
            this.amount = amount;
            this.duration = duration;
        }

        public void AddChannel(string channel)
        {
            this.channel = channel;
        }

        public void SetSchedule(int start,  int end)
        {
            this.start = start;
            this.end = end;
        }

        public void SetTargetingOptions(string options)
        {
            this.options = options;
        }

        public void DefineMetric(string metrics)
        {
            this.metrics = metrics;
        }
    }


}
