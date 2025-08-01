using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE2
{
    public class Cars
    {
        int carPower, carWeight, carSpeed;
        string carModel, carBrand;


        public Cars(int carPower, int carWeight, int carSpeed, string carModel, string carBrand)
        {
            this.carPower = carPower;
            this.carWeight = carWeight;
            this.carSpeed = carSpeed;
            this.carModel = carModel;
            this.carBrand = carBrand;
        }

        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return this.carPower;
                else if (index == 1)
                    return this.carWeight;
                else if (index == 2)
                    return this.carSpeed;
                else if (index == 3)
                    return this.carModel;
                else if (index == 4)
                    return this.carBrand;
                return null;
            }
            set
            {
                if (index == 0)
                    this.carPower = (int)value;
                else if (index == 1)
                    this.carWeight = (int)value;
                else if (index == 2)
                    this.carSpeed = (int)value;
                else if (index == 3)
                    this.carModel = (string)value;
                else if (index == 4)
                    this.carBrand = (string)value;
            }
        }
        public object this[string attrName]
        {
            get
            {
                if (attrName == "power")
                    return this.carPower;
                else if (attrName == "weight")
                    return this.carWeight;
                else if (attrName == "speed")
                    return this.carSpeed;
                else if (attrName == "model")
                    return this.carModel;
                else if (attrName == "brand")
                    return this.carBrand;
                return null;
            }
            set
            {
                if (attrName.ToLower().Equals("power"))
                    this.carPower = (int)value;
                else if (attrName.ToLower().Equals("weight"))
                    this.carWeight = (int)value;
                else if (attrName.ToLower().Equals("speed"))
                    this.carSpeed = (int)value;
                else if (attrName.ToLower().Equals("model"))
                    this.carModel = (string)value;
                else if (attrName.ToLower().Equals("brand"))
                    this.carBrand = (string)value;
            }
        }
    }
}
