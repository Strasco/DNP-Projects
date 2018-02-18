namespace HelloWorldVSC
{
    class IndexerNames
    {
        private string[] names;
        private int age;
        private int size;

        public IndexerNames(int size)
        {
            this.size = size;
            names = new string[size];
            
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public string this[int indexrange]
        {
            get 
            {
                return names[indexrange];
            }
            set
            {
                names[indexrange] = value;
            }
        }
        public int getSize()
        {
            return size;
        }

    }
}