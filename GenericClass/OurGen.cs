using System;


namespace GenericClass
{
   public class OurGen <T>
    {
        T ourfield;
        public OurGen(T param)
        {
            ourfield = param;
        }

        public void Display()
        {
            Console.WriteLine("Value {0} \n DataType: {1}", ourfield, ourfield.GetType());
        }
    }
}
