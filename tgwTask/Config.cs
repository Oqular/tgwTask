using System;
using System.Collections.Generic;
using System.Text;

namespace tgwTask
{
    class Config
    {
        private int ordersPerHour { get; set; }
        private int orderLinesPerOrder { get; set; }
        private string inboundStrategy { get; set; }
        private string powerSupply { get; set; }
        private DateTime resultStartTime { get; set; }
        private double resultInterval { get; set; }

        public Config()
        {
        }

        public void setOrdersPerHour(string ordersPerHour)
        {
            this.ordersPerHour = int.Parse(ordersPerHour);
        }

        public int getOrdersPerHour()
        {
            return this.ordersPerHour;
        }

        public void setOrderLinesPerOrder(string orderLinesPerOrder)
        {
            this.orderLinesPerOrder = int.Parse(orderLinesPerOrder);
        }

        public int getOrderLinesPerOrder()
        {
            return this.orderLinesPerOrder;
        }

        public void setInboundStrategy(string inboundStrategy)
        {
            this.inboundStrategy = inboundStrategy;
        }

        public string getInboundStrategy()
        {
            return this.inboundStrategy;
        }

        public void setPowerSupply(string powerSupply)
        {
            this.powerSupply = powerSupply;
        }

        public string getPowerSupply()
        {
            return this.powerSupply;
        }

        public void setResultStartTime(string resultStartTime)
        {
            this.resultStartTime = DateTime.Parse(resultStartTime);
        }

        public DateTime getResultStartTime()
        {
            return this.resultStartTime;
        }

        public void setResultInterval(string resultInterval)
        {
            this.resultInterval = double.Parse(resultInterval);
        }

        public double getResultInterval()
        {
            return this.resultInterval;
        }

        /// <summary>
        /// assign value to the property according to the config id
        /// </summary>
        /// <param name="id">config id</param>
        /// <param name="value">value that needs to be assigned</param>
        public void assignValue(string id, string value)
        {
            switch (id)
            {
                case nameof(this.ordersPerHour):
                    setOrdersPerHour(value);
                    break;
                case nameof(this.orderLinesPerOrder):
                    setOrderLinesPerOrder(value);
                    break;
                case nameof(this.inboundStrategy):
                    setInboundStrategy(value);
                    break;
                case nameof(this.powerSupply):
                    setPowerSupply(value);
                    break;
                case nameof(this.resultStartTime):
                    setResultStartTime(value);
                    break;
                case nameof(this.resultInterval):
                    setResultInterval(value);
                    break;
                default:
                    break;
            }
        }

        public void writeConfigInfo(string id)
        {
            switch (id)
            {
                case "All":
                    Console.WriteLine("All info");
                    break;
                case nameof(this.ordersPerHour):
                    Console.WriteLine("{0}: {1}", id, this.ordersPerHour);
                    break;
                case nameof(this.orderLinesPerOrder):
                    Console.WriteLine("{0}: {1}", id, this.orderLinesPerOrder);
                    break;
                case nameof(this.inboundStrategy):
                    Console.WriteLine("{0}: {1}", id, this.inboundStrategy);
                    break;
                case nameof(this.powerSupply):
                    Console.WriteLine("{0}: {1}", id, this.powerSupply);
                    break;
                case nameof(this.resultStartTime):
                    Console.WriteLine("{0}: {1}", id, this.resultStartTime.ToString("HH:mm:ss"));
                    break;
                case nameof(this.resultInterval):
                    Console.WriteLine("{0}: {1}", id, this.resultInterval);
                    break;
                default:
                    Console.WriteLine("Requested Config-Id does not exist");
                    break;
            }
        }
    }
}
