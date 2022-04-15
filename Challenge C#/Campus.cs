using System;

namespace CSharpDiscovery.Quest03{

    public class Campus : PointOfInterest {

        public int Capacity{set; get;}

        public override string ToString()
        {
            return this.Name +" is a campus with a capacity of "+Capacity+" students";
        }

    }

}