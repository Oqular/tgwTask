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
        private int numberOfAisles { get; set; }
        //private Dictionary<string, string> additionalInfo { get; set; }

        public Config()
        {
            this.ordersPerHour = -1;
            this.orderLinesPerOrder = -1;
            this.inboundStrategy = "Error";
            this.powerSupply = "Error";
            this.resultStartTime = DateTime.MinValue;
            this.resultInterval = -1;
            this.numberOfAisles = -1;
        }

        public void setOrdersPerHour(string ordersPerHour)
        {
            try
            {
                this.ordersPerHour = int.Parse(ordersPerHour);
            }
            catch (FormatException e)
            {
                Console.WriteLine("ordersPerHour input is not in a valid format!!!");
                Console.WriteLine();//skip line to make exeption more clear
            }
        }

        public int getOrdersPerHour()
        {
            return this.ordersPerHour;
        }

        public void setOrderLinesPerOrder(string orderLinesPerOrder)
        {
            try
            {
                this.orderLinesPerOrder = int.Parse(orderLinesPerOrder);
            }
            catch (FormatException e)
            {
                Console.WriteLine("orderLinesPerOrder input is not in a valid format!!!");
                Console.WriteLine();//skip line to make exeption more clear
            }
        }

        public int getOrderLinesPerOrder()
        {
            return this.orderLinesPerOrder;
        }

        public void setInboundStrategy(string inboundStrategy)
        {
            if (inboundStrategy.Equals("random") || inboundStrategy.Equals("optimized"))
            {
                this.inboundStrategy = inboundStrategy;
            }
            else
            {
                Console.WriteLine("inboundStrategy can only be random/optimized");
                Console.WriteLine();//skip line to make exeption more clear
            }
        }

        public string getInboundStrategy()
        {
            return this.inboundStrategy;
        }

        public void setPowerSupply(string powerSupply)
        {
            
            if (powerSupply.Equals("normal") || powerSupply.Equals("big"))
            {
                this.powerSupply = powerSupply;
            }
            else
            {
                Console.WriteLine("powerSupply can only be normal/big");
                Console.WriteLine();//skip line to make exeption more clear
            }
        }

        public string getPowerSupply()
        {
            return this.powerSupply;
        }

        public void setResultStartTime(string resultStartTime)
        {
            try
            {
                this.resultStartTime = DateTime.Parse(resultStartTime);
            }
            catch (FormatException e)
            {
                Console.WriteLine("resultStartTime input is not in a valid format!!!");
                Console.WriteLine();//skip line to make exeption more clear
            }
        }

        public DateTime getResultStartTime()
        {
            return this.resultStartTime;
        }

        public void setResultInterval(string resultInterval)
        {
            try
            {
                this.resultInterval = double.Parse(resultInterval);
            }
            catch (FormatException e)
            {
                Console.WriteLine("resultInterval input is not in a valid format!!!");
                Console.WriteLine();//skip line to make exeption more clea
            }
        }

        public double getResultInterval()
        {
            return this.resultInterval;
        }

        public void setNumberOfAisles(string numberOfAisles)
        {
            try
            {
                this.numberOfAisles = int.Parse(numberOfAisles);
                //Can check if aisles number is >=5 and assign powerSupply as big if true
            }
            catch(FormatException e)
            {
                Console.WriteLine("numberOfAisles input is not in a valid format!!!");
                Console.WriteLine();//skip line to make exeption more clea
            }
        }

        public int getNumberOfAisles()
        {
            return this.numberOfAisles;
        }

        /// <summary>
        /// assign value to the property according to the config id
        /// </summary>
        /// <param name="id">config id</param>
        /// <param name="value">value that needs to be assigned</param>
        public void AssignValue(string id, string value)
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
                case nameof(this.numberOfAisles):
                    setNumberOfAisles(value);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// writes config-value of requested config to console
        /// </summary>
        /// <param name="id">config-id</param>
        public void WriteConfigInfo(string id)
        {
            Console.WriteLine("If config-value is -1 or Error it either does not exist or is invalid");
            switch (id)
            {
                case "All":
                    Console.WriteLine("All info:");
                    Console.WriteLine("{0}: {1}", nameof(this.ordersPerHour), this.ordersPerHour);
                    Console.WriteLine("{0}: {1}", nameof(this.orderLinesPerOrder), this.orderLinesPerOrder);
                    Console.WriteLine("{0}: {1}", nameof(this.inboundStrategy), this.inboundStrategy);
                    Console.WriteLine("{0}: {1}", nameof(this.powerSupply), this.powerSupply);
                    Console.WriteLine("{0}: {1}", nameof(this.resultStartTime), this.resultStartTime.ToString("HH:mm:ss"));
                    Console.WriteLine("{0}: {1}", nameof(this.resultInterval), this.resultInterval);
                    Console.WriteLine("{0}: {1}", nameof(this.numberOfAisles), this.numberOfAisles);
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
