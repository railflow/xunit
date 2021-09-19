using System.Collections.Generic;


namespace RainFlowAttributes
{
    public class AttributesContext
    {
        // Todo: use AttributeInfo class instead of string
        private static readonly List<string> attributes = new List<string>();
        private static readonly object obj = new object();
        private static AttributesContext instance = null;

        private AttributesContext()
        {
        }

        public static AttributesContext Instance
        {
            get
            {
                lock (obj)
                {
                    if (instance == null)
                    {
                        instance = new AttributesContext();
                    }
                    return instance;
                }

            }
        }

        public static bool Add(string value)
        {
            attributes.Add(value);
            return true;
        }

        public static List<string> GetAllAttributes()
        {
            return attributes;
        }
    }
}
